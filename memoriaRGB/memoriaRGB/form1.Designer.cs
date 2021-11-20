namespace memoriaRGB
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnVermelho = new System.Windows.Forms.Button();
            this.btnVerde = new System.Windows.Forms.Button();
            this.btnAzul = new System.Windows.Forms.Button();
            this.btnJogar = new System.Windows.Forms.Button();
            this.lblCor = new System.Windows.Forms.Label();
            this.lblAcertouErrou = new System.Windows.Forms.Label();
            this.lblGameOver = new System.Windows.Forms.Label();
            this.btnRegras = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.lstScore = new System.Windows.Forms.ListBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblNivel = new System.Windows.Forms.Label();
            this.cmbNivel = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(12, 28);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(56, 21);
            this.txtNome.MaxLength = 20;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(137, 20);
            this.txtNome.TabIndex = 1;
            // 
            // btnVermelho
            // 
            this.btnVermelho.BackColor = System.Drawing.Color.Red;
            this.btnVermelho.Enabled = false;
            this.btnVermelho.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVermelho.ForeColor = System.Drawing.Color.White;
            this.btnVermelho.Location = new System.Drawing.Point(12, 104);
            this.btnVermelho.Name = "btnVermelho";
            this.btnVermelho.Size = new System.Drawing.Size(85, 29);
            this.btnVermelho.TabIndex = 2;
            this.btnVermelho.Text = "VERMELHO";
            this.btnVermelho.UseVisualStyleBackColor = false;
            this.btnVermelho.Click += new System.EventHandler(this.BtnVermelho_Click);
            // 
            // btnVerde
            // 
            this.btnVerde.BackColor = System.Drawing.Color.Green;
            this.btnVerde.Enabled = false;
            this.btnVerde.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerde.ForeColor = System.Drawing.Color.White;
            this.btnVerde.Location = new System.Drawing.Point(103, 104);
            this.btnVerde.Name = "btnVerde";
            this.btnVerde.Size = new System.Drawing.Size(85, 29);
            this.btnVerde.TabIndex = 3;
            this.btnVerde.Text = "VERDE";
            this.btnVerde.UseVisualStyleBackColor = false;
            this.btnVerde.Click += new System.EventHandler(this.BtnVerde_Click);
            // 
            // btnAzul
            // 
            this.btnAzul.BackColor = System.Drawing.Color.Blue;
            this.btnAzul.Enabled = false;
            this.btnAzul.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAzul.ForeColor = System.Drawing.Color.White;
            this.btnAzul.Location = new System.Drawing.Point(194, 104);
            this.btnAzul.Name = "btnAzul";
            this.btnAzul.Size = new System.Drawing.Size(85, 29);
            this.btnAzul.TabIndex = 4;
            this.btnAzul.Text = "AZUL";
            this.btnAzul.UseVisualStyleBackColor = false;
            this.btnAzul.Click += new System.EventHandler(this.BtnAzul_Click);
            // 
            // btnJogar
            // 
            this.btnJogar.Location = new System.Drawing.Point(204, 18);
            this.btnJogar.Name = "btnJogar";
            this.btnJogar.Size = new System.Drawing.Size(75, 23);
            this.btnJogar.TabIndex = 5;
            this.btnJogar.Text = "&JOGAR";
            this.btnJogar.UseVisualStyleBackColor = true;
            this.btnJogar.Click += new System.EventHandler(this.BtnJogar_Click);
            // 
            // lblCor
            // 
            this.lblCor.AutoSize = true;
            this.lblCor.Location = new System.Drawing.Point(158, 70);
            this.lblCor.Name = "lblCor";
            this.lblCor.Size = new System.Drawing.Size(29, 13);
            this.lblCor.TabIndex = 6;
            this.lblCor.Text = "Cor :";
            this.lblCor.Visible = false;
            // 
            // lblAcertouErrou
            // 
            this.lblAcertouErrou.AutoSize = true;
            this.lblAcertouErrou.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcertouErrou.ForeColor = System.Drawing.Color.Teal;
            this.lblAcertouErrou.Location = new System.Drawing.Point(204, 70);
            this.lblAcertouErrou.Name = "lblAcertouErrou";
            this.lblAcertouErrou.Size = new System.Drawing.Size(0, 13);
            this.lblAcertouErrou.TabIndex = 7;
            // 
            // lblGameOver
            // 
            this.lblGameOver.AutoSize = true;
            this.lblGameOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameOver.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblGameOver.Location = new System.Drawing.Point(108, 162);
            this.lblGameOver.Name = "lblGameOver";
            this.lblGameOver.Size = new System.Drawing.Size(80, 13);
            this.lblGameOver.TabIndex = 8;
            this.lblGameOver.Text = "GAME OVER";
            this.lblGameOver.Visible = false;
            // 
            // btnRegras
            // 
            this.btnRegras.Location = new System.Drawing.Point(15, 157);
            this.btnRegras.Name = "btnRegras";
            this.btnRegras.Size = new System.Drawing.Size(75, 23);
            this.btnRegras.TabIndex = 10;
            this.btnRegras.Text = "&Regras";
            this.btnRegras.UseVisualStyleBackColor = true;
            this.btnRegras.Click += new System.EventHandler(this.btnRegras_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(204, 157);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 11;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // lstScore
            // 
            this.lstScore.FormattingEnabled = true;
            this.lstScore.Location = new System.Drawing.Point(12, 206);
            this.lstScore.Name = "lstScore";
            this.lstScore.Size = new System.Drawing.Size(276, 199);
            this.lstScore.TabIndex = 12;
            this.lstScore.Visible = false;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(12, 190);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(38, 13);
            this.lblScore.TabIndex = 13;
            this.lblScore.Text = "Score:";
            this.lblScore.Visible = false;
            // 
            // lblNivel
            // 
            this.lblNivel.AutoSize = true;
            this.lblNivel.Location = new System.Drawing.Point(14, 70);
            this.lblNivel.Name = "lblNivel";
            this.lblNivel.Size = new System.Drawing.Size(36, 13);
            this.lblNivel.TabIndex = 14;
            this.lblNivel.Text = "Nível:";
            // 
            // cmbNivel
            // 
            this.cmbNivel.FormattingEnabled = true;
            this.cmbNivel.Items.AddRange(new object[] {
            "Fácil",
            "Médio",
            "Difícil",
            "Especialista",
            "Mestre"});
            this.cmbNivel.Location = new System.Drawing.Point(56, 62);
            this.cmbNivel.Name = "cmbNivel";
            this.cmbNivel.Size = new System.Drawing.Size(75, 21);
            this.cmbNivel.TabIndex = 15;
            this.cmbNivel.SelectedIndexChanged += new System.EventHandler(this.cmbNivel_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 419);
            this.Controls.Add(this.cmbNivel);
            this.Controls.Add(this.lblNivel);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lstScore);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnRegras);
            this.Controls.Add(this.lblGameOver);
            this.Controls.Add(this.lblAcertouErrou);
            this.Controls.Add(this.lblCor);
            this.Controls.Add(this.btnJogar);
            this.Controls.Add(this.btnAzul);
            this.Controls.Add(this.btnVerde);
            this.Controls.Add(this.btnVermelho);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Memória RGB";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnVermelho;
        private System.Windows.Forms.Button btnVerde;
        private System.Windows.Forms.Button btnAzul;
        private System.Windows.Forms.Button btnJogar;
        private System.Windows.Forms.Label lblCor;
        private System.Windows.Forms.Label lblAcertouErrou;
        private System.Windows.Forms.Label lblGameOver;
        private System.Windows.Forms.Button btnRegras;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.ListBox lstScore;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblNivel;
        private System.Windows.Forms.ComboBox cmbNivel;
    }
}

