namespace Fundementals;

public class MexicanWaveKata
{
    /*
        Zadání:
            In this simple Kata your task is to create a function that  turns  a
            string into a Mexican Wave. You will be passed a string and you must
            return that string in an array where an uppercase letter is a person
            standing up.

            1.  The input string will always be lower case but maybe empty.
            2.  If the character in the string is whitespace then pass over it as
               if it was an  empty  seat  
            Example:  wave("hello")  =>  {"Hello","hEllo", "heLlo", "helLo", "hellO"}
        Řešení:
            First we check valide the string and then  we  just  loop  over  the
            string.Length and create a string which will  have  the  ith  letter
            uppercase except for whitespace
    */
    public static List<string> Wave(string str)
    {
        List<string> result = new();

        if (string.IsNullOrEmpty(str))
        {
            return result;
        }

        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] == ' ')
            {
                continue;
            }

            result.Add(str.Substring(0, i) + char.ToUpper(str[i]) + str.Substring(i + 1));
        }

        return result;
    }
}
