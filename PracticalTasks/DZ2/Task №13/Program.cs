// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей 
// цифры нет.
Console.Write("Введите N: ");
int anyNum = Convert.ToInt32(Console.ReadLine());
string anyNumText = Convert.ToString(anyNum);
if (anyNumText.Length > 2)
{
  Console.WriteLine("третья цифра -> " + anyNumText[2]);
}
else {
  Console.WriteLine("Введите 3х значное число ");
}
