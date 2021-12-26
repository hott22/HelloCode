// Написать программу, которая обменивает элементы первой строки и последней строки
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


int m = 5;
int n = 5;

int[,] matrix = new int[m, n];

FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
int [] qwe = new int[m];
//int sum =0;
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
       qwe[0] = matrix[i,j];
       
    }
        Console.Write(qwe[0]);
        Console.WriteLine();
        
        
}

