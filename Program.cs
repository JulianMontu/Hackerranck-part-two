using System.Collections.Generic;

namespace Hackerrank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<int> alice = new List<int>() { 10, 15, 20 };
            //List<int> bob = new List<int>() { 5, 6, 7 };
            //List<int> alice2 = Program.compareTriplets(alice, bob);

            List<int> alice = new List<int>() { -4, 3, -9, 0, 4, 1 };
            Program.plusMinus(alice);



        }

        /// <summary>
        /// Hackerranck function plusMinus
        /// </summary>
        /// <param name="arr">Lista de valores</param>
        public static void plusMinus(List<int> arr)
        {
            double ceroValues = 0;
            double negativeValues = 0;
            double positiveValues = 0;
            double countListValues = arr.Count;
            foreach (int i in arr)
            {
                if (i is 0)
                {
                    ceroValues++;
                }
                else if(i < 0)
                {
                    negativeValues++;
                }
                else
                {
                    positiveValues++;
                }
            }

             ceroValues = ceroValues / countListValues;
             negativeValues = negativeValues / countListValues;
             positiveValues = positiveValues / countListValues;

            Console.WriteLine(positiveValues.ToString("N6"));
            Console.WriteLine(negativeValues.ToString("N6"));
            Console.WriteLine(ceroValues.ToString("N6"));


        }

        /// <summary>
        /// Hackerranck compareTriplets
        /// </summary>
        /// <param name="a">Lista de puntos Alice</param>
        /// <param name="b">Lista de puntos bob</param>
        /// <returns>retorna lista con dos espacios de puntuación</returns>
        public static List<int> compareTriplets(List<int> a, List<int> b)
        {
            List<int> list = new List<int>() { 0, 0 };
            int pointsA = 0;
            int pointsB = 0;
            for (int i = 0; i < a.Count; i++)
            {
                if (a[i] > b[i])
                {
                    pointsA++;
                    list[0] = pointsA;
                }
                if (a[i] < b[i])
                {
                    pointsB++;
                    list[1] = pointsB;
                }
            }
            return list;

        }

    }
}