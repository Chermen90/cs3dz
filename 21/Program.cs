using static System.Console; 
//Clear();

WriteLine("Enter xa: ");
double xa = int.Parse(ReadLine()!);

WriteLine("Enter ya: ");
double ya = int.Parse(ReadLine()!);

WriteLine("Enter za: ");
double za = int.Parse(ReadLine()!);

WriteLine("Enter xb: ");
double xb = int.Parse(ReadLine()!);

WriteLine("Enter yb: ");
double yb = int.Parse(ReadLine()!);

WriteLine("Enter zb: ");
double zb = int.Parse(ReadLine()!);



double result = Math.Sqrt(Math.Pow((xb - xa), 2) + Math.Pow((yb - ya), 2) + Math.Pow((zb - za), 2));
WriteLine($"{result:f2}");