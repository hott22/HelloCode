// Программа проверяет пятизначное число на палиндромом.
Console.WriteLine("Введи пятизначное число: ");
int digital = Convert.ToInt32 (Console.ReadLine());
int digital5 = digital / 10000;
int digital1 = digital % 10;
int digital3 = (digital / 1000) % 10;
int digital2 = (digital % 100) / 10;
if (digital > 99999 | digital < 10000)
{
    Console.WriteLine("Не пятизначное число");
}
else 
{
    Console.WriteLine("Это число НЕпалиндром");
}
if (digital1 == digital5 && digital3 == digital2) Console.WriteLine("Это число Палиндром");
