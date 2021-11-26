// Выяснить является ли число чётным
Console.WriteLine("Введи число: ");
double num = Convert.ToDouble(Console.ReadLine());
if (num % 2 == 1)
{
    Console.WriteLine("Нечетное");
}
else
{
    Console.WriteLine("Четное");
}