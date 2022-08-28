class ProgramProve5 {
    public static void main(string[] args) {
        Console.WriteLine("Problem 1");
        try {
            new ProveSetOperations().run();
        }
        catch (Exception ignore) {
        }
        Console.WriteLine("Problem 2");
        try {
            new ProveFindPairs().run();
        }
        catch (Exception ignore) {
        }
    }
}
