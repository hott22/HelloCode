// Найти сумму цифр числа
int Sum(int num)
{
    if (num > 0) return num % 10 + Sum(num / 10);
    return 0;
}
Console.WriteLine(Sum(125));