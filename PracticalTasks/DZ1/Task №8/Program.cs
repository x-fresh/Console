// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Write("Введите N: ");
int n = Convert.ToInt32(Console.ReadLine());

int evenNumber = 2;
if (n > 1)
{
   while(evenNumber <= n)
   {
    Console.Write(evenNumber + " ");
    evenNumber = evenNumber + 2;
   }
}