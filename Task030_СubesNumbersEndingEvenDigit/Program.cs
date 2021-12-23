// Показать кубы чисел, заканчивающихся на четную цифру от 1 до N
Console.Write("Введи N: ");
double N = Convert.ToDouble(Console.ReadLine());
for (int i = 2; i <= N; i+=2)
{
    Console.WriteLine($"{i}^{3} = {Math.Pow(i, 3)}");
}

