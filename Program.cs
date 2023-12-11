//1 задача//
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
        Console.Write("Введите значение M: ");
        int M = int.Parse(Console.ReadLine());

        Console.Write("Введите значение N: ");
        int N = int.Parse(Console.ReadLine());

        PrintNumbersInRange(M, N);

        Console.ReadKey();
    }
}

//2 задача//
// using System;

// class Program
// {
//     static int Ackermann(int m, int n)
//     {
//         if (m == 0)
//         {
//             return n + 1;
//         }
//         else if (n == 0)
//         {
//             return Ackermann(m - 1, 1);
//         }
//         else
//         {
//             return Ackermann(m - 1, Ackermann(m, n - 1));
//         }
//     }

//     static void Main()
//     {
//         Console.Write("Введите значение m: ");
//         int m = int.Parse(Console.ReadLine());

//         Console.Write("Введите значение n: ");
//         int n = int.Parse(Console.ReadLine());


//         int result = Ackermann(m, n);
//         Console.WriteLine($"Результат функции Аккермана для m={m} и n={n}: {result}");

//         Console.ReadKey();
//     }
// }

//задача 3//
// using System;

// class Program
// {
//     static void PrintArrayReverse(int[] arr, int index)
//     {
//         if (index >= 0)
//         {
//             Console.Write(arr[index] + " ");
//             PrintArrayReverse(arr, index - 1);
//         }
//     }

//     static void Main()
//     {
//         int[] myArray = { 1, 2, 3, 4, 5 };

//         Console.Write("Элементы массива в обратном порядке: ");
//         PrintArrayReverse(myArray, myArray.Length - 1);

//         Console.ReadKey();
//     }
// }
