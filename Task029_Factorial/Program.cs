// Написать программу вычисления произведения чисел от 1 до N
Console.Write("Введи N: ");
double N = Convert.ToDouble(Console.ReadLine());
double factorial = 1;   // значение факториала

for (double i = 2; i <= N; i++) // цикл начинаем с 2, т.к. нет смысла начинать с 1
{
     factorial = factorial * i;
}
Console.Write("Факториал = ");
Console.WriteLine(factorial);