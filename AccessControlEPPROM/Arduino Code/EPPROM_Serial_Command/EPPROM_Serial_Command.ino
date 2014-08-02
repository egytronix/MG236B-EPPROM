#include <SerialCommand.h>
#include <Wire.h>

//Project to read and write Atmel AT24C Family EEPROM
//through commands to Ardniuo serial

SerialCommand SCmd; //Object for Serial Command Proccess

int EPPROMaddressVals[8] = {B01010000,B01010001,B01010010,B01010011,B01010100,B01010101,B01010110,B01010111};
int EPPROMaddress = B01010000;

int set_eeprom_address (int from_addr) {
  int EPPROMpage;
  int mod_from_addr;
  
  EPPROMpage = (from_addr/(float)255);
  EPPROMaddress = EPPROMaddressVals[EPPROMpage];
  
  mod_from_addr = (from_addr - (256 * EPPROMpage));
  
  return mod_from_addr;
}

byte eeprom_i2c_read(int from_addr) {
  
  from_addr = set_eeprom_address(from_addr);
  
  Wire.beginTransmission(EPPROMaddress);
  Wire.write(from_addr);
  Wire.endTransmission();

  Wire.requestFrom(EPPROMaddress, 1);
  if(Wire.available())
    return Wire.read();
  else
    return 0xFF;
}

void eeprom_i2c_write(int from_addr, byte data) {
  
  from_addr = set_eeprom_address(from_addr);

    delay (10);
    Wire.available();
    Wire.beginTransmission(EPPROMaddress);
    Wire.write(from_addr);
    Wire.write(data);
    Wire.endTransmission(true);

}

void setup() {
  Wire.begin();        //For EPPROM
  Serial.begin(9600);  //For PC
  
  SCmd.addCommand("read",read_epprom_byte);
  SCmd.addCommand("write",write_epprom_byte);
  SCmd.addCommand("wipe",wipe_epprom);
  SCmd.setDefaultHandler(unrecognized);      // Handler for command that isn't matched
  
  //Welcome Message
  Serial.println("Welcome");
}

void loop() {
  SCmd.readSerial();
}// End of Loop

void read_epprom_byte () {
  int cmdByte;
  char *arg;
  arg = SCmd.next();
  if (arg != NULL) {
    cmdByte = atoi(arg);    // Converts a char string to an integer
  }
  else {
    arg_err();
    return;
  }
  int result;
  result = eeprom_i2c_read(cmdByte);
  Serial.println(result);
}

void write_epprom_byte () {
  int cmdByte;
  int cmdData;
  char *arg;
  
  arg = SCmd.next();
  if (arg != NULL) {
    cmdByte = atoi(arg);    // Converts a char string to an integer
  }
  else {
    arg_err();
    return;
  }
  
  arg = "";
  arg = SCmd.next();
  if (arg != NULL) {
    cmdData = atoi(arg);    // Converts a char string to an integer
  }
  else {
    arg_err();
    return;
  }
  eeprom_i2c_write(cmdByte, cmdData);
  Serial.println("Done");
}

void wipe_epprom (){
 
  for (int from_addr = 0; from_addr < 2048; from_addr++){
    eeprom_i2c_write(from_addr, 0);
  }
  Serial.println("wiped!");
}

// This gets set as the default handler, and gets called when no other command matches.
void unrecognized(const char *command) {
  Serial.println("What?");
}

void arg_err() {
  Serial.println("wrong number of arguments or command not formatted");
}
