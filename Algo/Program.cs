using System;

namespace Algo
{
    class Program
    {
        static void Main(string[] args)
        {


            Algorithms.findDuplicatesConstantSpace(new int[] { 13, 15, 3, 2, 7, 8, 2, 3, 1, 20, 2 });
            Algorithms.DistributeEqual(new int[] { 2, 6, 6, 6 });
            Algorithms.CountTallestCandlesBlownOut(new int[] { 4, 1, 1, 4, 6, 3, 4, 6, 6 });

            Console.ReadLine();
        }
    }
}