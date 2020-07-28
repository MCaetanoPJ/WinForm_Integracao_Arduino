int LED = 13;

void setup() {
  Serial.begin(9600);    //configura comunicação serial com 9600 bps
  pinMode(LED,OUTPUT);   //configura pino do led como saída
}
void loop() {
   if (Serial.available()) //se byte pronto para leitura
   {
    char leitura = Serial.read();
    if(leitura == '1'){
      digitalWrite(LED, HIGH);
      Serial.println("Led Ligado");
    }
    else if(leitura == '0'){
      digitalWrite(LED, LOW);
      Serial.println("Led Desligado");
    }
  }
}
