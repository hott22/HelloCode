// Показать последнюю цифру трёхзначного числа
Console.WriteLine("Введи трехзначное число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
if (num1 > 999 | num1 < 100)
{
    Console.WriteLine("Не трехзначное");
}
else
{
    
    int num2 = num1 % 10;
    Console.Write("Последняя цифра: ");
    Console.WriteLine(num2);
}

