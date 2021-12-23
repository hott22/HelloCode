// Показать числа Фибоначчи
Console.Write("Введи число: ");
int number = Convert.ToInt32(Console.ReadLine());
double Fibonacci(int n)
{
    if(n == 1 || n == 2) return 1;
    else return Fibonacci(n-1) + Fibonacci(n-2);
}

for (int i = 1; i <= number; i++)
{
    Console.WriteLine($"f({i}) = {Fibonacci(i)}");
}


Fibonacci (number);