namespace prove_05;

using System;
using System.Collections.Generic;

public class SetOperations
{
    // Function to find the intersection of two sets
    public static HashSet<T> FindIntersection<T>(HashSet<T> set1, HashSet<T> set2)
    {
        // Create a new set to store the intersection result
        HashSet<T> intersection = new HashSet<T>();
        
        // Iterate through each item in the first set
        foreach (T item in set1)
        {
            // Check if the item is present in the second set
            if (set2.Contains(item))
            {
                // Add the item to the intersection set
                intersection.Add(item);
            }
        }
        
        return intersection;
    }

    // Function to find the union of two sets
    public static HashSet<T> FindUnion<T>(HashSet<T> set1, HashSet<T> set2)
    {
        // Create a new set to store the union result
        HashSet<T> union = new HashSet<T>();
        
        // Add all items from the first set to the union set
        foreach (T item in set1)
        {
            union.Add(item);
        }
        
        // Add all items from the second set to the union set
        foreach (T item in set2)
        {
            union.Add(item);
        }
        
        return union;
    }
}

public static class SetTests
{
    public static void Run()
    {
        Console.WriteLine("\n=========== PROBLEM 1 TESTS ===========");
        var s1 = new HashSet<int>(new[] { 1, 2, 3, 4, 5 });
        var s2 = new HashSet<int>(new[] { 4, 5, 6, 7, 8 });
        Console.WriteLine(Intersection(s1, s2).AsString()); // <Set>{4, 5}
        Console.WriteLine(Union(s1, s2).AsString()); // <Set>{1, 2, 3, 4, 5, 6, 7, 8}
        Console.WriteLine("---------");

        s1 = new HashSet<int>(new[] { 1, 2, 3, 4, 5 });
        s2 = new HashSet<int>(new[] { 6, 7, 8, 9, 10 });
        Console.WriteLine(Intersection(s1, s2).AsString()); // <Set>{}
        Console.WriteLine(Union(s1, s2).AsString()); // <Set>{1, 2, 3, 4, 5, 6, 7, 8, 9, 10}

        Console.WriteLine("\n=========== PROBLEM 2 TESTS ===========");
        DisplayPairs(new[] { "am", "at", "ma", "if", "fi" });
        // ma & am
        // fi & if
        Console.WriteLine("---------");
        DisplayPairs(new[] { "ab", "bc", "cd", "de", "ba" });
        // ba & ab
        Console.WriteLine("---------");
        DisplayPairs(new[] { "ab", "ba", "ac", "ad", "da", "ca" });
        // ba & ab
        // da & ad
        // ca & ac
        Console.WriteLine("---------");
        DisplayPairs(new[] { "ab", "ac" }); // No pairs displayed
        Console.WriteLine("---------");
        DisplayPairs(new[] { "ab", "aa", "ba" });
        // ba & ab
        Console.WriteLine("---------");
        DisplayPairs(new[] { "23", "84", "49", "13", "32", "46", "91", "99", "94", "31", "57", "14" });
        // 32 & 23
        // 94 & 49
        // 31 & 13
    }

    /// <summary>
    /// Performs a set intersection operation.
    /// </summary>
    /// <param name="set1">A set of integers</param>
    /// <param name="set2">A set of integers</param>
    private static HashSet<int> Intersection(HashSet<int> set1, HashSet<int> set2)
    {
        var result = new HashSet<int>();
        
        // Iterate through each item in the first set
        foreach (int item in set1)
        {
            // Check if the item is present in the second set
            if (set2.Contains(item))
            {
                // Add the item to the result set
                result.Add(item);
            }
        }

        return result;
    }

    /// <summary>
    /// Performs a set union operation.
    /// </summary>
    /// <param name="set1">A set of integers</param>
    /// <param name="set2">A set of integers</param>
    private static HashSet<int> Union(HashSet<int> set1, HashSet<int> set2)
    {
        var result = new HashSet<int>();
        
        // Add all items from the first set to the result set
        foreach (int item in set1)
        {
            result.Add(item);
        }
        
        // Add all items from the second set to the result set
        foreach (int item in set2)
        {
            result.Add(item);
        }

        return result;
    }

    /// <summary>
    /// The words parameter contains a list of two character 
    /// words (lower case, no duplicates). Using sets, find an O(n) 
    /// solution for displaying all symmetric pairs of words.  
    ///
    /// For example, if <c>words</c> was: <c>[am, at, ma, if, fi]</c>, we would display:
    /// <code>
    /// am & ma
    /// if & fi
    /// </code>
    /// The order of the display above does not matter. <c>at</c> would not 
    /// be displayed because <c>ta</c> is not in the list of words.
    ///
    /// As a special case, if the letters are the same (example: 'aa') then
    /// it would not match anything else (remember no the assumption above
    /// that there were no duplicates) and therefore should not be displayed.
    /// </summary>
    /// <param name="words">An array of 2-character words (lowercase, no duplicates)</param>
    private static void DisplayPairs(string[] words)
    {
        var wordSet = new HashSet<string>(words);

        foreach (string word in words)
        {
            char[] charArray = word.ToCharArray();
            Array.Reverse(charArray);
            string reversedWord = new string(charArray);

            if (wordSet.Contains(reversedWord) && word != reversedWord)
            {
                Console.WriteLine($"{word} & {reversedWord}");
                wordSet.Remove(word);
                wordSet.Remove(reversedWord);
            }
        }
    }

    private static string AsString(this HashSet<int> set)
    {
        return $"<Set>{{{string.Join(", ", set)}}}";
    }
}
