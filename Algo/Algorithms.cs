using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo
{
    public static class Algorithms
    {
        public static void DistributeEqual(int[] arr)
        {
            int[] possiblities = new int[5];
            int minimum = arr.Min();

            for (int i = 0; i < possiblities.Length; i++)
            {
                foreach (var k in arr)
                {
                    int diff = k - minimum;
                    int stepsRequired = diff / 5 + (diff % 5) / 2 + ((diff % 5) % 2) / 1;
                    possiblities[i] += stepsRequired;
                }

                minimum--;

            }
            Console.WriteLine($"{Environment.NewLine}Algorithm = DistributeEqual{Environment.NewLine}Possiblities: {possiblities.Min()} ");
        }


        public static void findDuplicatesConstantSpace(int[] nums)
        {
            List<int> resultSet = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                // Get the index, the element corresponds to
                int index = Math.Abs(nums[i]) - 1;
                if (index < nums.Length)
                {
                    int val = nums[index];

                    // If the number is already negative, it means we are encountering it twice
                    if (val < 0)
                    {
                        resultSet.Add(index + 1);
                    }
                    // Flip the number at the index to negative
                    nums[index] *= -1;
                }

            }

            Console.WriteLine($"{Environment.NewLine}Algorithm = FindDuplicatesConstantSpace {Environment.NewLine}Duplicates: {string.Join(", ", resultSet.ToArray())}");

        }


        public static void CountTallestCandlesBlownOut(int[] candles)
        {
            // Get the height of the tallest candle
            int tallestCandle = candles.Max();
            foreach (int candle in candles)
            {
                if (candle>= tallestCandle)
                {
                    tallestCandle = candle;
                }
            }


            // Count how many tallest candles are present
            int candleCount = 0;
            foreach (int candle in candles)
            {
                if (candle == tallestCandle)
                {
                    candleCount++;
                }
            }

            Console.WriteLine($"{Environment.NewLine}" +
                $"Algorithm = CountTallestCandlesBlownOut {Environment.NewLine}" +
                $"Total {candleCount} candle(s) count of candle {tallestCandle}");

        }
    }
}