// Выяснить являются ли три числа сторонами треугольника
Console.Write("Введи A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи B: ");
int B = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи C: ");
int C = Convert.ToInt32(Console.ReadLine());
if (A < B + C && B < C + A && C < A + B)
{
    Console.Write("Является");
}
else
{
    Console.Write("НЕявляется");
}