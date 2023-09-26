// Напишите программу, которая по заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (х и у).

void FindCoordinates(int quarted)
{
    if(quarted <= 4 && quarted >= 1)
    {
    if(quarted == 1)
    {
        System.Console.WriteLine("x+ y+");
    }
    if(quarted == 2)
    {
        System.Console.WriteLine("x- y+");
    }
    if(quarted == 3)
    {
        System.Console.WriteLine("x- y-");
    }
    if(quarted == 4)
    {
        System.Console.WriteLine("x+ y-");
    }
   }
    else
    {
      System.Console.WriteLine("invalid input  ");  
    }
}
System.Console.Write("Input quarter num: ");
int num = Convert.ToInt32(Console.ReadLine());

FindCoordinates(num);