using System;
namespace lab2
{
    class Program
    {
        static void Main()
        {
            double sum = 0;
            Console.Write("Введите количество суммируемых элементов N: ");
            if (!Int32.TryParse(Console.ReadLine(), out int N) || N < 1)
            {
                Console.Write("Проверьте правильность ввода данных!\n");
                return;
            }
            for (int i = 0; i < N; i++) sum += (2 * i + 1) / (2 * i + 2.0);
            Console.Write($"Сумма первых {N} членов ряда равна {sum}\n");
        }
    }
}