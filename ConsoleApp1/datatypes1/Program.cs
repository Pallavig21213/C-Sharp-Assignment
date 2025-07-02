
//top level statement
using System.Security.Cryptography;

Console.WriteLine("Hello World !!!");

byte v1 = 10;
Console.WriteLine(v1);
Console.WriteLine($"byte min value : {byte.MinValue} Max value :{byte.MaxValue} " +
    $"size :{sizeof(byte)} bytes");

short v2 = 10;
    Console.WriteLine($"short : val : {v2}" +
        $"min value : {short.MinValue} max value : {short.MaxValue} " +
        $"size :  {sizeof(short)} bytes");

int v3 = 4500;
Console.WriteLine($"int val : {v3} Min Value : {int.MinValue} Max Value :{int.MaxValue} " +
$"size : {sizeof(int)} bytes");

long v4 = 9021954218;
Console.WriteLine($"Long : Val : {v4} Min Value : {long.MinValue} Max Value : {long.MaxValue} " +
    $"size : {sizeof(long)} bytes");

float v5 = 12.5f;
Console.WriteLine($"Float Val : {v5} Min Value : {float.MinValue} Max Value : {long .MaxValue}" +
    $"size : { sizeof(float) } bytes");

double v6 = 10.14545;
Console.WriteLine($"double : Val : {v6} Min Value : {double.MinValue} Max Value : {double.MaxValue}" +
  $"size : {sizeof(double)} bytes");

decimal v7 = 124578.45644m;
Console.WriteLine($"decimal : val : {v7} min val : {decimal.MinValue} max val : {decimal.MaxValue} " +
    $"size : {sizeof(decimal)} bytes");

bool status = true;
Console.WriteLine($"bool : value : {status} size : {sizeof(bool)} bytes");

char currency = '$';
Console.WriteLine($"char : value : {currency} size : {sizeof(char)} bytes");

string name = "pallavi";
Console.WriteLine($"string : Value : {name}");

// string function
name = "Bharti";// updated value
Console.WriteLine(name.Length); //number of characters

Console.WriteLine(name.ToUpper());
Console.WriteLine(name.ToLower());

name = "     Bharti";
Console.WriteLine(name.Trim());

name = "\"vihan\"";
Console.WriteLine(name);

name = "'vihan'";
Console.WriteLine(name);

name = "\\vihaan\\";
Console.WriteLine(name);

string firstName = "vihaan";
string lastName = "rathod";

string fullName = firstName + " " + lastName;
Console.WriteLine(fullName);

fullName = firstName + "\t" + lastName;
Console.WriteLine(fullName);

string middleName = "vikhul";

fullName = string.Concat(firstName, " ", middleName, " ", lastName);
Console.WriteLine(fullName);


fullName = string.Join("-", firstName, middleName, lastName);
Console.WriteLine(fullName);

//placeholder syntax
fullName = string.Format("Full Name : {0} {1} {2}", firstName, middleName, lastName);
Console.WriteLine(fullName);

fullName = $"Full Name : {firstName} {middleName} {lastName}";
Console.WriteLine(fullName);

string email = "vihaan@gmail.com";
int index = email.IndexOf('@');
Console.WriteLine($"Index of @ : {index}");


   string username = email.Substring(0, index);
Console.WriteLine($"username : {username}");





Console.Read();
        


