// Задача 3: Напишите программу, которая перевернёт одномерный массив.
// (первый элемент станет последним, второй – предпоследним и т.д.)

class Program
{
   static int[] ToInvertArray(int[] arr)
    {
        for (int i = 0; i < arr.Length / 2; i++)
        {
            int temp = arr[i];
            arr[i] = arr[arr.Length - 1 - i];
            arr[arr.Length - 1 - i] = temp;
        }
        
        return arr;
    }

    static void PrintArray(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            System.Console.Write($"{arr[i]} ");
        }
    }

    static int[] WriteArrayWithRandomNumbers()
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
            Console.Write("\nError. Enter the valid array values thresholds.");
            goto gotoError;
        }

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = rand.Next(MinThr, MaxThr);
        }        
        
        return array;
    }

    static void Main()
    {
        int[] array = WriteArrayWithRandomNumbers();
        System.Console.Write($"\nYour random array[{array.Length}]: "); PrintArray(array);
        System.Console.Write($"\nInverted array[{array.Length}]:    "); PrintArray(ToInvertArray(array));
    }
}