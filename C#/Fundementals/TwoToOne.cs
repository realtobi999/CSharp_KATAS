namespace Fundamentals;

public class TwoToOne
{
    /*
        Zadání:
            Take 2 strings s1 and s2 including only letters from a to z.  Return
            a new sorted  string,  the  longest  possible,  containing  distinct
            letters- each taken only once - coming from s1 or s2.
                a = "xyaabbbccccdefww" b = "xxxxyyyyabklmopq" longest(a,  b)  ->
                "abcdefklmopqwxy"
        Rešení:
            We first combine the two strings to get all the duplicates into  one
            string. Then we loop over the string and find the index of the  char
            in the string. If its not found (the IndexOf(c) returns -1)  we  add
            it  to  the  result  string.  Lastly  we  just  sort  the  array  in
            alphabetica order.
            https://www.codewars.com/kata/5656b6906de340bd1b0000ac/solutions/csharp
            
    */
    public static string Longest(string s1, string s2)
    {
        string combined = s1 + s2;
        string result = "";

        foreach (char c in combined)
        {
            if (combined.IndexOf(c) == -1)
            {
                result += c;
            }
        }

        char[] sortedChars = result.ToCharArray();
        Array.Sort(sortedChars);

        return new string(sortedChars);
    }
}
