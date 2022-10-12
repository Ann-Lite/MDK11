using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MDK11
{//найти номера столбцов произведение элементов которого положительное
    internal class Program
    {
        static void Main(string[] args)
        {
            string pos;
            Random random = new Random();
            int[,] _matr = new int[10, 10];
            int[,] _matr1 = new int[10, 10];
            _matr = Creat(ref _matr, random);
            DoMatr(_matr, out pos);
            WriteMatr(_matr);
            Console.Write(pos);
            Console.WriteLine();
            Random rand1 = new Random();
            Console.WriteLine();
            _matr1 = Creat(ref _matr1, rand1);
            DoMatr(_matr1, out pos);
            WriteMatr(_matr1);
            Console.Write(pos);
            Console.ReadKey();
        }
        private static int [,] Creat(ref int [,] matr, Random random)//Заполнение матрици
        {
            for (int i = 0; i < matr.GetLength(0); i++)
            {
                for(int j = 0; j < matr.GetLength(1); j++)
                {
                    matr[i, j] = random.Next(-9,9); ;
                }
            } return matr;
        }

        private static void WriteMatr(int[,] matr)//Вывод матрицы
        {
            for (int i = 0; i < matr.GetLength(0); i++)
            {
                for (int j = 0; j < matr.GetLength(1); j++)
                {
                    Console.Write("{0,3}",matr[i,j]);
                }
                Console.WriteLine();
            }
            return;
        }

        private static void DoMatr(int[,] matr, out string pos)//поиск столбцов с положительным произведение отрицательных чисел в столбце
        {
            int kol;
            pos = "";
            for (int j = 0; j < matr.GetLength(0); j++)
            {
                kol = 0;
                for (int i = 0; i < matr.GetLength(1); i++)
                {
                    if (matr[i,j] < 0)
                    {
                        kol++;
                    }
                }
                if (kol % 2 == 0)
                {
                    pos += $"{j+1};";
                }
            }
        }
    }
}
