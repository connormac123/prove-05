namespace prove_05;

/**
 * CSE212 
 * (c) BYU-Idaho
 * 05-Prove - Problem 1
 * 
 * It is a violation of BYU-Idaho Honor Code to post or share this code with others or 
 * to post it online.  Storage into a personal and private repository (e.g. private
 * GitHub repository, unshared Google Drive folder) is acceptable.
 */
public static class SetOperations {
    public static void Run() {
        var s1 = new HashSet<int>(new[]{1,2,3,4,5});
        var s2 = new HashSet<int>(new[]{4,5,6,7,8});
        Console.WriteLine(Intersection(s1,s2).AsString());  // Should show {4, 5}
        Console.WriteLine(Union(s1,s2).AsString()); // Should show {1, 2, 3, 4, 5, 6, 7, 8}

        s1 = new HashSet<int>(new[]{1,2,3,4,5});
        s2 = new HashSet<int>(new[]{6,7,8,9,10});
        Console.WriteLine(Intersection(s1,s2).AsString());  // Should show an empty set
        Console.WriteLine(Union(s1,s2).AsString()); // Should show {1, 2, 3, 4, 5, 6, 7, 8, 9, 10}
    }

    /// <summary>
    /// Performs a set intersection operation.
    /// </summary>
    /// <param name="set1">A set of integers</param>
    /// <param name="set2">A set of integers</param>
    private static HashSet<int> Intersection(HashSet<int> set1, HashSet<int> set2) {
        var result = new HashSet<int>();
        foreach(var number in set1) {
            if (set2.Contains(number)) {
                result.Add(number);
            }
        }
        return result;
    }

    /// <summary>
    /// Performs a set union operation.
    /// </summary>
    /// <param name="set1">A set of integers</param>
    /// <param name="set2">A set of integers</param>
    private static HashSet<int> Union(HashSet<int> set1, HashSet<int> set2) {
        var result = new HashSet<int>();
        foreach(var number in set1) {
            result.Add(number);
        }
        foreach(var number in set2) {
            result.Add(number);
        }
        return result;
    }
}