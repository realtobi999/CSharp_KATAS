namespace Fundamentals;

/*
    Zadaní:
        Given an array (arr) as an argument complete the  function  countSmileys
        that should return the total number of smiling faces.

        Rules for a smiling face: Each smiley face must contain a valid pair  of
        eyes. Eyes can be marked as : or ; A smiley face can have a nose but  it
        does not have to. Valid characters for a nose are - or ~  Every  smiling
        face must have a smiling mouth that should be marked with either ) or  D
        No additional characters are allowed except for those mentioned.
    Řešení:
        Basically we create a mini static function to check for valid smile  and
        then just loop over the array  and  check  for  each  valid  smiley  and
        increment the count.
*/
public class CountSmileysKata
{
    public static int CountSmileys(string[] smileys)
    {
        if (smileys.Length == 0) return 0;

        int result = 0;

        foreach (var smiley in smileys)
        {
            if (IsValidSmiley(smiley))
            {
                result++;
            }
        }

        return result;
    }

    private static bool IsValidSmiley(string smiley)
    {
        char[] smileyChars = smiley.ToCharArray();

        if (smileyChars.Length == 2)
        {
            if ((smileyChars[0] == ':' || smileyChars[0] == ';') &&
                (smileyChars[1] == ')' || smileyChars[1] == 'D'))
            {
                return true;
            }
        }
        else if (smileyChars.Length == 3)
        {
            if ((smileyChars[0] == ':' || smileyChars[0] == ';') &&
                (smileyChars[1] == '-' || smileyChars[1] == '~') &&
                (smileyChars[2] == ')' || smileyChars[2] == 'D'))
            {
                return true;
            }
        }

        return false;
    }
}
