// Напишите программу, которая принамает на вход координаты двух точек и находит расстояние между ними 2 2D пространстве.
// А (3,6); В (2,1) -> 5,09
// А (7,-5); В (1,-1) -> 7,21

double FindDistance(double xa, double ya, double xb, double yb)
{
    return Math.Round(Math.Sqrt(Math.Pow(xa - xb ,2) + Math.Pow(ya - yb ,2)), 2);
}

System.Console.Write("Input xA courd: ");
double xa = Convert.ToDoble(Console.ReadLine());
System.Console.Write("Input yA courd: ");
double ya = Convert.ToDoble(Console.ReadLine());
System.Console.Write("Input xB courd: ");
double xb = Convert.ToDoble(Console.ReadLine());
System.Console.Write("Input yB courd: ");
double yb = Convert.ToDoble(Console.ReadLine());

System.Console.WriteLine($"A({xa}, {ya}); B({xb}, {yb}) -> {FindDistance(xa, ya, xb, yb)}");