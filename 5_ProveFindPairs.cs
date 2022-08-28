/**
 * CSE212 
 * (c) BYU-Idaho
 * 05-Prove - Problem 2
 * 
 * It is a violation of BYU-Idaho Honor Code to post or share this code with others or 
 * to post it online.  Storage into a personal and private repository (e.g. private
 * GitHub repository, unshared Google Drive folder) is acceptable.
 */
public class ProveFindPairs {

    /// <summary>
    /// The words parameter contains a list of two character 
    /// words (lower case, no duplicates). Using sets, find an O(n) 
    /// solution for displaying all symmetric pairs of words.  
    ///
    /// For example, if words was: [am, at, ma, if, fi], we would display:
    /// am & ma
    /// if & fi
    /// The order of the display above does not matter.  'at' would not 
    /// be displayed because 'ta' is not in the list of words.
    ///
    /// As a special case, if the letters are the same (example: 'aa') then
    /// it would not match anything else (remember no the assumption above
    /// that there were no duplicates) and therefore should not be displayed.
    /// </summary>
    /// <param name="words">An array of 2-character words (lowercase, no duplicates)</param>
    private void PrintPairs(string[] words) {
        HashSet<string> seen_before = new HashSet<string>();
        foreach(string word in words) {
            string pair = $"{word[1]}{word[0]}";
            if (seen_before.Contains(pair)) {
                print($"{word} & {pair}");
            }
            else {
                seen_before.Add(word);
            }
        }
    }

    /// <summary>
    /// Entry point for the ProveFindPairs class
    /// </summary>
    public void run() {
        PrintPairs(new string[]{"am","at","ma","if","fi"});      // ma & am, fi & if
        print("=============");
        PrintPairs(new string[]{"ab", "bc", "cd", "de", "ba"});  // ba & ab
        print("=============");
        PrintPairs(new string[]{"ab","ba","ac","ad","da","ca"}); // ba & ab, da & ad, ca & ac
        print("=============");
        PrintPairs(new string[]{"ab", "ac"});                    // None
        print("=============");
        PrintPairs(new string[]{"ab", "aa", "ba"});              // ba & ab
        print("=============");
        PrintPairs(new string[]{"23","84","49","13","32","46","91","99","94","31","57","14"});
                                            // 32 & 23, 94 & 49, 31 & 13
    }

    private void print(string value) {
        Console.WriteLine(value);
    }
}