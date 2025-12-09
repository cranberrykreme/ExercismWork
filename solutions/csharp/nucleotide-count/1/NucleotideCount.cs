public static class NucleotideCount
{    
    public static IDictionary<char, int> Count(string sequence)
    {
        IDictionary<char, int> dnaDict = new Dictionary<char, int>()
        {
            {'A', 0},
            {'C', 0},
            {'G', 0},
            {'T', 0}
        };
        foreach(var letter in sequence)
        {
            if(!dnaDict.ContainsKey(letter))
            {
                throw new ArgumentException($"letter: {letter} is not part of a DNA sequence");
            }
            Console.WriteLine(letter);
            dnaDict[Char.ToUpper(letter)]++;
        }
        return dnaDict;
    }
}