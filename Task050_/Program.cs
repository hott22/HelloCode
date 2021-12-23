// В двумерном массиве n×k заменить четные элементы на противоположные
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
    for (int i = 0; i < matr.GetLength(0); i++)
    {
    
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (matr[i,j] % 2 == 0) matr[i,j] = matr[i,j] * -1;
            
        }
        
    }

}

Console.Write("Введи количество строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи количество столбцов: ");
int k = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[n, k];


FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
Console.WriteLine();
ReplacementArray(matrix);
PrintArray(matrix);

