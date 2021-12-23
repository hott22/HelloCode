// Написать программу замену элементов массива на противоположные
// Массив задается случайными числами от -10 до 10

Console.Write("Введи число элементов в массиве: ");
int A = Convert.ToInt32(Console.ReadLine());
int[] array = new int[A];
int length = array.Length;
for (int i = 0; i < length; i++)
{
    array[i] = new Random().Next(-10, 10);
    Console.WriteLine(array[i]);
}

int result = 0;
for (int i = 0; i < length; i++)
{
    result = array[i] * -1;
    Console.Write($"{result} ");
}

