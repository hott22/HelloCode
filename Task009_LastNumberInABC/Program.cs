// Показать последнюю цифру трёхзначного числа
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
    Console.Write("Последняя цифра: ");
    Console.WriteLine(num3);
}

