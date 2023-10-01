
Console.WriteLine("Введите имя пользователя");
string username = Console.ReadLine();

if(username.ToLower() == "andrey")
{
    Console.WriteLine("Ура, это же Andrey!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}
