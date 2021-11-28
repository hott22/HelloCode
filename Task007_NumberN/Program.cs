// Показать числа от -N до N
Console.WriteLine("Введи N");
int N = Convert.ToInt32(Console.ReadLine());
int count = -N;
while (count < N + 1)
{
    Console.Write(count);
    count = count + 1;
}

