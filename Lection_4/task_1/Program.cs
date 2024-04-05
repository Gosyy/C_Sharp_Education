// Создать двумерный массив 3х5.
// Вывести на экран.

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

    static void WriteMatrix(int[,] matrix)
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

    static void Main()
    {
        int[,] matrix = CreateMatrix(10, 10, 0, 9);
        WriteMatrix(matrix);
    }
}
