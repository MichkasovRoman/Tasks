// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Clear();
Console.Write("Введите первое число a = ");
int number1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число b = ");
int number2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите третье число с = ");
int number3 = int.Parse(Console.ReadLine()!);

if ((number1 > number2) && (number1 > number3))
    Console.Write ($"Из введенных вами чисел наибольшим является число {number1}");
else if (number2 > number3)
    Console.Write ($"Из введенных вами чисел наибольшим является число {number2}");
else 
    Console.Write ($"Из введенных вами чисел наибольшим является число {number3}");
