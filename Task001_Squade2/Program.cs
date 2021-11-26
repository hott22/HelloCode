// По двум заданным числам проверять является ли первое квадратом второго

Console.WriteLine("Введите первое число: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int B = Convert.ToInt32(Console.ReadLine());
if (Math.Sqrt(A) == B)
{
    Console.WriteLine("Является");
}
else 
{
    Console.WriteLine("Не является");
}
