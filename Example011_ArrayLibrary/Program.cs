// FillArray метод заполнения массива рандомными числами
// PrintArray метод печати массива
// Длина массива 15
// IndexOf метод ищет номер элемента массива равный 10, если такого элемента нет присваивает -1
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

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}
int[] array = new int[15];
FillArray(array);

PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 10);
Console.WriteLine(pos);