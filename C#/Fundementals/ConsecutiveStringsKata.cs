namespace Fundamentals;

public class ConsecutiveStringsKata
{
    /*
         Zadání:
            You are given an array(list) strarr of strings  and  an  integer  k.
            Your task is to return the first  longest  string  consisting  of  k
            consecutive strings taken in the array.
         Řešení:
            First of all we eleminate any edge cases so we have  a  valid  array
            and an integer k. Then we create  a  for  loop  and  initialize  the
            consecutive word, we then loop over the next k elements  and  append
            them to the consecutive word, then we just check if its longer  than
            our result and if it is we set it as the result.
    */
    public static string LongestConsec(string[] strarr, int k)
    {
        if (strarr.Length == 0 || k > strarr.Length || k <= 0)
        {
            return "";
        }

        string result = "";

        for (int i = 0; i < strarr.Length; i++)
        {
            string consecWord = "";

            for (int j = 0; j < k; j++)
            {
                if (i + j < strarr.Length) // Check if i + j is within bounds
                {
                    consecWord += strarr[i + j];
                }
                else
                {
                    break;
                }
            }

            if (consecWord.Length > result.Length)
            {
                result = consecWord;
            }
        }

        return result;
    }
}
