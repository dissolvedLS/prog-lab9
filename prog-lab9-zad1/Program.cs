using System;

namespace prog_lab9_zad1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите количество рядков и столбцов у матрицы : ");

            int M = Convert.ToInt32(Console.ReadLine());

            int N = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Матрица :");

            Random random = new Random();

            int[,] mas = new int[M, N];

            for (int i = 0; i < mas.GetLength(0); i++)
            {

                for (int j = 0; j < mas.GetLength(1); j++)
                {

                    mas[i, j] = random.Next(-10, 20);

                }

            }

            // объявляю делегат с функцией ShowMatrix
            Action<int[,]> action = ShowMatrix;

            ChangeMatrix(mas, action);

            // присваивание делегату функции ShowPositive
            action = ShowPositive;

            ChangeMatrix(mas, action);

            // присваивание делегату функции MultiplyMatrix
            action = MultiplyMatrix;

            ChangeMatrix(mas, action);

            // присваивание делегату функции ShowMatrix
            action = ShowMatrix;

            ChangeMatrix(mas, action);

        }

        static void ChangeMatrix(int[,] mas, Action<int[,]> act)
        {

            act.Invoke(mas);

        }

        static void ShowMatrix(int[,] mas)
        {

            for (int i = 0; i < mas.GetLength(0); i++)
            {

                for (int j = 0; j < mas.GetLength(1); j++)
                {

                    Console.Write(mas[i, j] + "\t");

                }

                Console.WriteLine();

            }

        }

        static void ShowPositive(int[,] mas)
        {

            Console.WriteLine("Положительные елементы матрицы : ");

            for (int i = 0; i < mas.GetLength(0); i++)
            {

                for (int j = 0; j < mas.GetLength(1); j++)
                {

                    if (mas[i, j] >= 0)
                    {

                        Console.Write(mas[i, j] + " ");

                    }

                }

            }

            Console.WriteLine();

        }

        static void MultiplyMatrix(int[,] mas)
        {

            Console.WriteLine("Измененная матрица : ");

            for (int i = 0; i < mas.GetLength(0); i++)
            {

                for (int j = 0; j < mas.GetLength(1); j++)
                {

                    if (mas[i, j] >= 0)
                    {

                        mas[i, j] *= 3;

                    }

                }

            }

        }
    }
}
