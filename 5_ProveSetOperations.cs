/**
 * CSE212 
 * (c) BYU-Idaho
 * 05-Prove - Problem 1
 * 
 * It is a violation of BYU-Idaho Honor Code to post or share this code with others or 
 * to post it online.  Storage into a personal and private repository (e.g. private
 * GitHub repository, unshared Google Drive folder) is acceptable.
 */
public class ProveSetOperations {

    /// <summary>
    /// Performs a set intersection operation.
    /// </summary>
    /// <param name="set1">A set of integers</param>
    /// <param name="set2">A set of integers</param>
    private HashSet<int> Intersection(HashSet<int> set1, HashSet<int> set2) {
        HashSet<int> result = new HashSet<int>();
        foreach(int number in set1) {
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
    private HashSet<int> Union(HashSet<int> set1, HashSet<int> set2) {
        HashSet<int> result = new HashSet<int>();
        foreach(int number in set1) {
            result.Add(number);
        }
        foreach(int number in set2) {
            result.Add(number);
        }
        return result;
    }

    /// <summary>
    /// Entry point for the DisplaySums class
    /// </summary>
    public void run() {
        HashSet<int> s1 = new HashSet<int>(new int[]{1,2,3,4,5});
        HashSet<int> s2 = new HashSet<int>(new int[]{4,5,6,7,8});
        print(Intersection(s1,s2));  // Should show {4, 5}
        print(Union(s1,s2)); // Should show {1, 2, 3, 4, 5, 6, 7, 8}

        s1 = new HashSet<int>(new int[]{1,2,3,4,5});
        s2 = new HashSet<int>(new int[]{6,7,8,9,10});
        print(Intersection(s1,s2));  // Should show an empty set
        print(Union(s1,s2)); // Should show {1, 2, 3, 4, 5, 6, 7, 8, 9, 10}
    }

    private void print(HashSet<int> value) {
        Console.WriteLine("<Set>{" + String.Join(", ", value) + "}");
    }
}