namespace Fundementals;

public class UniqueNumberInArray
{
    /*
        Zadání:
            There is an array with some numbers. All numbers are equal except for one. Try to find it!
                findUniq([ 1, 1, 1, 2, 1, 1 ]) === 2
                findUniq([ 0, 0, 0.55, 0, 0 ]) === 0.55
            It’s guaranteed that array contains at least 3 numbers.       
        Rešení:
            Firt we create a hasmap containg the count of each element.
            Then we populate the hashmap by looping over the numbers array,
            and incrementing the count of the number if its in there already
            or we add it if its not in there.Then we find the number which ¨
            appeared only once and return it.
            Time Complexity: O(n)
                In the first loop we are doing constant time operation,
                adding to the hashmap for example. The second loop just
                iterates over the hashmap. So the time complexity scales
                with the n size input of the numbers array.
    */
    public static int GetUnique(IEnumerable<int> numbers)
    {
        Dictionary<int, int> counts = new();

        foreach (int num in numbers)
        {
            if (counts.ContainsKey(num))
            {
                counts[num]++;
            }
            else
            {
                counts[num] = 1;
            }
        }

        foreach (var pair in counts)
        {
            if (pair.Value == 1)
                return pair.Key;
        }

        return 0;
    }
}
