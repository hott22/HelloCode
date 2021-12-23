// Задать массив, заполнить случайными положительными трёхзначными числами. 
//Показать количество нечетных\четных чисел
int[] array = new int[10];
int length = array.Length;
for (int i = 0; i < length; i++)
{
    array[i] = new Random().Next(100, 1000);
    Console.Write($"{array[i]} ");
}
int even = 0;
int noteven = 0;
for (int i = 0; i < length; i++)
{
    if (array[i] % 2 == 1)
    {
        noteven = noteven + 1;
    }
    else
    {
        even = even + 1;
    }
}
Console.WriteLine("");
Console.Write("Количество НЕчетных чисел: ");
Console.WriteLine(noteven);
Console.Write("Количество четных чисел: ");
Console.WriteLine(even);