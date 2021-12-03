// Задать номер четверти, показать диапазоны для возможных координат
Console.WriteLine("Введи номер четверти:");
int number_quarter = Convert.ToInt32(Console.ReadLine());
if (number_quarter == 1) Console.WriteLine("Диапазоны: x > 0 и y > 0");
if (number_quarter == 2) Console.WriteLine("Диапазоны: x < 0 и y > 0");
if (number_quarter == 3) Console.WriteLine("Диапазоны: x < 0 и y < 0");
if (number_quarter == 4) Console.WriteLine("Диапазоны: x > 0 и y < 0");
