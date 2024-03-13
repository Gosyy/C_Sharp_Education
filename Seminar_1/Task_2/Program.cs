// На входе принимается число N и выводятся числа от -N до N
// в формате 2 => -2, -1, 0, 1, 2 

System.Console.Write("Введите N: ");
int n = Convert.ToInt32(Console.ReadLine());

System.Console.Write($"{n} => ");

// --------------------- Реализация циклом while ---------------------
// int i = n * (-1);

// while (i <= n)
// {
//     Console.Write($"{i}, ");
//     i++;
// }

// --------------------- Реализация циклом for ---------------------
for (int i = -n; i <= n; i++)
{
    System.Console.Write($"{i}, ");
}