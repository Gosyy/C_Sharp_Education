// Задача 2: Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, 
// в которой находится эта точка.

System.Console.Write("Введите координату Х не равную нулю: ");
int x = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите координату Y не равную нулю: ");
int y = Convert.ToInt32(Console.ReadLine());

while (x == 0 || y == 0)
{
    if (x == 0)
    {
        System.Console.Write("Введено нулевое значение Х! Введите координату Х не равную нулю: ");
        x = Convert.ToInt32(Console.ReadLine());
    }
    
    if (y == 0)
    {
        System.Console.Write("Введено нулевое значение Y! Введите координату Y не равную нулю: ");
        y = Convert.ToInt32(Console.ReadLine());
    }
}

if (x > 0 && y > 0)
{
    System.Console.WriteLine($"Координаты ({x}, {y}) => четверть 1");
}

if (x < 0 && y > 0)
{
    System.Console.WriteLine($"Координаты ({x}, {y}) => четверть 2");
}

if (x < 0 && y < 0)
{
    System.Console.WriteLine($"Координаты ({x}, {y}) => четверть 3");
}

if (x > 0 && y < 0)
{
    System.Console.WriteLine($"Координаты ({x}, {y}) => четверть 4");
}
