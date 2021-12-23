// Определить количество цифр в числе
Console.WriteLine("Введи число: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 0;
if (number == 0)
{
     Console.Write("Количество цифр: 1");
}
else
{
    while (number != 0)
    {
    number = number / 10;
    count++;
    }
    Console.Write("Количество цифр: ");
    Console.WriteLine(count);
}
