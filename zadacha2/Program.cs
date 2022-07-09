// Задача 4. Напишите программу, которая на вход принимает 3 числа и выдает максимальной из этих чисел.
//* Решение для целых чисел.
int num1;
Console.Write("Введите число1: "); 
num1 = Convert.ToInt32 (Console.ReadLine());
int num2;
Console.Write("Введите число2: ");
num2 = Convert.ToInt32 (Console.ReadLine());
int num3;
Console.Write("Введите число3: ");
num3 = Convert.ToInt32 (Console.ReadLine());

if(num1!=num2 & num1!=num3 & num2!=num3)
{
    if(num1>num2)
    {
        if(num1>num3)
        {
            Console.Write("Максимальное число: ");
            Console.WriteLine(num1);
        }

        else
        {
        Console.Write("Максимальное число: ");
        Console.WriteLine(num3);
        }
    }
    else
    {
        if(num2>num3)
        {
            Console.Write("Максимальное число: ");
            Console.WriteLine(num2);
        }
        else
        {
            Console.Write("Максимальное число: ");
            Console.WriteLine(num3);
        }
    }
}
else
{
    Console.Write("Имеются одинаковые числа! Измените данные.");
}
