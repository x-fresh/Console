    // Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на 
    // выходе показывает вторую цифру этого числа.

System.Console.Write("Введите N: ");


int SecondDigit = Convert.ToInt32(Console.ReadLine());
string Number = Convert.ToString(SecondDigit);
Console.WriteLine("Вторая цифра этого числа -> "+Number[1]);