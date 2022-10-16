// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Clear();
Console.Write("Введите первое число a = ");
int number1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число b = ");
int number2 = int.Parse(Console.ReadLine()!);
if (number1 < number2)
{
    Console.WriteLine($"Наибольшим числом является {number2}.");
    Console.Write($"Наименьшим числом является {number1}.");
}
else
{
   Console.WriteLine($"Наибольшим числом является {number1}.");
   Console.Write($"Наименьшим числом является {number2}."); 
}