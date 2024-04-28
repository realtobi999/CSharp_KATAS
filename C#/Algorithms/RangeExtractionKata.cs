using NUnit.Framework;

namespace Algorithms;

public class RangeExtractionKata
{
    /*
        Zadání:
            A format for expressing an ordered list of  integers  is  to  use  a
            comma separated list of either individual integers  or  a  range  of
            integers denoted by the starting  integer  separated  from  the  end
            integer in the range by a dash, '-'. The range includes all integers
            in the interval including both endpoints. It  is  not  considered  a
            range unless it spans at least 3 numbers. Complete the  solution  so
            that it takes a list of integers in increasing order and  returns  a
            correctly formatted string in the range format.
        Řešení:
            We first create a list of the ranges. Then we  loop  over  the  args
            array and start with the number args[i] then we while-loop over a if
            statement that checks if the next number is one bigger then the next
            one. We increment i until we reach the number the range  ends  with.
            After that we just check if the range is atleast 3 numbers.  If  not
            we add start number (if the next number was bigger than 1) or we add
            the end number if it the range was less then 3 numbers.
    */
    public static string Extract(int[] args)
    {
        List<List<string>> ranges = new();

        for (int i = 0; i < args.Length; i++)
        {
            int start = args[i];
            while (i < args.Length - 1 && args[i + 1] == args[i] + 1)
            {
                i++;
            }
            int end = args[i];

            List<string> range = new List<string>();
            if (start != end && end - start >= 2)
            {
                range.Add(start.ToString() + "-" + end.ToString());
            }
            else
            {
                range.Add(start.ToString());
                if (end != start)
                {
                    range.Add(end.ToString());
                }
            }

            ranges.Add(range);
        }

        return string.Join(",", ranges.SelectMany(r => r).ToArray());
    }
}

