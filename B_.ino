#include <Servo.h>
#include <NewPing.h>
 
#define TRIGGER_PIN  10
#define ECHO_PIN     11
#define MAX_DISTANCE 200

    Servo myservo;  // create servo object to control a servo
    int enyakinpalyaco = 500;
    int pos = 500;
    NewPing sonar(TRIGGER_PIN, ECHO_PIN, MAX_DISTANCE);

    
void setup() {
    myservo.attach(7);  // attaches the servo on pin 9 to the servo object
    Serial.begin(115200);
}

void loop() {
  pos = 200;
  enyakinpalyaco = 1000;
  for (int i = 0; i <= 180; i = i + 18) 
  { 
    myservo.write(i);
    delay(100); 
    
      Serial.print("Ping: ");
      Serial.print(sonar.ping_cm());
      Serial.println("cm");
     
  if (sonar.ping_cm() < enyakinpalyaco && sonar.ping_cm() != 0 )
  {
     enyakinpalyaco = sonar.ping_cm();
     pos = i;
}
 }
   myservo.write(pos);
   delay(3000);

}
