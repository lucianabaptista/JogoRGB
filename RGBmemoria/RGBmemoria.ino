const int vermelho = 5;
const int azul = 6;
const int verde = 7;

void setup() {
  Serial.begin(9600);
  pinMode(vermelho, OUTPUT);
  pinMode(verde, OUTPUT);
  pinMode(azul, OUTPUT);

  digitalWrite(vermelho, HIGH);
  digitalWrite(verde, HIGH);
  digitalWrite(azul, HIGH);
}

void loop() {

  char cores[25];
  int i=0;
  if (Serial.available())
  {
    char cor = Serial.read();
    cores[i] = cor;

    if(cores[i] == '1'){
      digitalWrite(vermelho, LOW);
      digitalWrite(verde, HIGH);
      digitalWrite(azul, HIGH);
    }
    if(cores[i] == '2'){
      digitalWrite(vermelho, HIGH);
      digitalWrite(verde, LOW);
      digitalWrite(azul, HIGH);
    }
    if(cores[i] == '3'){
      digitalWrite(vermelho, HIGH);
      digitalWrite(verde, HIGH);
      digitalWrite(azul, LOW);
    }
    delay(2000);
    digitalWrite(vermelho, HIGH);
    digitalWrite(verde, HIGH);
    digitalWrite(azul, HIGH);
    delay(1000);
    i++;
  }
}
