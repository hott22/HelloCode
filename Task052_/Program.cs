// В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}

void ReplacementArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i+=2)
    {

        for (int j = 0; j < matr.GetLength(1); j+=2)
        {
            matr[i,j] = matr[i,j] * matr[i,j];

        }

    }

}



Console.Write("Введи количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[m, n];

FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
Console.WriteLine();
ReplacementArray(matrix);
PrintArray(matrix);
