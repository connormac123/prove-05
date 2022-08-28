/**
 * CSE212 
 * (c) BYU-Idaho
 * 01-Teach - Problem 1
 * 
 * It is a violation of BYU-Idaho Honor Code to post or share this code with others or 
 * to post it online.  Storage into a personal and private repository (e.g. private
 * GitHub repository, unshared Google Drive folder) is acceptable.
 */
public class DisplaySums {

    /// <summary>
    /// Display pairs of numbers (no duplicates should be displayed) that sum to 
    /// 10 using a set in O(n) time.  We are assuming that there are no duplicates 
    /// in the list. This function should print the pairs.
    /// </summary>
    /// <param name="numbers">An array of numbers to find pairs in</param>
    private void PrintSums(int[] numbers) {
        
    }

    /// <summary>
    /// Entry point for the DisplaySums class
    /// </summary>
    public void run() {
        PrintSums(new int[]{1, 2, 3, 4, 5, 6, 7, 8, 9, 10});
        // Should show something like (order does not matter):
        // 6 4
        // 7 3
        // 8 2
        // 9 1 

        print("===========");
        PrintSums(new int[]{-20, -15, -10, -5, 0, 5, 10, 15, 20});
        // Should show something like (order does not matter):
        // 10 0
        // 15 -5
        // 20 -10

        print("===========");
        PrintSums(new int[]{5, 11, 2, -4, 6, 8, -1});
        // Should show something like (order does not matter):
        // 8 2
        // -1 11
    }

    private void print(string value) {
        Console.WriteLine(value);
    }
}