int[] array = { 1, 11, 15, 22, 42, 4565, 11, 45, 55 };

int n = array.Length;
int find = 11;
 
int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break; //завершает работу алгоритма
    }
    //index = index + 1;
    index++;   
}