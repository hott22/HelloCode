// Найти максимальное из трех чисел
Console.Write("Введите первое число: ");
double numA = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите второе число: ");
double numB = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите третье число: ");
double numС = Convert.ToDouble(Console.ReadLine());

double max = numA;
if (numA > max) max = numA;
if (numB > max) max = numB;
if (numС > max) max = numС;

Console.Write("Максимально число ");
Console.WriteLine(max);