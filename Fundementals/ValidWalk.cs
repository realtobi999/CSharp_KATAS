namespace Fundementals;

public class ValidWalk
{
     /*
        Zadání:
            You live in the city of Cartesia where all roads are laid out in a perfect grid. 
            You arrived ten minutes too early to an appointment, so you decided to take the 
            opportunity to go for a short walk. The city provides its citizens with a 
            Walk Generating App on their phones -- everytime you press the button it sends you
            an array of one-letter strings representing directions to walk (eg. ['n', 's', 'w', 'e']).
            You always walk only a single block for each letter (direction) and you know it takes
            you one minute to traverse one city block, so create a function that will return true
            if the walk the app gives you will take you exactly ten minutes (you don't want to be early or late!)
            and will, of course, return you to your starting point. Return false otherwise.
        Rešení:
            First of all we make sure to return any walk that has more than 10 directions.
            Then we setup the x, y coordinates and loop over the walk and for each direction
            we modify the coordinates accordingly. Then we return a boolean if the coordinates
            are both zero (starting position)
            Time Complexity: O(n)

    */
    public static bool IsValidWalk(string[] walk)
    {
        if (walk.Length != 10) 
        {
            return false;
        }
        
        int x = 0;
        int y = 0;
        foreach (string direction in walk) {
            if (direction == "n") {
                x++;
            }
            if (direction == "s")
            {
                x--;
            }
            if (direction == "w")
            {
                y++;
            }
            if(direction == "e")
            {
                y--;
            }
        }

        return x == 0 && y == 0;
    }
}
