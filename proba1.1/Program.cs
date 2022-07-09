// задача 2: напишите программу которая на вход принимает 2 числа и выдает какое большее а какое меньшее.
// *решение для целых, не одинаковых чисел которые пользователь задает изначально.
int x = 7;
int y = 7;
if(x>y)
{
    Console.Write("Большее число: ");
    Console.WriteLine(x);
    Console.Write("Меньшее число: ");
    Console.WriteLine(y);
}
else
{
    Console.Write("Большее число: ");
    Console.WriteLine(y);
    Console.Write("Меньшее число: ");
    Console.WriteLine(x);
}
 