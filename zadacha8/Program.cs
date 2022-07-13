//Напишите программу, которая на вход принимает число(N),
// а на выходе показывает все четные числа от 1 до N.
int N;
Console.Write("Введите число: ");
N = Convert.ToInt32(Console.ReadLine());
int[] arroy = new int[N];
int size = arroy.Length;
int count = 0;
int index = 0;
arroy[index] = 1;
while (count < size)
{
    double div = arroy[index] / 2;
    double mod = arroy[index] % 2;
    if (mod == 0)
    {
        Console.Write($"{arroy[index],3} ");
    }
    arroy[index]++;
    count++;
}
