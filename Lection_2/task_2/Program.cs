// Создать рандомный массив и вывести его на экран.

using System; // Для Randor

System.Console.Write("Введите размер массива: ");
int n = Convert.ToInt32(Console.ReadLine());

Random rand = new Random();

int[] arr = new int[n];

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rand.Next (-10, 10);
}

for (int i = 0; i < arr.Length; i++)
{
    Console.Write($"{arr[i]} ");
}