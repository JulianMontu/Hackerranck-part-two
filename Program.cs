using System.Collections.Generic;

namespace Hackerrank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> alice = new List<int>() { 10 ,15 ,20 };
            List<int> bob = new List<int>() { 5 ,6 ,7 };
            List<int> alice2 = Program.compareTriplets(alice,bob);
           
            
           
        }

        public static List<int> compareTriplets(List<int> a, List<int> b)
        {
            List<int> list = new List<int>() {0,0};
            int pointsA = 0;
            int pointsB = 0;
            for (int i = 0; i < a.Count; i++)
            {
                if (a[i] > b[i])
                {
                    pointsA++;
                    list.Insert(0, pointsA);
                    list.RemoveAt(2);
                }
                if (a[i] < b[i])
                {
                    pointsB++;
                    list.Insert(1, pointsB);
                    list.RemoveAt(2);
                }
            }
            return list;

        }

    }
}