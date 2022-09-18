using System;
namespace lab3
{
    class Program
    {
        static void Main()
        {
            int row, column;
            int i, j, sum = 0;
            Console.Write("Введите количество строк матрицы N (3 <= N <= 10): ");
            if (!Int32.TryParse(Console.ReadLine(), out row) || row < 3 || row > 10)
            {
                Console.WriteLine("Проверьте правильность ввода данных!");
                return;
            }
            Console.Write("Введите количество столбцов матрицы M (3 <= M <= 10): ");
            if (!Int32.TryParse(Console.ReadLine(), out column) || column < 3 || column > 10)
            {
                Console.WriteLine("Проверьте правильность ввода данных!");
                return;
            }
            int[,] arr = new int[row, column];
            Random random = new Random();
            Console.WriteLine("Исходная матрица: ");
            for (i = 0; i < row; i++)
            {
                for (j = 0; j < column; j++)
                {
                    arr[i, j] = random.Next(2, 13);
                    Console.Write("{0,4}", arr[i, j]);
                }
                Console.WriteLine();
            }
            int min = row < column ? row : column;
            for (i = 0; i < row; i++)
                for (j = 0; j < column; j++)
                    if ((i + j >= min - 1) && (j < min)) sum += arr[i, j];
            Console.WriteLine($"Сумма элементов заданной области равна {sum}");
        }
    }
}