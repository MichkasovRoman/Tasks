// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Clear();
Console.Write("Введите число a = ");
int number = int.Parse(Console.ReadLine()!);

int n = 2;

Console.Write($"Четные числа до {number}: ");
while (n <= number)
{
    Console.Write($"{n} ");
    n = n + 2;
}
