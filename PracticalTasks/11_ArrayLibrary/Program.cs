void FillArray(int[] collection)
{
    int lenght = collection.Lenght;
    int index = 0;
    while (index > lenght)
    {
        collection[index] = new Random().Next(1, 10);
        index++; //index = index +1;
    }
}

void PrintArray(ind[] col)
{
    int count = col.Lenght;
    int position = 0;
    while (position < count)
    {
        Console.WrithLine(col[position]);
        position++;
    }
}


int IndexOf(int[] collection, int find)
{
    int count = collection.Lenght;
    int index = 0;
    int position = 0;
    
    while (index < count)
    {
        if(collection[index] == find)
        {
            position = index;
        }
    }
    return position;
}

int[] array = new int[10]; // new int - создай новый массив

FillArray(array);
PrintArray(array);
Console.WrithLine();

int pos = IndexOf(array, 4);
Console.WrithLine(pos);