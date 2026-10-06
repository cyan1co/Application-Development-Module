byte a = 200;
short b = 10000;
int c = 1000000000;
long d = 100000000000;
float e = 3.24f;
double f = 4.56;
decimal g = 1.789m;
char h = 'h';
bool i = true;

Console.WriteLine($" a = {a} is " + a.GetType().Name);
Console.WriteLine($" b = {b} is " + b.GetType().Name);
Console.WriteLine($" c = {c} is " + c.GetType().Name);
Console.WriteLine($" d = {d} is " + d.GetType().Name);
Console.WriteLine($" e = {e} is " + e.GetType().Name);
Console.WriteLine($" f = {f} is " + f.GetType().Name);
Console.WriteLine($" g = {g} is " + g.GetType().Name);
Console.WriteLine($" h = {h} is " + h.GetType().Name);
Console.WriteLine($" i = {i} is " + i.GetType().Name);
Console.WriteLine($" i = {i} is " + i.GetType().Name);

int num = 42;
String text = num.ToString();
Console.WriteLine($"Integer to String is {text}");

String tpi = "3.14";
double dpi = double.Parse(tpi);
Console.WriteLine($"String to double is {dpi}");