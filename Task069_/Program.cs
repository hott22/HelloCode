// Найти сумму элементов от M до N, N и M заданы

int Sum(int m, int n)
{

    if (m < n) return n + Sum(m, n-1);
    if (n < m) return m + Sum(m-1, n);
    else return n;
}
Console.WriteLine(Sum(5, 2));


