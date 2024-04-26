using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms
{
    public class PinCombinationKata
    {
        public static List<string> GetPINs(string observed)
        {
            List<List<int>> pools = new(observed.Length);

            for (int i = 0; i < observed.Length; i++)
            {
                int val = observed[i] - '0';
                pools.Add(GetPossibleKeys(val));
            }

            List<string> result = new();
            GeneratePINs(observed.Length, pools, "", result);
            return result;
        }

        private static void GeneratePINs(int length, List<List<int>> pools, string current, List<string> result)
        {
            if (current.Length == length)
            {
                result.Add(current);
                return;
            }

            foreach (int digit in pools[current.Length])
            {
                GeneratePINs(length, pools, current + digit.ToString(), result);
            }
        }

        private static List<int> GetPossibleKeys(int val)
        {
            return val switch
            {
                1 => new List<int> { 1, 2, 4 },
                2 => new List<int> { 1, 2, 3, 5 },
                3 => new List<int> { 2, 3, 6 },
                4 => new List<int> { 1, 4, 5, 7 },
                5 => new List<int> { 2, 4, 5, 6, 8 },
                6 => new List<int> { 3, 5, 6, 9 },
                7 => new List<int> { 4, 7, 8 },
                8 => new List<int> { 5, 7, 8, 9, 0 },
                9 => new List<int> { 6, 8, 9 },
                0 => new List<int> { 8, 0 },
                _ => throw new ArgumentException(),
            };
        }
    }
}
