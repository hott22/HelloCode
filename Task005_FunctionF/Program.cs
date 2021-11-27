// Написать программу вычисления значения функции y = f(a)
Console.WriteLine("Введи a");
double a = Convert.ToDouble(Console.ReadLine());
double function(double a)
{
    double f = a * a + 23;
    return f;
}
Console.WriteLine(function(a));