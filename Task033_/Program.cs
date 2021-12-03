// Задать массив из 12 элементов, заполненных числами из [0,9]. 
//Найти сумму положительных/отрицательных элементов массива
void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(0, 9);
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
int[] array = new int[12];


int sum = 0;
//int index = 0;
//int count = array.Length;



sum = array[0] + array[1]; 
    

FillArray(array);
PrintArray(array);
Console.Write("Сумма элементов: ");
Console.WriteLine(sum);