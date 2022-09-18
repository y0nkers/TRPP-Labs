using System;
namespace lab1
{
    class Program
    {
        static void Main()
        {
            int row, column, sum = 0;
            Console.Write("Введите количество строк матрицы: ");
            if (!Int32.TryParse(Console.ReadLine(), out row) || row < 1)
            {
                Console.WriteLine("Проверьте правильность ввода данных!");
                return;
            }
            Console.Write("Введите количество столбцов матрицы: ");
            if (!Int32.TryParse(Console.ReadLine(), out column) || column < 1)
            {
                Console.WriteLine("Проверьте правильность ввода данных!");
                return;
            }
            int[,] arr = new int[row, column];
            Console.Write("Введите элементы матрицы: \n");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"a[{i}][{j}] = ");
                    if (!Int32.TryParse(Console.ReadLine(), out arr[i,j]))
                    {
                        Console.WriteLine("Проверьте правильность ввода данных!");
                        return;
                    }
                }
            }
            Console.Write("Введите номер строки, в которой необходимо подсчитать сумму элементов: ");
            if (!Int32.TryParse(Console.ReadLine(), out row) || row < 0 || row > arr.GetUpperBound(0))
            {
                Console.WriteLine("Проверьте правильность ввода данных!");
                return;
            }
            for (column = 0; column <= arr.GetUpperBound(1); column++) sum += arr[row, column];
            Console.Write($"Сумма {row}-й строки матрицы равна {sum}\n");
        }
    }
}