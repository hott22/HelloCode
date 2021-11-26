// Кратно ли число заданному? если нет, вывести остаток.

Console.WriteLine("Введи число: ");
double num1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Кратно чему: ");
double num2 = Convert.ToDouble(Console.ReadLine());
if (num1 % num2 == 0)
{
    Console.WriteLine("Кратно");
}
else
{
    double num3 = num1 % num2;
    Console.Write("Не кратно, остаток: ");
    Console.WriteLine(num3);
}
