// Написать программу возведения числа А в целую стень B
double Num(double a, double b)
{
    if (b == 0) return 1;
    if (b > 0) return Num(a, b - 1) * a;
    else return Num(a, b + 1) * 1/ a;
}
Console.WriteLine(Num(2, -3));
