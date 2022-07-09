// задача 2: напишите программу которая на вход принимает 2 числа и выдает какое большее а какое меньшее.
// *решение для целых чисел.
int num1;
Console.Write("Введите число1: "); 
num1 = Convert.ToInt32 (Console.ReadLine());
int num2;
Console.Write("Введите число2: ");
num2 = Convert.ToInt32 (Console.ReadLine());

if(num1>num2)
{
    Console.Write("Большее число: ");
    Console.WriteLine(num1);
    Console.Write("Меньшее число: ");
    Console.WriteLine(num2);
}
else
{
    Console.Write("Большее число: ");
    Console.WriteLine(num2);
    Console.Write("Меньшее число: ");
    Console.WriteLine(num1);
}
 