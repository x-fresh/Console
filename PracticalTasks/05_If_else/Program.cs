Console.Write("Введите имя");
string username = Console.ReadLine();

if(username.ToLower() == "томат")
{
    Console.WriteLine("Знаю его, он чертополох ");
}
else
{
    Console.Write("Привет, програмист ");
    Console.WriteLine(username);
}