Console.Write("Введите имя пользователя ");
string username = Console.ReadLine();

if(username.ToLower() == "юрий")
{
    Console.WriteLine("Ура!!! Юрец пришел!!");
}
else 
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}
