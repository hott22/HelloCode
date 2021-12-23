// Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y
string Method(bool X, bool Y)
{
    string result = String.Empty;
    Console.Write($"значение X: {X}\n");
    Console.Write("значение Y: {0}\n", Y);
    if(!(X || Y) == (!X && !Y)) result = "Истина";
    else result = "Ложь";
    return result;
}

string res = Method(true, true);
Console.WriteLine($"Ответ истинность утверждения не(X или Y) = не X и не Y:   {res}");
res = Method(true, false);
Console.WriteLine($"Ответ истинность утверждения не(X или Y) = не X и не Y:   {res}");
res = Method(false, true);
Console.WriteLine($"Ответ истинность утверждения не(X или Y) = не X и не Y:   {res}");
res = Method(false, false);
Console.WriteLine($"Ответ истинность утверждения не(X или Y) = не X и не Y:   {res}");
