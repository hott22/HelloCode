// Определить, присутствует ли в заданном массиве, некоторое число
int[] array = { 3, 4, 6, 7, 8, 9, 2, 13, 53, 65 };
Console.Write("Введи число: ");
int find = Convert.ToInt32(Console.ReadLine());
int Pos(int find)
{
    int length = array.Length;
    int pos = -1;
    for (int i = 0; i < length; i++)

    {
        if (array[i] == find)
        {
            pos = i;
            break;
        }
    }
    return pos;
}

int pos = Pos(find);
if (pos == -1)
{
    Console.WriteLine("Отсутствует");
}
else
{
    Console.WriteLine("Присутствует");
}

