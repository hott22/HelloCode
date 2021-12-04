// Возведите число А в натуральную степень B используя цикл
Console.Write("Введи A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи B: ");
int B = Convert.ToInt32(Console.ReadLine());

int C = 1;
for (int i = 0; i < B; i++)
{
    C =  C * A;
}


Console.WriteLine(C);