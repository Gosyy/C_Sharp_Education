// Задача 2: Задайте массив заполненный случайными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

class Program
{
   static void WriteCountEvenNumbersInArray(int[] arr)
    {
        int count = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] % 2 == 0) count++;
        }
        
        System.Console.Write($"\n\nNumber of the even numbers in the array is {count}.\n");
    }

    static void PrintArray(int[] arr)
    {
        System.Console.Write($"\nYour array[{arr.Length}]: ");
        for (int i = 0; i < arr.Length; i++)
        {
            System.Console.Write($"{arr[i]} ");
        }
    }

    static int[] WriteArrayWithRandomNumbers()
    {
        Console.Write("\nEnter the number of numbers in the array: ");
        int n = Convert.ToInt32(Console.ReadLine());

        var rand = new Random();
        int[] array = new int[n];

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = rand.Next(99, 1000);
        }        
        
        return array;
    }

    static void Main()
    {
        int[] Array = WriteArrayWithRandomNumbers();
        PrintArray(Array);
        WriteCountEvenNumbersInArray(Array);
    }
}
