
int[] array = { 1, 12, 31, 4, 51, 16, 72, 18, 72 };

int n = array.Length;
int find = 72;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}

