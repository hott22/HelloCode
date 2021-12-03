// Задать массив из 8 элементов и вывести их на экран
void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 20);
        //index = index + 1;
        index++;
    }
}

void PrintArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        Console.WriteLine(collection[index]);
        index++;
    }
}
int[] array = new int[8];
FillArray(array);
PrintArray(array);