using System.Text.RegularExpressions;

namespace Algorithms;

public class MostFrequentWordInTextKata
{
    public static List<string> Top3(string s)
    {
        var matches = Regex.Matches(s, @"([A-Za-z][A-Za-z']*)");
        var queryResult = matches.Select(x => x.Value.ToLower())
                                 .GroupBy(x => x)
                                 .Select(x => new { Key = x.Key, Count = x.Count() })
                                 .OrderByDescending(x => x.Count)
                                 .Take(3)
                                 .Select(x => x.Key)
                                 .ToList();

        // Your code here
        return queryResult;
    }
}
