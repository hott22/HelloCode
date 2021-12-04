// Написать программу замену элементов массива на противоположные
int[] array = new int[8] { 4, -6, 3, 7, -2, 8, 4, -7 };
int result = 0;
int count = array.Length;
for (int i = 0; i < count; i++)
{
     result = array[i] * -1;
     Console.Write($"{array[i]} ");
}
