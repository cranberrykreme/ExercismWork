public static class Hamming
{
    public static int Distance(string firstStrand, string secondStrand)
    {
        if(firstStrand.Length != secondStrand.Length)
            throw new ArgumentException("Both sequences must be of same length");
        var errCount = 0;
        for(int i = 0; i < firstStrand.Length; i++) 
        {
            if(firstStrand[i] != secondStrand[i])
                errCount++;
        }
        return errCount;
    }
}