// Задача 1: Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.

class Program
{
    static void ShowNaturalNumbers(int m, int n)
    {
        System.Console.Write($"{m}, ");
        if (m < n) ShowNaturalNumbers(m + 1, n);
    }

    static void Main()
    {
        Error:
        System.Console.Write("\nWrite the first natural number M: ");
        int m = Convert.ToInt32(Console.ReadLine());

        System.Console.Write("\nWrite the second natural number N: ");
        int n = Convert.ToInt32(Console.ReadLine());

        if (m > n || m <= 0)
        {
            System.Console.Write("\nError! The numbers aren't natural. Write again.\n");
            goto Error;
        }

        System.Console.Write("\nThe natural numbers between the M and N: ");
        ShowNaturalNumbers(m, n);
    }
}