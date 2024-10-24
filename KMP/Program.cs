


using System;
using System.Collections.Generic;
using System.IO;
class KMP {
   
    void computeLPSArray(string pat, int M, int[] lps) {

        int len = 0;

        lps[0] = 0;

        int i = 1;
        while (i < M) {
            if (pat[i] == pat[len]) {
                len++;
                lps[i] = len;
                i++;
            } else {
                if (len != 0) {
                    len = lps[len - 1];
                } else {
                    lps[i] = 0;
                    i++;
                }
            }
        }
    }

    List<int> KMPSearch(string pat, string txt) {
        int M = pat.Length;
        int N = txt.Length;

       
        int[] lps = new int[M];
        List<int> result = new List<int>();

      
        computeLPSArray(pat, M, lps);

        int i = 0; 
        int j = 0; 
        while ((N - i) >= (M - j)) {
            if (pat[j] == txt[i]) {
                j++;
                i++;
            }

            if (j == M) {
                result.Add(i - j );
                j = lps[j - 1];
            } else if (i < N && pat[j] != txt[i]) {
                if (j != 0) {
                    j = lps[j - 1];
                } else {
                    i = i + 1;
                }
            }
        }

       
        return result;
    }

    static void printIndexes(List<int> results)
    {
        if (results.Count == 0)
        {
            Console.WriteLine("Pattern Not Found");
        }
        else
        {
            Console.WriteLine("Pattern found at index " + string.Join(", ", results));
        }
    }
    
   
    static void Main(string [] args)
    {
        
        if (args.Length != 2)
        {
            Console.WriteLine("Valid number of arguments! Usage: <pattern> <filename>");
            return;
        }
        string pattern = args[0];
        string text = args[1];

        string txt = File.ReadAllText(text);
       
        KMP kmp = new KMP();
        List<int> result = kmp.KMPSearch(pattern, txt);
        printIndexes(result);

       
        
    }
}
