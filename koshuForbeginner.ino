const int led_pin = 3; //LED pin number 
const int sw_pin = 8; //Switch pin number
char mode;

int sw_state = LOW;

void setup() {
  mode = 'b';
  Serial.begin(9600); 
  pinMode( led_pin, OUTPUT );
  pinMode( sw_pin, INPUT );
  
}

void loop() {
  sw_state = digitalRead( sw_pin );

  if ( sw_state == HIGH ) {
    mode = 'a';
    digitalWrite( led_pin, LOW );
  }
  else {
    mode = 'b';
    digitalWrite( led_pin, HIGH );
  }
    Serial.println(mode);
    Serial.flush();
}
