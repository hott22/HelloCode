// Удалить вторую цифру трёхзначного числа
Console.WriteLine("Введи трехзначное число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
if (num1 > 999 | num1 < 100)
{
    Console.WriteLine("Не трехзначное");
}
else
{
    
    int num3 = num1 % 10;
    int num4 = num1 / 100;
    int num5 = num4*10 + num3;
    Console.Write("Без второй цифры: ");
    Console.WriteLine(num5);
}

