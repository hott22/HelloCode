// Показать вторую цифру трёхзначного числа
Console.WriteLine("Введи трехзначное число: ");
double num1 = Convert.ToDouble(Console.ReadLine());
if (num1 > 999 | num1 < 100)
{
    Console.WriteLine("Не трехзначное");
}
else
{
    double num2 = num1 % 100;
    double num3 = num2 % 10;
    double num4 = (num2 - num3) / 10;
    Console.Write("Вторая ицфра: ");
    Console.WriteLine(num4);
}
