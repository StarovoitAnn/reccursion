
namespace Recursion
{
    public class RecursionTasks
    {
        /*Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
        Выполнить с помощью рекурсии.
        N = 5 -> "5, 4, 3, 2, 1"
        N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/
        public static void Task64()
        {
            Console.WriteLine("Введите натуральное число");
            int n = int.Parse(Console.ReadLine() ?? "0");
            Console.WriteLine($"Вы ввели число {n}");

            PrintN(n);

            static void PrintN(int n)
            {
                if (n > 0)
                {
                    Console.Write($"{n} ");
                    n--;
                    PrintN(n);
                }
            }
        }

        /*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
        M = 1; N = 15 -> 120
        M = 4; N = 8. -> 30*/
        public static void Task66()
        {
            Console.WriteLine("Введите натуральное число M");
            int m = int.Parse(Console.ReadLine() ?? "0");
            Console.WriteLine("Введите натуральное число N");
            int n = int.Parse(Console.ReadLine() ?? "0");
            if (m > n)
            {
                throw new ArgumentException("N не может быть больше M");
            }

            Console.WriteLine($"Вы ввели числа M:{m}, N:{n}");

            int sum = PrintSum(m, n);
            Console.WriteLine($"Сумма чисел M:{m} и N:{n} = {sum}");

            static int PrintSum(int start, int end)
            {
                if (start < end)
                {
                    return start + PrintSum(start + 1, end);
                }
                else
                {
                    return end;
                }

            }
        }

        /*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
        m = 2, n = 3 -> A(m,n) = 9
        m = 3, n = 2 -> A(m,n) = 29*/
        public static void Task68()
        {
            Console.WriteLine("Введите натуральное число M");
            int m = int.Parse(Console.ReadLine() ?? "0");
            Console.WriteLine("Введите натуральное число N");
            int n = int.Parse(Console.ReadLine() ?? "0");

            Console.WriteLine(ack(m, n));

            static int ack(int m, int n)
            {
                if (m == 0)
                {
                    return n + 1;
                }
                else if ((m > 0) && (n == 0))
                {
                    return ack(m - 1, 1);
                }
                else if ((m > 0) && (n > 0))
                {
                    return ack(m - 1, ack(m, n - 1));
                }
                else
                    return n + 1;
            }
        }
    }
}