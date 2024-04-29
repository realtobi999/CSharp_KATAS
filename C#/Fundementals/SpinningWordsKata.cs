namespace Fundamentals;

public class SpinningWordsKata
{
    /*
        Zadání:
            Write a function that takes in a string of one or  more  words,  and
            returns the same string, but with all words that have five  or  more
            letters reversed (Just like the name of this Kata).  Strings  passed
            in will consist of only letters and spaces. Spaces will be  included
            only when more than one word is present.
        Řešení:
            We just loop over each of the word in the sentence and if its longer
            then five we reverse it.
    */
    public static string SpinWords(string sentence)
    {
        string[] wordArray = sentence.Split(' ');

        for (int i = 0; i < wordArray.Length; i++)
        {
            if (wordArray[i].Length >= 5)
            {
                wordArray[i] = new string(wordArray[i].ToCharArray().Reverse().ToArray());
            }
        }

        return string.Join(" ", wordArray);
    }
}

