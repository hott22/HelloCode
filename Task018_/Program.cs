// Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Yи

bool A = !(X || Y) == !X && !Y

if (X = true && Y = true)
{
    Console.WriteLine("Истинно");
}
else
{
    Console.WriteLine("Ложно");
}
