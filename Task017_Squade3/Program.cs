// По двум заданным числам проверять является ли одно квадратом другого
Console.WriteLine("Введите первое число: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int B = Convert.ToInt32(Console.ReadLine());
if (A == B * B || B == A * A)
{
    Console.WriteLine("Является");
}
else
{
    Console.WriteLine("Не является");
}