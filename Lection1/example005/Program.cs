Console.WriteLine("Введите имя пользователя: ");
string username = Console.ReadLine();

if (username.ToLower() == "алексей")
{
    Console.WriteLine("Здравствуй хозяин!");
}
else 
{
    Console.WriteLine("Привет, " + username);
}
