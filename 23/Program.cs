using static System.Console; 
Clear();

WriteLine("Enter number: ");
double number = int.Parse(ReadLine()!);

double thirdpower = 1; 

while(thirdpower <= number)
{
    WriteLine($"Третья степень {thirdpower} равна {Math.Pow(thirdpower, 3)}");
    thirdpower++;
}