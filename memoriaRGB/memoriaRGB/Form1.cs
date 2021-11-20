using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using MySql.Data.MySqlClient;
using System.Threading;

namespace memoriaRGB
{
    public partial class Form1 : Form
    {
        static MySqlConnection conexao;
        static MySqlCommand comando;
        
        int[] leds;
        int nivel = 5;
        int corJogador = 0;
        int numJogada = 0;
        string score = "";
        string nivelNome = "";
                
        public Form1()
        {
            InitializeComponent();
            cmbNivel.SelectedIndex = 0;
            leds = new int[25];

            conectar();
        }

        private void BtnJogar_Click(object sender, EventArgs e)
        {
            lblGameOver.Visible = false;
            corJogador = 0;
            numJogada = 0;
            lblAcertouErrou.Text = "";

            if (txtNome.Text == "")
            {
                MessageBox.Show("Digite seu nome.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNome.Focus();
            }
            else
            {
                Random randNum = new Random();
                for (int i = 0; i < nivel; i++)
                {
                    leds[i] = 1 + randNum.Next(3);
                }
                visibilidadesJogo(false);
                visibilidadesResultado(false);
                MessageBox.Show("Memorize as cores do LED", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                coresArduino();

                Thread.Sleep(nivel * 2000 + (nivel - 1) * 1000);
                visibilidadesBtn(true);
            }
        }

        private void visibilidadesJogo(bool acesso)
        {
            txtNome.Enabled = acesso;
            btnJogar.Enabled = acesso;
            cmbNivel.Enabled = acesso;
        }

        private void visibilidadesBtn(bool acesso)
        {
            btnVermelho.Enabled = acesso;
            btnVerde.Enabled = acesso;
            btnAzul.Enabled = acesso;
        }

        private void visibilidadesResultado(bool acesso)
        {
            lblCor.Visible = acesso;
            lblGameOver.Visible = acesso;
            lblScore.Visible = acesso;
            lstScore.Visible = acesso;
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnVermelho_Click(object sender, EventArgs e)
        {
            corJogador = 1;
            jogada(corJogador);
        }

        private void BtnVerde_Click(object sender, EventArgs e)
        {
            corJogador = 2;
            jogada(corJogador);

        }

        private void BtnAzul_Click(object sender, EventArgs e)
        {
            corJogador = 3;
            jogada(corJogador);
        }

        private void coresArduino()
        {
            string cores = "";
            for (int i = 0; i < nivel; i++)
            {
                cores += leds[i];
            }
            // acender cor arduino
            SerialPort portaSerial = new SerialPort();
            portaSerial.PortName = "COM3";
            portaSerial.BaudRate = 9600;

            portaSerial.Open();
            portaSerial.Write(cores);
            portaSerial.Close();
        }

        private void jogada(int cor)
        {
            lblCor.Text = "Cor " + (numJogada+1).ToString() + ":";
            lblCor.Visible = true;

            if (leds[numJogada] == cor)
            {
                lblAcertouErrou.Text = "ACERTOU";
                lblAcertouErrou.ForeColor = Color.Teal;
            } else
            {
                lblAcertouErrou.Text = "ERROU";
                lblAcertouErrou.ForeColor = Color.OrangeRed;
                visibilidadesBtn(false);
                lblGameOver.Visible = true;
                lblGameOver.Text = "GAME OVER";
                visibilidadesJogo(true);
            }
            numJogada++;
            if (numJogada == nivel && lblAcertouErrou.Text == "ACERTOU")
            {
                visibilidadesBtn(false);
                lblGameOver.Visible = true;
                lblGameOver.Text = "PAREBÉNS !!!";
                // Gravar no BD
                conexao.Open();
                comando = new MySqlCommand("INSERT INTO scores (" +
                                            "nome, nivel, data, hora) " +
                                            "VALUES " +
                                            "('" + txtNome.Text + "', " +
                                            (nivel/5) + ", '" +
                                            DateTime.Now.ToString("yyyy-MM-dd") + "', '" +
                                            DateTime.Now.ToString("H:mm:ss") + "'); ", conexao);
                comando.ExecuteNonQuery();
                exibirScore();
                conexao.Close();

                visibilidadesJogo(true);
            }
        }

        private void cmbNivel_SelectedIndexChanged(object sender, EventArgs e)
        {
            nivel = (cmbNivel.SelectedIndex + 1) * 5;
        }

        private void conectar()
        {
            conexao = new MySqlConnection("server=localhost; uid=root; pwd=root;");
            conexao.Open();

            comando = new MySqlCommand("CREATE DATABASE IF NOT EXISTS bdarduino;" +
                                        "USE bdarduino", conexao);
            comando.ExecuteNonQuery();

            comando = new MySqlCommand("CREATE TABLE IF NOT EXISTS scores (" +
                                            "id INT(3) PRIMARY KEY AUTO_INCREMENT, " +
                                            "nome VARCHAR(20), " +
                                            "nivel INT(1), " +
                                            "data DATE, " +
                                            "hora TIME); ", conexao);
            comando.ExecuteNonQuery();
            conexao.Close();
        }

        private void exibirScore()
        {
            visibilidadesResultado(true);
            lstScore.Items.Clear();
            
            comando = new MySqlCommand("SELECT * FROM scores ORDER BY nivel, data, hora", conexao);
            MySqlDataReader resultado = comando.ExecuteReader();

            while (resultado.Read())
            {
                score = "";
                switch (resultado["nivel"])
                {
                    case 1:
                        nivelNome = "Fácil";
                        break;
                    case 2:
                        nivelNome = "Médio";
                        break;
                    case 3:
                        nivelNome = "Difícil";
                        break;
                    case 4:
                        nivelNome = "Especialista";
                        break;
                    case 5:
                        nivelNome = "Mestre";
                        break;
                }
                score += resultado["nome"] + "\t";
                score += nivelNome + "\t";
                score += resultado["data"].ToString().Substring(0, 10) + " - ";
                score += resultado["hora"].ToString();

                lstScore.Items.Add(score.ToString());
            }
            resultado.Close();
            conexao.Close();
        }

        private void btnRegras_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cada nível apresenta 5 cores a mais.\nEscolha quantas cores consegue memorizar para deixar seu nome nos Scores.", "REGRAS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
