// Показать натуральные числа от N до 1, N задано
void Sequence(int n)
{
        Console.WriteLine($"{n}");
        if (n != 1)     
        {
            Sequence(n - 1) ;
        }
        
}
Sequence(4);




