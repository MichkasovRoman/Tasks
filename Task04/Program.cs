// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Clear();
Console.Write("Введите первое число a = ");
int number1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число b = ");
int number2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите третье число с = ");
int number3 = int.Parse(Console.ReadLine()!);

int max = number1;

if (number2 > number1)
{
    