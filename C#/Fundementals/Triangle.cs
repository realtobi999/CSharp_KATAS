namespace Fundamentals;

public class Triangle
{
    /*
        Zadání:
            Implement a function that accepts 3 integer  values  a,  b,  c.  The
            function should return true if a triangle  can  be  built  with  the
            sides of given length and false in any other case.
        Rešení:
            We just check if the two sides are  always  bigger  than  the  third
            side, if atleast one condition is true we return false, because  one
            side is bigger than the sum of the other two.  Otherwise  we  return
            true, because the triangle is valid.
    */
    public static bool IsTriangle(int a, int b, int c)
    {
         if (a + b <= c || a + c <= b || b + c <= a) {
            return false;
        }

        return true;
    }
}
