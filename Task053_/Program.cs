// В двумерном массиве показать позиции числа, заданного пользователем 
// или указать, что такого элемента нет

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

int[,] matrix = new int[3, 4];

Console.Write("Введи число: ");
int find = Convert.ToInt32(Console.ReadLine());
int pos = -1;
int Pos(int[,] matr, int find)
{
    
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (matr[i,j] == find) 
            {
                int pos =  ;
                break;
            }

        }
    

    }
    return pos;
}

FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
Console.WriteLine();
Pos(matrix, find);
Console.WriteLine();


