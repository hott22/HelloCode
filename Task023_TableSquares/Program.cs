// Показать таблицу квадратов чисел от 1 до N
Console.Write("Введи N: ");
int N = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= N; i++)
{
    Console.WriteLine($"{i} ^ {2} = {Math.Pow(i, 2)}");
}
