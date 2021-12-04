// Задать массив из 12 элементов, заполненных числами из [0,9]. 
//Найти сумму положительных/отрицательных элементов массива
int[] array = new int[12];
int length = array.Length;
int sum = 0;
for (int i = 0; i < length; i++)
{
    array[i] = new Random().Next(0, 9);
    Console.WriteLine(array[i]);
    sum = sum + array[i];
}
Console.Write("Сумма элементов: ");
Console.WriteLine(sum);

