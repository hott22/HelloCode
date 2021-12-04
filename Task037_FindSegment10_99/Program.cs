// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
int[] array = new int[123];
int length = array.Length;
for (int i = 0; i < length; i++)
{
    array[i] = new Random().Next(0, 123);
    Console.Write($"{array[i]} ");
}
int count = 0;
int min = 10;
int max = 99;
for (int i = 0; i < length; i++)
{
    if (array[i] >= min && array[i] <= max )
    {
        count = count + 1;
    }
}
Console.WriteLine("");
Console.Write("Количество: ");
Console.WriteLine(count);