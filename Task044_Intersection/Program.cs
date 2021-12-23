// Найти точку пересечения двух прямых заданных уравнением 
// y = k1 * x + b1, y = k2 * x + b2, 
// b1 k1 и b2 и k2 заданы

Console.Write("Введи B1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введи B2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введи K1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введи K2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
if (k1 == k2)
{
    Console.Write("Прямые параллельные");
}
else
{
    double x = (b1 - b2) / (k2 - k1);
    double y = k1 * x + b1;
    Console.Write($"Точка пересечения: X: {x}, Y: {y}");
}


