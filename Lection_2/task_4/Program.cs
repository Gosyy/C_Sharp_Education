// Создать рандомный массив, вывести его, а также максимальное число.

using System; // Для Randor

System.Console.Write("Введите размер массива: ");
int n = Convert.ToInt32(Console.ReadLine());

Random rand = new Random();

int[] arr = new int[n];

for (int i = 0; i < arr.Length; i++) // Заполнение массива числами
{
    arr[i] = rand.Next (-10, 10);
}

for (int i = 0; i < arr.Length; i++) // Вывод элементов массива
{
    Console.Write($"{arr[i]} ");
}

int max = arr[0];

for (int i = 1; i < arr.Length; i++) // Поиск максимального числа
{
    if (max > arr[i])
    {
        max = arr[i];
    }
}

Console.Write($"\n Максимальный элемент массива: {max} \n");