// Найти сумму чисел одномерного массива стоящих на нечетной позиции
int[] array = new int[10];
int length = array.Length;
for (int i = 0; i < length; i++)
{
    array[i] = new Random().Next(0, 10);
    Console.Write($"{array[i]} ");
}
int sumnoteven = 0;
for (int i = 1; i < length; i+=2)
{
    sumnoteven = sumnoteven + array[i];
}
Console.WriteLine("");
Console.Write("Сумма чисел на нечетных позициях: ");
Console.WriteLine(sumnoteven);