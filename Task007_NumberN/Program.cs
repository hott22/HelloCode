// Показать числа от -N до N
Console.WriteLine("Введи N");
int N = Convert.ToInt32(Console.ReadLine());
int count = -N;
while (count < N + 1)
{

    Console.WriteLine(count);
    count = count + 1;


}

