//Составить частотный словарь элементов двумерного массива

int[] array = { 1, 2, 3, 2, 3, 3, 2, 2, 2, 1, 3, 3, 4, 1, 6, 6, 4, 6, 6 };
//int min = array.Min();
int max = array.Max();
//Console.WriteLine(max);
int[] arrayNew = new int[max + 1];
for (int i = 0; i < array.Length; i++)
{
    arrayNew[array[i]]++;

}
for (int i = 0; i < arrayNew.Length; i++)
{
    if (arrayNew[i] != 0)
    {
        Console.WriteLine($"{i}  {arrayNew[i]}");
    }
}


