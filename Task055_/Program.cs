// Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.


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


int m = 3;
int n = 4;
//                    строк столб
int[,] matrix = new int[m, n];

FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
Console.WriteLine();

double[] summ = new double[n];
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        summ[i] += matrix[j, i];

    }
    Console.Write (summ[i] + " ");
}
Console.WriteLine();

 for (int i = 0; i < n; i++)
 {
     Console.Write(Math.Round(summ[i] / m , 2) +"  ");
 }

