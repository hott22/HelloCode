// Даны два числа. Показать большее и меньшее число
Console.Write("Введите первое число: ");
double numA = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите второе число: ");
double numB = Convert.ToDouble(Console.ReadLine());

if(numA < numB)
{
    Console.Write("Минимальное число: ");
    Console.WriteLine(numA);
    Console.Write("Максимальное число: ");
    Console.WriteLine(numB);
}
else
{
    Console.Write("Минимальное число: ");
    Console.WriteLine(numB);
    Console.Write("Максимальное число: ");
    Console.WriteLine(numA);
}
