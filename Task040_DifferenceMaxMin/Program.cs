// В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом
Console.Write("Введи число элементов в массиве: ");
int A = Convert.ToInt32(Console.ReadLine());
double[] array = new double[A];
for (int i = 0; i < A; i++)
{
    array[i] = Math.Round(Convert.ToDouble(new Random().Next(1, 100)) + new Random().NextDouble(),3);
    Console.Write($"{array[i]} ");
}

 double[] SelectionSort(double[] array)
{
    for (int i = 0; i < array.Length - 1 ; i++)
    {
        int minPosition = i;
        
        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }
        double temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
    return array;
}

array = SelectionSort (array);
Console.WriteLine("");
Console.WriteLine($"Разница между мин и макс: {Math.Round((array[^1] - array[0]), 3)}");


