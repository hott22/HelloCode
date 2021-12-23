// Показать двумерный массив размером m×n заполненный вещественными числами
void PrintArray(double[,] matr)
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

void FillArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = Math.Round(new Random().Next(1, 10) + new Random().NextDouble(), 2);
        }
    }
}

Console.Write("Введи количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] matrix = new double[m, n];

FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
