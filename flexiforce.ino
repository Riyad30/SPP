int flexiForcePin = A0; //analog pin 0

int flexiForceReading;
String input;
void setup(){
Serial.begin(9600);
}

void loop(){
  if(Serial.available()){
    input=Serial.read();
    if(input=="Weight"){
      flexiForceReading = analogRead(flexiForcePin);
      Serial.println(flexiForceReading);

      delay(500);
      }
  }


}
