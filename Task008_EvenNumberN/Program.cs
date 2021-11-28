// Показать четные числа от 1 до N
Console.WriteLine("Введи N");
int N = Convert.ToInt32(Console.ReadLine());
int count = 0;
while (count < N + 1)
{
    Console.WriteLine(count);
    count = count + 2;
}
