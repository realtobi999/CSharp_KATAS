namespace Fundementals;

public class Triangle
{
    /*
        Zadání:
            Implement a function that accepts 3 integer values a, b, c. 
            The function should return true if a triangle can be built
            with the sides of given length and false in any other case.
        Rešení:
            We just check if the sum of a and b is less than c. In that
            case we return false else true
    */
    public static bool IsTriangle(int a, int b, int c)
    {
        if (a + b < c) {
            return false;
        }

        return true;
    }
}
