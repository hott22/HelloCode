// Дано число обозначающее день недели. Выяснить является номер дня недели выходным
Console.Write("Введи номер дня: ");
int day = Convert.ToInt32(Console.ReadLine());
if (day > 0 && day < 6) Console.WriteLine("Не является выходным");
if (day >= 6 && day <= 7) Console.WriteLine("Является выходным");
if (day > 7) Console.WriteLine("Не существует дня недели");