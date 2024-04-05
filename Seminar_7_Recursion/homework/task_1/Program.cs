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

    public static void Main()
    {
        Error:
        System.Console.Write("\nWrite the first number M: ");
        int m = Convert.ToInt32(Console.ReadLine());

        System.Console.Write("\nWrite the second number N: ");
        int n = Convert.ToInt32(Console.ReadLine());

        if (m > n)
        {
            System.Console.Write("\nError! The first number cannot be larger than the first. Write again.\n");
            goto Error;
        }

        System.Console.Write("The natural numbers between the M and N: ");
        ShowNaturalNumbers(m, n);
    }
}