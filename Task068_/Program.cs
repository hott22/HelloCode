// Показать натуральные числа от M до N, N и M заданы
string NumberRec(int m,int n)
{
    if(m<=n) return NumberRec(m,n-1) + $"{n} ";
    //if(m<=n) return NumberRec(m+1,n) + $"{m} "; обратный отсчет!
    else return string.Empty;
}
Console.WriteLine(NumberRec(3,5));

// void Number(int m,int n)
// {
   
//     if (m<n)
//     { 
//         Number(m,n - 1);
//     }
//      Console.Write($"{n} ");   
// }

// Number(3,10);

