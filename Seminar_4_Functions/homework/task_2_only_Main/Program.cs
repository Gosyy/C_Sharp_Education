// Задача 2: Задайте массив заполненный случайными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

class Program
{
    static void Main() // Зададим массив одной строкой.
    {
        Console.Write("\nEnter the number of numbers of the array: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] array = new int[n];
        var rand = new Random();
        int count = 0;

        for (int i = 0; i < n; i++)
        {
            array[i] = rand.Next(99, 1000);
        }

        for (int i = 0; i < n; i++)
        {
            if (array[i] % 2 == 0) count++;
        }

        System.Console.Write($"\nArray[{n}]: ");
        for (int i = 0; i < n; i++)
        {
            System.Console.Write($"{array[i]} ");
        }

        System.Console.Write($"\n\nNumber of the even numbers in the array is {count}.\n");
    }
}