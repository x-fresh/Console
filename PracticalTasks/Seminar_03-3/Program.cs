// Напишите программу, которая принимает на вход координаты точек
// (Х и У), причем Х = 0, У = 0 и выдает номер четверти плоскости,
// в которой находится эта точка.


int Vvod(string message)
{
    System.Console.Write(message);
    int number = Convert.ToInt32(System.Console.ReadLine());
    return number;
}
int x = Vvod("Введите чило координату X: ");
int y = Vvod("Введите чило координату Y: ");
int Quarter(int A, int B)
{
   if(A > 0 && B > 0) return 1;
   if(A < 0 && B > 0) return 2;
   if(A < 0 && B < 0) return 3;
   if(A > 0 && B < 0) return 4;
   else return 0;
}
System.Console.WriteLine(Quarter(x, y));
