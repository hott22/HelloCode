// Показать вторую цифру трёхзначного числа
Console.WriteLine("Введи трехзначное число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
if (num1 > 999 | num1 < 100)
{
    Console.WriteLine("Не трехзначное");
}
else
{
    int num2 = num1 % 100;
    int num3 = num2 % 10;
    int num4 = (num2 - num3) / 10;
    Console.Write("Вторая цифра: ");
    Console.WriteLine(num4);
}
