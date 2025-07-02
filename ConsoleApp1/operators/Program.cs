using System.Net.Mail;

int a = 10;
Console.WriteLine($"{a}");

int b = 2;

int add = a + b;
Console.WriteLine($"Addiation : {add} ");

int sub = a - b;
Console.WriteLine($"Substration : {sub} ");

int mul = a * b;
Console.WriteLine($"Multiplication : {mul} ");

int div = a / b;
Console.WriteLine($"division : {div} ");

int mod = a % b;
Console.WriteLine($"Remainder : {mod}");

b = 3;
mod = a % b;
Console.WriteLine($"Reminder : {mod}");

Console.WriteLine($"a : {a} ");
a++; // a = a + 1;
Console.WriteLine($"a++ : {a} ");

// Console.WriteLine($"a : {a++}"); // a++ // post increment // 11

Console.WriteLine($"a : {++a}"); // ++a // pre increment // 12
Console.WriteLine($"a : {a}"); // 12

a--; // a = a - 1;
Console.WriteLine($"a : {a}");


// Console.WriteLine($"a : {--a}"); // pre decrement  // 10
Console.WriteLine($"a : {a--}"); // post decrement  // 11
Console.WriteLine($"a : {a}"); // 10

// a = 10
//15

a -= 10;
Console.WriteLine($"a : {a}");

a *= 3;
Console.WriteLine($"a : {a}"); // 15

a = a / 3;

a = 10;

bool b1 = a == 10;
Console.WriteLine($"a == 10 : {b1}");

b1 = a != 10;
Console.WriteLine($"a != 10 : {b1}");

// and operator &&

b1 = (a == 10) && (b == 10);
Console.WriteLine($"({a} == 10) && ({b} == 10) : {b1}"); 


b1 = (a == 10) && (b != 10);
Console.WriteLine($"({a} == 10) && ({b} != 10) : {b1}");

// or operator ||
b1 = (a == 10) || (b == 10);
Console.WriteLine($"({a} == 10) || ({b} == 10) : {b1}"); 

b1 = (b == 10) & (a == 10);
Console.WriteLine($"({b} == 10) & ({a} == 10) : {b1}"); 

b1 = (a == 10) | (b == 10);
Console.WriteLine($"({a} == 10) | ({b} == 10) : {b1}");


// verbatim literal = removes meaning of back slashes
// generally we use with file folder path

short v1 = 10;
Console.WriteLine($"short v1 : {v1}");


int v2 = v1; // short => int 
Console.WriteLine($"int v2 : {v2}");

float v3 = v2; // int => float
Console.WriteLine($"float v3 : {v3}");

// using type cast operator
v3 = 10.5f;
int v4 = (int)v3; // float => int
Console.WriteLine($"int v4 : {v4}");

string v5 = "1000";
// int v6 = v5; // string => int
int v6 = Convert.ToInt32(v5); // converting string to int

Console.WriteLine($"int v6 : {v6}");

v5 = "true";
bool v7 = Convert.ToBoolean(v5); // string => bool
Console.WriteLine($"bool v7 : {v7}");

// using Parse(), TryParse() methods
v5 = "120";

int v8 = int.Parse(v5); // string => int
Console.WriteLine($"int v8 : {v8}");

// need of TypeParse() method

string s = "fdasfdsf";

// int i = Convert.ToInt32(s);
// int i = int.Parse(s);

int i; 
bool b = int.TryParse(s, out i);

Console.WriteLine($"Is conversion success : {b} int i : {i}");

s = "500";
b = int.TryParse(s, out i);
Console.WriteLine($"Is conversion success : {b} int i : {i}");





Console.Read();

