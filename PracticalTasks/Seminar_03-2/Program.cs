//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
//5 -> 1, 4, 9, 16, 25.
//2 -> 1,4

void Kvadrats(int N)
{
    int index = 1;
    while(index <= N)
    {
       System.Console.Write($"{index * index}, "); 
       index++;     
    }
}

int Vvod(string message)
{
    System.Console.Write(message);
    int number = Convert.ToInt32(System.Console.ReadLine());
    return number;
}
Kvadrats(Vvod("Введите чило: "));