// Найти кубы чисел от 1 до N
Console.Write("Введи N: ");
int N = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= N; i++)
{
    // double S = Math.Pow(i, 3);
    //Console.WriteLine(S);
    Console.WriteLine($"{Math.Pow(i, 3)}");
}
