// Вид 1. - не принимает никаких аргументов и ничего не возвращают.

// void Method1()
// {
//     Console.WriteLine("Автор...");
// }
// Method1();


// Вид 2. - принимает какие-то аргументы, но ничего не возвращают.

// void Method2 (string msg, count)
// {
// Console.WriteLine(msg);
// }
// Method2("Текст сообщения");

// void Method21 (string msg, int count)
// {
//     int i = 0;
//     while (i < count)
//     {
//         Console.WriteLine(msg);
//         i++;       
//     }
// }
// Method21(msg: "Текст", count: 4);

// Вид 3. - может что-то возвращать, но не принимает никаких аргументов.

// int Method3()
// {
//     return DateTime.Now.Year;
// }

// int year = Method3();
// Console.WriteLine(year);

// Вид 4. - что-то принимает (аргументы, данные). И что-то возвращает для дальнейшей работы.

// string Method4 (int count, string text)
// {
//     int i = 0;
//     string result = String.Empty;

//     while (i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }
// string res = Method4 (12, "OJ");
// Console.WriteLine(res);

// Вид 4.1. Тоже самое через цикл FOR.

// string Method4(int count, string text)
// {

//     string result = String.Empty;

//     for (int i = 0; i < count; i++)
//     {
//         result = result + text;
//     }
//     return result;
// }
// string res = Method4(12, "OJ");
// Console.WriteLine(res);

// 5. Цикл в Цикле.

// for (int i = 2; i <= 10; i++)
// {
//     for (int j = 2; j <= 10;j++)
//     {
//         Console.WriteLine($"{i} * {j} = {i*j}");
//     }
//     Console.WriteLine();
// }

// 6. Работа с текстом.
// В тексте нужно все пробелы заменить черточками,
// Маленькие буквы "к" замениить большими буквами "К",
// а маленькие "с" большими "С".

// string text = "Н.Зеландия запустила космическую политику страны, "
//             + "обозначив растущие геополитические риски, связанные с космосом, "
//             + "и необходимостью работать с партнерами-единомышленниками "
//             + "для защиты национальной безопасности страны.";

// string Replace(string text, char oldValue, char newValue)
// {
//     string result = String.Empty;
//     int lenght = text.Length;
//     for (int i = 0; i < lenght; i++)
//     {
//         if (text[i] == oldValue) result = result + $"{newValue}";
//         else result = result + $"{text[i]}";
//     }
//     return result;
// }
// string newText = Replace(text,' ', '|');
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(newText,'с', 'С');
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(newText, 'к','К');
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(newText, 'р', 'R');
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(newText, 'и', 'i');
// Console.WriteLine(newText);

// 7. Работа с циклом в цикле.

int[] arr = { 1, 5, 6, 1, 8, 7, 3, 7, 2 };

void PringArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }


}

PringArray(arr);
SelectionSort(arr);

PringArray(arr);