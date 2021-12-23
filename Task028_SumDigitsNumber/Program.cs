// Подсчитать сумму цифр в числе
Console.WriteLine("Введи число: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 0;
int sum = 0;
int number1 = 0;
while (number != 0)
{
    number1 = number % 10;
    number = number / 10;
    sum = number1 + sum;
    count++;
}

Console.Write("Сумму цифр в числе: ");
Console.WriteLine(sum);