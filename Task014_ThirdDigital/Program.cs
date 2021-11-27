// Найти третью цифру числа или сообщить, что её нет
Console.WriteLine("Введи число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
if (num1 < 100)
{
    Console.WriteLine("Нет третьей цифры");
}
else
{
    int num2 = num1 / 100;
    int num3 = num2 % 10;
    Console.Write("Третья цифра: ");
    Console.WriteLine(num3);
}
