// Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0
Console.WriteLine("Введи координату X: ");
int X = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введи координату Y: ");
int Y = Convert.ToInt32(Console.ReadLine());
if (X > 0 && Y > 0) Console.WriteLine("Номер плоскости: 1");
if (X < 0 && Y > 0) Console.WriteLine("Номер плоскости: 2");
if (X < 0 && Y < 0) Console.WriteLine("Номер плоскости: 3");
if (X > 0 && Y < 0) Console.WriteLine("Номер плоскости: 4");