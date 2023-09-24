// Задача 3: Напишите программу, которая на вход принимает одно чило (N), а на выходе показывает все целые числа в промежутке от -N до N

System.Console.Write("imput N: ");
int n = Convert.ToInt32(Console.ReadLine());

int count = -n;
while (count <= n)
{
    System.Console.WriteLine(count++ + " ");  
}