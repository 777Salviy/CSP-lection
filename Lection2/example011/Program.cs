void FillArray(int[] collection)

{
    int lenth = collection.Length;
    int index = 0;
    while (index < lenth)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position += 1;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index += 1;
    }
    return position;
}

int[] array = new int[12];

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 9);
Console.WriteLine(pos);

