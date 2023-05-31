// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите имя пользвователя");
string username = Console.ReadLine();

if(username.ToLower() == "маша")
{
    Console.WriteLine("Ура, это же Маша!");
}
    else
    {
        Console.Write("Hi, ");
        Console.WriteLine(username);
    }
