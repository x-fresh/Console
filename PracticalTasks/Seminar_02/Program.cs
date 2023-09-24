//Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число 
//

void CheckMultiplicity (int num1, int num2)
{
    if (num1 % num2 == 0)
    {
        System.Console.WriteLine($"{num1}, {num2}, -> кратно");
    }
    else
    {
        System.Console.WriteLine($"{num1}, {num2}, -> не кратно, остаток {num1 % num2}");
    }
}

System.Console.Write("Imput first num: ");
int n1 = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Imput second num: ");
int n2 = Convert.ToInt32(Console.ReadLine());

CheckMultiplicity(n1, n2);