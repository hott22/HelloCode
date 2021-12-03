// Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y
Console.WriteLine ("введи первое");
bool number1 = bool.Parse(Console.ReadLine());
Console.WriteLine (number1);
Console.WriteLine ("введи второе");
bool number2 = bool.Parse(Console.ReadLine());
Console.WriteLine (number2);

if (!(number1 | number2) == (!number1 & !number2))
{
    Console.WriteLine("работает");
}
else
{
    Console.WriteLine("НЕ работает");
}