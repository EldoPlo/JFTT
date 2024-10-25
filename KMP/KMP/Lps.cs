namespace Lista_1.KMP;

public class Lps
{
    private int[] _lps;
    
    private Lps(int[] lps)
    {
        _lps = lps;
    }
    
    public static Lps ComputeLps(string pat) {
        var patternLength = pat.Length;
        var lps = new int[patternLength];
        var longestPfxSfxLength = 0;

        lps[0] = 0;

        var i = 1;
        while (i < patternLength) 
        {
            if (pat[i] == pat[longestPfxSfxLength]) 
            {
                longestPfxSfxLength++;
                lps[i] = longestPfxSfxLength;
                i++;
                continue;
            } 

            if (longestPfxSfxLength != 0) 
            {
                longestPfxSfxLength = lps[longestPfxSfxLength - 1];
                continue;
            } 

            lps[i] = 0; 
            i++;
        }
        
        return new Lps(lps);
    }
    
    public int GetNextPatternIndex(int patternIndex) {
        return _lps[patternIndex];
    }


}