using System;

class Program
{
    static void PrintNumbersInRange(int m, int n)
    {
        if (m <= n)
        {
            Console.Write(m + " ");
            PrintNumbersInRange(m + 1, n);
        }
    }

    static void Main()
    {
        // Введите значения M и N
        Console.Write("Введите значение M: ");
        int M = int.Parse(Console.ReadLine());

        Console.Write("Введите значение N: ");
        int N = int.Parse(Console.ReadLine());

        // Вызываем функцию для вывода чисел в заданном промежутке
        PrintNumbersInRange(M, N);

        // Ждем нажатия клавиши перед закрытием консоли (для удобства просмотра вывода)
        Console.ReadKey();
    }
}
