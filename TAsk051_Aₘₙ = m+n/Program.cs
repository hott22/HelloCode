// Задать двумерный массив следующим правилом: Aₘₙ = m+n
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
            matr[i, j] = i + j;
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