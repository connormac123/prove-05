/**
 * CSE212 
 * (c) BYU-Idaho
 * 01-Teach - Problem 1
 * 
 * It is a violation of BYU-Idaho Honor Code to post or share this code with others or 
 * to post it online.  Storage into a personal and private repository (e.g. private
 * GitHub repository, unshared Google Drive folder) is acceptable.
 */
public class UniqueLetters {

    /// <summary>
    /// Create a list of all divisors for a number including 1
    /// and excluding the number itself.  Modulo will be used
    /// to test divisibility.
    /// </summary>
    /// <param name="number">The number to find the divisor</param>
    /// <returns>fixed array of divisors</returns>

    private bool AllLettersAreUnique(string text) {
        for (int i = 0; i < text.Length; ++i) {
            for (int j = 0; j < text.Length; ++j) {
                if (i != j) {
                    if (text[i] == text[j]) {
                        return false;
                    }
                }
            }
        }
        return true;
    }

    /// <summary>
    /// Entry point for the Divisors class
    /// </summary>
    public void run() {
        string test1 = "abcdefghjiklmnopqrstuvwxyz"; // Expect True because all letters unique
        print(AllLettersAreUnique(test1));

        string test2 = "abcdefghjiklanopqrstuvwxyz"; // Expect False because 'a' is repeated
        print(AllLettersAreUnique(test2));

        string test3 = ""; // Expect True because its an empty string
        print(AllLettersAreUnique(test3));
    }

    private void print(bool value) {
        Console.WriteLine(value);
    }
}