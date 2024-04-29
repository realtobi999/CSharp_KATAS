namespace Fundamentals;

public class FirstNonRepeatingLetterKata
{
    /*
        Zadání:
            Write a  function  named  first_non_repeating_letter  that  takes  a
            string input, and returns the first character that is  not  repeated
            anywhere in the string. For example, if given  the  input  'stress',
            the function should return 't', since the letter t only occurs  once
            in the  string,  and  occurs  first  in  the  string.  As  an  added
            challenge, upper- and lowercase  letters  are  considered  the  same
            character, but the function should return the correct case  for  the
            initial letter. For example, the input 'sTreSS' should  return  'T'.
            If a string contains all repeating characters, it should  return  an
            empty string ("");
        Řešení:
            We create a hashmap to count characters and loop over the string  in
            lowercase. Then loop over the string one more time, to get the first
            character with count of 1 from  the  hashmap  in  lowercase  but  we
            return the original lettereither uppercase or lowercase
    */
    public static string FirstNonRepeatingLetter(string s)
    {
        Dictionary<int, int> counts = new();

        foreach (char letter in s.ToLower()) {
            if (counts.ContainsKey(letter)) {
                counts[letter]++;
            } else {
                counts[letter] = 1;
            }
        }

        foreach (char letter in s ) {
            if (counts[char.ToLower(letter)] == 1) {
                return letter.ToString();
            }
        }
        
        return "";
    }
}
