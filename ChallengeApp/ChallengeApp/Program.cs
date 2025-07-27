using System.Reflection.Metadata.Ecma335;

var myAge = 33;

// liczby całkowite
int myAge2 = 120;
int newAge = myAge2 + 5;
Console.WriteLine(newAge);

int myVar = int.MinValue;
int myVar2 = int.MaxValue;

uint myUVar = uint.MinValue;
uint myUVar2 = uint.MaxValue;

long myVar3 = long.MinValue;
long myVar4 = long.MaxValue;

ulong myUVar3 = ulong.MinValue;
ulong myUVar4 = ulong.MaxValue;

// liczby zmiennoprzecinkowe
float myNumber = float.MinValue;
float myNumber2 = float.MaxValue;

double myDouble = double.MinValue;
double myDouble2 = double.MaxValue;

decimal myDecimal = decimal.MinValue;
decimal myDecimal2 = decimal.MaxValue;

// zmienne tekstowe
string name = "Staszek";
string surname = "Nowak";
string fullName = name + " " + surname;
Console.WriteLine(fullName);
