﻿// Выяснить кратно ли число 7
Console.WriteLine("Введи число: ");
double num = Convert.ToDouble(Console.ReadLine());
if (num % 7 == 0)
{
    if (num % 23 == 0)
    {
        Console.WriteLine("Кратно");
    }
    else
    {
        Console.WriteLine("Не кратно");
    }
}
else
{
    Console.WriteLine("Не кратно");
}
