﻿Console.WriteLine("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "masha")
{
    Console.WriteLine("Ура, это же Masha");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}
