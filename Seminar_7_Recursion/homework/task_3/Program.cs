// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.

using System;
class CustomArray
{
    private int[] data;

    public CustomArray(int[] arr)
    {
        data = arr;
    }

    public void ReverseArray()
    {
        PrintFromEndRecursive(data.Length - 1);
    }

    private void PrintFromEndRecursive(int index)
    {
        if (index < 0)
            return;

        Console.Write($"{data[index]}, ");
        PrintFromEndRecursive(index - 1);
    }
}

class Program
{
    static void ShowArray(int[] array)
    {
        System.Console.Write($"\nYour array[{array.Length}]: ");
        for (int i = 0; i < array.Length; i++)
        {
            System.Console.Write($"{array[i]}, "); // Интерполяция строк
        }
        System.Console.WriteLine();
    }

        static int[] CreateArrayWithRandomNumbers()
    {
        Console.Write("\nEnter the number of numbers in the array: ");
        int n = Convert.ToInt32(Console.ReadLine());

        gotoError:

        Console.Write("\nEnter the minimum array value threshold: "); // Минимальный порог значения массива
        int MinThr = Convert.ToInt32(Console.ReadLine());

        Console.Write("\nEnter the maximum array value threshold: "); // Минимальный порог значения массива
        int MaxThr = Convert.ToInt32(Console.ReadLine());

        var rand = new Random();
        int[] array = new int[n];

        if (MinThr >= MaxThr)
        {
            Console.Write("\nError. Enter the valid array values thresholds.\n");
            goto gotoError;
        }

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = rand.Next(MinThr, MaxThr);
        }        
        
        return array;
    }

    static void Main(string[] args)
    {
        int[] array = CreateArrayWithRandomNumbers();
        ShowArray(array);

        CustomArray ReverseArray = new CustomArray(array);
        System.Console.Write($"\nReversed array: ");
        ReverseArray.ReverseArray();
    }
}