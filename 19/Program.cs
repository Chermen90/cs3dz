using static System.Console; 
//Clear();

WriteLine("Введите число: ");
int number = int.Parse(ReadLine()!);

//прописываю условие на случай, если введено не 5значное число
if(number < 10000 || number > 99999) 
{
   WriteLine("Вы ввели не 5значное число. Попробуйте ещё раз. "); 
    return;
} 

//нахожу значение каждой цифры числа
int first = number / 10000;
WriteLine($"FIRST {first}");

int secfirst = (number / 1000) % 10;
WriteLine($"SECFIRST {secfirst}");


int seclast = (number / 10) % 10;
WriteLine($"SECLAST {seclast}");

int last = number % 10;
WriteLine($"LAST {last}");


//прописываю условие-проверку 
if(first == last && secfirst == seclast)
{
    WriteLine($"Число {number} это палиндром");
}
else
{
    WriteLine($"Чмсло {number} это не палиндром");
}