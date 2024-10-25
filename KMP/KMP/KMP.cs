namespace Lista_1.KMP;

public class Kmp
{ 
    public static SearchResult KmpSearch(string pattern, string txt) {
        var patternLength = pattern.Length;
        var txtLength = txt.Length;


        var result = new SearchResult();

        var lps = Lps.ComputeLps(pattern);  

        var textIndex = 0; 
        var patternIndex = 0; 
        while (txtLength - textIndex >= patternLength - patternIndex) 
        {
            // Characters match
            if (pattern[patternIndex] == txt[textIndex]) 
            {
                patternIndex++;
                textIndex++;
            }

            // Pattern found
            if (patternIndex == patternLength) 
            {
                result.Add(textIndex - patternIndex );
                patternIndex = lps.GetNextPatternIndex(patternIndex - 1);
                continue;
            }

            if (textIndex >= txtLength || pattern[patternIndex] == txt[textIndex])
            {
                continue;
            }
            
            if (patternIndex != 0) 
            {
                patternIndex = lps.GetNextPatternIndex(patternIndex - 1);
                continue;
            }
            
            textIndex += 1;
        }

   
        return result;
    }
}