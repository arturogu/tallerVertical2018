int ledPin = 5;
int buttonPin = 6;
 
void setup()
{
  pinMode(ledPin, OUTPUT);
  pinMode(buttonPin, INPUT);
}
 
void loop()
{
  // read from the button pin
  int button = digitalRead(buttonPin);
  if (button==HIGH)
  {
    digitalWrite(ledPin,HIGH);
  }
  else
  {
    digitalWrite(ledPin, LOW);
  }
}
