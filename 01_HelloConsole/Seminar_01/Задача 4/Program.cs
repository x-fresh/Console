﻿// Задача 4. Напишите программу, которая принимает на вход трехзначное число и на выходе показывает **последнюю** цифру этого числа.

System.Console.Write("imput N: ");
int num = Convert.ToInt32(Console.ReadLine());

if(num>=100 && num<=999 )
{
    System.Console.WriteLine($"last digit of {num} - > {num%10}");
}