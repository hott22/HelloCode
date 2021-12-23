// Написать программу преобразования десятичного числа в двоичное


string Decimal(int number)
{
    string result = string.Empty;
    int remainder = 0;

    while (number > 0)
    {
        remainder = number % 2;
        number = number / 2;
        result = remainder.ToString() + result;

    }
    
    return result;
}

Console.Write("Введи число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{number} - {Decimal(number)}");