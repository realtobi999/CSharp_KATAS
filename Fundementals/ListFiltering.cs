using System.Collections;
using System.Collections.Generic;
using NUnit.Framework.Interfaces;

public class ListFilterer
{
    /*
        Zadání:
            In this kata you will create a function that takes a list 
            of non-negative integers and strings and returns a new list 
            with the strings filtered out.
        Řešení:
            We create the result list and then loop over the original list
            and add only numbers that are bigger or equal to zero
    */
   public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
   {
        var result = new List<int>();

        foreach(object value in listOfItems)
        {
            if (value is int intValue && intValue >= 0) {
                result.Add(intValue);
            }
        }

        return result;
   }
}