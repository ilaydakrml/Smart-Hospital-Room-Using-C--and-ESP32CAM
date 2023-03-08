#include "esp_adc_cal.h"
#include <PulseSensorPlayground.h> 
#include <SPI.h>
#include <Wire.h>

#define USE_ARDUINO_INTERRUPTS true
#define LDR_PIN       13
#define LM35_Sensor1  12
//ilayda kodları
#define ledcikisi     14    //ledin bağlandığı pin
#define fancikisi      2    //fanın bağlandığı pin
#define buzzercikisi   4    //buzzerın bağlandığı pin
#define isitici       16    //ısıtıcının bağlandığı pil
#define ledA           3    //digital pin
#define ledB           1    //digital pin 

int ledval = 0;      //led değeri
int fanval=255;      // fan değeri (ters)
int buzzerval = 0;   // ses değeri 
int isiticival = 0;  // ısıtıcı değeri
//ilayda kodları 

int LM35_Raw_Sensor1 = 0;
int Sicaklik = 0;
int nabiz;
int rxBuff=0;
int foto_flag = 0 ;
int Threshold = 515; // esik degeri
const int PulseWire = 15; // Pulse sensoru bagladigim pin

float Voltage = 0.0;
const float GAMMA = 0.7; 
const float RL10 = 50;
const float BETA = 3950; // should match the Beta Coefficient of the thermistor

PulseSensorPlayground pulseSensor; 



void setup() {
  // put your setup code here, to run once:
  Serial.begin(115200);
  //ilayda kodları
  pinMode(fancikisi, OUTPUT);
  pinMode(buzzercikisi, OUTPUT);
  pinMode(ledcikisi, OUTPUT); 
  pinMode(isitici, OUTPUT);

  //led
  pinMode(ledA, OUTPUT);
  pinMode(ledB, OUTPUT);
  digitalWrite(ledA, HIGH);
  digitalWrite(ledB, LOW);
  //ilayda kodları
  
  pinMode(LDR_PIN, INPUT);

  pulseSensor.analogInput(PulseWire); 
  pulseSensor.setThreshold(Threshold); //esik degerini uyguluyorum
  pulseSensor.begin();

}

void loop() {
  // put your main code here, to run repeatedly:

 
 if(Serial.available() > 0){
  rxBuff = Serial.read();
  }

 if(rxBuff == 11)
 {
    // foto işlemi
    foto_flag = 1;
  
  
    rxBuff = 0;
    delay(1000);
 }
 else if (rxBuff != 11)
     {
      // Read LM35_Sensor1 ADC Pin
      LM35_Raw_Sensor1 = analogRead(LM35_Sensor1);  
      // Calibrate ADC & Get Voltage (in mV)
      Voltage = readADC_Cal(LM35_Raw_Sensor1);
      // TempC = Voltage(mV) / 10
      Sicaklik = Voltage / 10;     //Sıcaklık verisinin tutulduğu degiskenim
    
    
      int analogValue = analogRead(13);
      float voltage = analogValue / 4095. * 5;
      float resistance = 2000 * voltage / (1 - voltage / 5);
      int isik = pow(RL10 * 1e3 * pow(10, GAMMA) / resistance, (1 / GAMMA));
    
      if(isik <= 3) {
        isik = 0;
        }
    
       pulseSensor.sawStartOfBeat();  //Eğer nabız algılarsak
       nabiz = pulseSensor.getBeatsPerMinute(); //Dakikadaki nabzı nabiz değişkenine kaydediyoruz.
    
      Serial.println(String(",") + String(nabiz) + String(",") + String(Sicaklik) + String(",") + String(isik) + String(","));

  //ilayda kodları 
           switch(rxBuff)
          {
            case 20: fanval = 255;      break;
            case 21: fanval = 200;      break;
            case 22: fanval = 50;       break;

            case 30: ledval = 0;        break;
            case 31: ledval = 100;      break;
            case 32: ledval = 250;      break;

            case 40: buzzerval = 0;     break;
            case 41: buzzerval = 1;     break;
            case 42: buzzerval = 200;   break;

            case 50: isiticival = LOW;  break;
            case 51: isiticival = HIGH; break;

               
 

               default: break;
          
          }
    analogWrite(ledcikisi, ledval);
    analogWrite(fancikisi, fanval);
    analogWrite(buzzercikisi, buzzerval);
    digitalWrite(isitici, isiticival);
     
  // 50 yüksek 200 orta 255 kapat fan
  // ampulde fan ve buzzerda tam tersi 
          
          delay(1000);
  //ilayda kodları
    
    }
}

uint32_t readADC_Cal(int ADC_Raw)
{
  esp_adc_cal_characteristics_t adc_chars;
  
  esp_adc_cal_characterize(ADC_UNIT_1, ADC_ATTEN_DB_11, ADC_WIDTH_BIT_12, 1100, &adc_chars);
  return(esp_adc_cal_raw_to_voltage(ADC_Raw, &adc_chars));
}
