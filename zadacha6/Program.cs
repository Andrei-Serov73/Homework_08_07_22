// Напишите программу, которая на вход принимает число и выдает,
// является ли число четным (делится ли оно на 2 без остатка).
int num;
Console.Write("Введите число: ");
num = Convert.ToInt32(Console.ReadLine());

double div = num / 2;
double mod = num % 2;
if(num != 0)
{
    if(mod == 0)// или можно if(mod !=1 )
    {
    Console.Write(num);
    Console.WriteLine(" - число четное");
    }
    else
    {
    Console.Write(num);
    Console.WriteLine(" - нечетное число");
    }
}
else
{
    Console.Write("Измените параметры ввода!");
}