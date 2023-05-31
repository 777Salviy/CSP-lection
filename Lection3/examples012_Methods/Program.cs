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

string Method4(int count, string text)
{

    string result = String.Empty;

    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}
string res = Method4(12, "OJ");
Console.WriteLine(res);