// Написать программу вычисления функции Аккермана

double Akk (double m, double n)
{
    if (m == 0) return (n + 1);
    if ((m > 0) && (n == 0)) return Akk(m - 1, 1);
    if ((m > 0) && (n > 0)) return Akk(m - 1, Akk(m, n - 1));
    return 0;
}
Console.WriteLine (Akk(1,1));