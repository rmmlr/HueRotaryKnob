/* Read Quadrature Encoder
   Connect Encoder-Pins to encoder0PinA and encoder0PinB.

   Sketch by elias ruemmler / www.100prznt.de
   v0.1 - initial functions - 20171214
*/

const int encoder0PinA = 6;
const int encoder0PinB = 5;
const int ledPin = 13;

int encoder0PinALast = LOW;
int encoder0PinBLast = LOW;
int ledState = LOW;
int n1 = LOW;
int n2 = LOW;

int encoder0Pos = 0;

void setup() {
  pinMode (encoder0PinA, INPUT);
  pinMode (encoder0PinB, INPUT);
  pinMode(ledPin, OUTPUT);
  digitalWrite(encoder0PinA, HIGH);       // turn on pull-up resistor
  digitalWrite(encoder0PinB, HIGH);       // turn on pull-up resistor
  
  Serial.begin (9600);
  Serial.println ("Start...");
}

void visuState() {
  Serial.println (encoder0Pos);
  
  if (ledState == LOW) {
      ledState = HIGH;
    } else {
      ledState = LOW;
    }
    digitalWrite(ledPin, ledState);
}

void loop() {
  n1 = digitalRead(encoder0PinA);
  n2 = digitalRead(encoder0PinB);
  
  if (encoder0PinALast != n1) {
    if (digitalRead(encoder0PinB) == n1) {
      encoder0Pos--;
    } else {
      encoder0Pos++;
    }
    visuState();
  }

  if (encoder0PinBLast != n2) {
    if (digitalRead(encoder0PinA) == n2) {
      encoder0Pos++;
    } else {
      encoder0Pos--;
    }
    visuState();
  }
  
  encoder0PinALast = n1;
  encoder0PinBLast = n2;
}
