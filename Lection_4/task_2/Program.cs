// Создать двумерный массив.
// Проверка суммы цифр элементов массива на четность.

class Program
{
    static int[,] CreateMatrix(int rowCoutn, int columsCount, int minNum, int maxNum)
    {
        int[,] matrix = new int[rowCoutn, columsCount];
        Random rand = new Random();

        for (int i = 0; i < matrix.GetLength(0); i++) // matrix.GetLength(0) – запросить кол-во строк (0)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = rand.Next(minNum, maxNum + 1);
            }
        }

        return matrix;
    }

    static void ShowMatrix(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++) // matrix.GetLength(0) – запросить кол-во строк (0)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                System.Console.Write($"{matrix[i, j]} "); // Интерполяция строк
            }
            System.Console.WriteLine();
        }
    }

    static int SumOfDigits(int num)
    {
        int sumOfDigits = 0;
        num = Math.Abs(num);

        if (num < 10)
        {
            goto end;
        }
        else while (num != 0)
        {
            sumOfDigits += num % 10;
            num /= 10;
        }

        end:
        return sumOfDigits;
    }

    static int[,] EvenArray(int[,] array) // Возвращает массив с четными суммами цифр на месте чисел в массиве. Нечётные суммы - нули.
    {
        int[,] evenArray = new int[array.GetLength(0), array.GetLength(1)];
        
        for (int i = 0; i < array.GetLength(0); i++) // matrix.GetLength(0) – запросить кол-во строк (0)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (SumOfDigits(array[i, j]) % 2 == 0)
                {
                    evenArray[i, j] = SumOfDigits(array[i, j]);
                }
                else evenArray[i, j] = 0;
            }
        }

        return evenArray;
    }
    static void Main()
    {
        int[,] matrix = CreateMatrix(10, 10, -1000, 1000);

        System.Console.Write($"\nЗаданная матрица:\n\n");
        ShowMatrix(matrix);

        System.Console.Write($"\n\nМатрица чётных сумм исходных чисел:\n\n");
        ShowMatrix(EvenArray(matrix));
    }
}