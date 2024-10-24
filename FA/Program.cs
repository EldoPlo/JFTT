using System;
using System.IO;  

class FA
{
    public static int NO_OF_CHARS = 256;

    public static int getNextState(char[] pat, int M, int state, int x)
    {
        if (state < M && (char)x == pat[state])
        {
            return state + 1;
        }

        int ns, i;
        for (ns = state; ns > 0; ns--)
        {
            if (pat[ns - 1] == (char)x)
            {
                for (i = 0; i < ns - 1; i++)
                {
                    if (pat[i] != pat[state - ns + 1 + i])
                    {
                        break;
                    }
                }
                if (i == ns - 1)
                {
                    return ns;
                }
            }
        }
ababab abab
        return 0;
    }

    public static void computeTF(char[] pat, int M, int[][] TF)
    {
        int state, x;
        for (state = 0; state <= M; ++state)
        {
            for (x = 0; x < NO_OF_CHARS; ++x)
            {
                TF[state][x] = getNextState(pat, M, state, x);
            }
        }
    }

    public static void search(char[] pat, char[] txt)
    {
        int M = pat.Length;
        int N = txt.Length;

        int[][] TF = RectangularArrays.ReturnRectangularIntArray(M + 1, NO_OF_CHARS);

        computeTF(pat, M, TF);
        bool patternFound = false;
        int i, state = 0;
        for (i = 0; i < N; i++)
        {
            state = TF[state][txt[i]];
            if (state == M)
            {
                Console.WriteLine("Pattern found at index " + (i - M + 1));
                patternFound = true;
            }
            
            
        }

        if (patternFound == false)
        {
            Console.WriteLine("Pattern Not Found");
        }
    }

    public static class RectangularArrays
    {
        public static int[][] ReturnRectangularIntArray(int size1, int size2)
        {
            int[][] newArray = new int[size1][];
            for (int array1 = 0; array1 < size1; array1++)
            {
                newArray[array1] = new int[size2];
            }

            return newArray;
        }
    }

    
    public static void Main(string[] args)
    {
        if (args.Length < 2)
        {
            Console.WriteLine("Usage: <pattern> <filename>");
            return;
        }

        string pattern = args[0];          
        string filename = args[1];        

        try
        {
           
            string text = File.ReadAllText(filename);

   
            search(pattern.ToCharArray(), text.ToCharArray());
        }
        catch (Exception e)
        {
            Console.WriteLine("Error: " + e.Message);
        }
    }
}
