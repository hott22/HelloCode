// В матрице чисел найти сумму элементов главной диагонали
int[,] array = new int[,]
{
    {1, 5, 7, 2, 8, 10 },
    {12, 1, 3, 56, 12, 4 },
    {12, 54, 1, 76, 34, 5 },
    {65, 62, 82, 1, 22, 67 },
    {44, 33, 66, 22, 1, 88 },
    {27, 67, 89, 33, 23, 1 },
};

int sum = 0;
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (i == j) sum = sum + array[i,j];
    }
}
//Console.Write($"Сумма равна: {sum}" );
Console.Write(sum);