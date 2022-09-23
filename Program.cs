/*
Напишите программу, которая принимает на вход трёхзначное
 число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/
// int columns = Math.Abs(int.Parse(Console.ReadLine() ?? string.Empty)); - алгоритм избавления от ошибки null
// int num = int.Parse(Console.ReadLine());

Console.Write("Введите трехзначное число ");
int num = Math.Abs(int.Parse(Console.ReadLine() ?? string.Empty)); // int columns = Math.Abs(int.Parse(Console.ReadLine() ?? string.Empty)); - алгоритм избавления от ошибки null
// int num = int.Parse(Console.ReadLine());

int digit_capacity = num.ToString().Length;

if (digit_capacity < 3 || digit_capacity > 3)
   {Console.WriteLine("Вы ввели не трехзначное число");}
else
    {int num1 = num/10;
     int num2 = num1 % 10;
        Console.Write($"{num2}");}
