Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "маша")
{
    Console.WriteLine("Два рубля и наша");
}
else 
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}