int ledPin = 5;
int buttonPin = 6;
int ButtonValue = 0;
 
void setup()
{
  pinMode(ledPin, OUTPUT);
  pinMode(buttonPin, INPUT);
  Serial.begin(9600);
}
 
void loop()
{
  // read from the button pin
  ButtonValue = digitalRead(buttonPin);
  if (ButtonValue!=0)
  {
    digitalWrite(ledPin,HIGH);
    Serial.write(1);
    Serial.flush();
    delay(2000);
  }
  else
  {
    digitalWrite(ledPin, LOW);
  }
}
