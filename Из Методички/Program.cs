using System;
using System.Security.Cryptography.X509Certificates;

namespace HomeWork
{
    class File
    {
        public static int Larger(int num1, int num2)
        {
            if (num1 >= num2)
            {
                return num1;
            }
            else
            {
                return num2;
            }
        }
        public static void Replacer(ref string a, ref string b)
        {
            (a, b) = (b, a);
        }
        public static long FactorialInt(long n)
        {
                if (n == 1) return 1;
                return n * FactorialInt(n - 1);
        }
        public static bool FactorialBool(int n)
        {
            try
            {
                checked
                {
                    int f = 1;
                    for (int i = 1; i <= n; i++)
                    {
                        f = i * f;
                    }
                    return true;
                }
            }
            catch (OverflowException)
            {
                return false;
            }
        }
        public static int Nod(int n1, int n2)
        {
            while (n1 != n2) 
            {
                if (n1 > n2)
                {
                    n1 -= n2;
                }
                else
                {
                    n2 -= n1;
                }
            }
            return n1;
        }
        public static int Nod(int n1, int n2, int n3)
        {
            return Nod(Nod(n1, n2), n3);
        }
        public static long Fib(long n)
        {
            if ((n == 0) || (n == 1))
            {
                return n;
            }
            return Fib(n - 1) + Fib(n - 2);
        }
        static void Main(string[] args)
        {
            /*Упражнение 5.1 Написать метод, возвращающий наибольшее из двух чисел. Входные
            параметры метода – два целых числа. Протестировать метод.*/
            Console.WriteLine("Упражнение 5.1 (max)");
            Console.WriteLine("Введите два целых числа");
            try
            {
                int num1 = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());
                Console.WriteLine($"Наибольшое число {Larger(num1, num2)}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Введен неверный формат");
            }

            /*Упражнение 5.2 Написать метод, который меняет местами значения двух передаваемых
            параметров. Параметры передавать по ссылке. Протестировать метод.*/
            Console.WriteLine("\nУпражнение 5.2 (swap)");
            Console.WriteLine("Введите два любых значения или слова");
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();
            Replacer(ref str1, ref str2);
            Console.WriteLine($"Первое значение:{str1}\nВторое значение:{str2}");

            /*Упражнение 5.3 Написать метод вычисления факториала числа, результат вычислений
            передавать в выходном параметре. Если метод отработал успешно, то вернуть значение true;
            если в процессе вычисления возникло переполнение, то вернуть значение false. Для
            отслеживания переполнения значения использовать блок checked.*/
            Console.WriteLine("\nУпражнение 5.3 (Факториал)");
            Console.WriteLine("Введите число");
            try
            {
                int numf = int.Parse(Console.ReadLine());
                if (FactorialBool(numf))
                {
                    Console.WriteLine($"Факториал {numf} = {FactorialInt(numf)}");
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
            }
            catch(FormatException)
            {
                Console.WriteLine("Введено неверное значение числа");
            }
            /*Упражнение 5.4 Написать рекурсивный метод вычисления факториала числа.*/
            Console.WriteLine("\nУпражнение 5.4 (Факториал)");
            Console.WriteLine("Введите число");
            try
            {
                int numr = int.Parse(Console.ReadLine());
                Console.WriteLine(FactorialInt(numr));
            }
            catch(FormatException)
            {
                Console.WriteLine("Введен неверный формат");
            }
            catch(StackOverflowException)
            {
                Console.WriteLine("Рекурсия переполнена");
            }
            /*Домашнее задание 5.1 Написать метод, который вычисляет НОД двух натуральных чисел
            (алгоритм Евклида). Написать метод с тем же именем, который вычисляет НОД трех
            натуральных чисел.*/
            Console.WriteLine("\nДомашнее задание 5.1 (НОД)");
            try
            {
                Console.WriteLine("Введите два числа");
                int numnod1 = int.Parse(Console.ReadLine());
                int numnod2 = int.Parse(Console.ReadLine());
                Console.WriteLine($"НОД двух чисел: {Nod(numnod1, numnod2)}");

                Console.WriteLine("Ввдеите три числа");
                numnod1 = int.Parse(Console.ReadLine());
                numnod2 = int.Parse(Console.ReadLine());
                int numnod3 = int.Parse(Console.ReadLine());
                Console.WriteLine($"НОД трех чисел: {Nod(numnod3, numnod2, numnod1)}");
            }
            catch(FormatException)
            {
                Console.WriteLine("Неверный формат введенных данных");
            }
            /*Домашнее задание 5.2 Написать рекурсивный метод, вычисляющий значение n-го числа
            ряда Фибоначчи. Ряд Фибоначчи – последовательность натуральных чисел 1, 1, 2, 3, 5, 8,
            13... Для таких чисел верно соотношение Fk = Fk-1 + Fk-2 .*/
            Console.WriteLine("\nДомашнее задание 5.2 (fib)");
            Console.WriteLine("Введите число для вычисления Фиббоначи");
            try
            {
                int fibnum = int.Parse(Console.ReadLine());
                Console.WriteLine(Fib(fibnum));
            }
            catch (FormatException)
            {
                Console.WriteLine("Введен неверный формат данных");
            } 
            

        }
    }
}