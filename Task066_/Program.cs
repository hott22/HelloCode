// Показать натуральные числа от 1 до N, N задано

void Sequence(int n)
{

    if (n != 1)
    {
        Sequence(n - 1);
    }
    Console.WriteLine($"{n}");

}
Sequence(6);