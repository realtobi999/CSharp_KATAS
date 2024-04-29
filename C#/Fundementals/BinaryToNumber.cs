namespace Fundamentals;

public class BinaryToNumber
{
    /*
        Zadání:
            Given an array of ones and zeroes,  convert  the  equivalent  binary
            value to an integer.
        Rešení:
            We use the Positional  Notation  Method  to  calculate  the  decimal
            number. For each binary value in the array we multiply its  position
            to the 2^i and its value (0,1). We add it all up  and  we  have  the
            decimal number.
    */
    public static int BinaryArrayToNumber(int[] BinaryArray)
    {
        int number = 0;

        for (int i = 0; i < BinaryArray.Length; i++)
        {
            // BinaryArray[(BinaryArray.Length -1) - i] => makes sure we are going from left to right
            number += (int)(Math.Pow(2, i) * BinaryArray[(BinaryArray.Length -1) - i]);
        }

        return number;
    }
}
