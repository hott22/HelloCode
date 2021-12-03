// Найти расстояние между точками в пространстве 2D/3D
Console.WriteLine("Введи X для первой точки:");
double X1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введи Y для первой точки:");
double Y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введи Z для первой точки:");
double Z1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введи X для второй точки:");
double X2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введи Y для второй точки:");
double Y2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введи Z для второй точки:");
double Z2 = Convert.ToDouble(Console.ReadLine());
double S = Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2)+ Math.Pow(Z2 - Z1, 2));
Console.Write("Расстояние равно: ");
Console.WriteLine (S);
void Method1() 
{
    Console.WriteLine("Автор Айрат");
}
// Вызов
Method1();