/// You are given a string S, and you have to find all the amazing substrings of S.
/// Amazing Substring is one that starts with a vowel (a, e, i, o, u, A, E, I, O, U).
/// https://www.interviewbit.com/problems/amazing-subarrays/

using System;
using System.Collections.Generic;
using System.Linq;

namespace AmazingSubstring
{


    class Program
    {
    public static int solve(string A) {
        int count = 0;
        Char[] vowels = new Char[] {'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U'};
        var substrings = new HashSet<string>();

        if (A == null)
            return count;

        for (int ii = 0; ii < A.Length; ++ii)
        {
            if (vowels.Contains(A[ii]))
            {
//                int n = (A.Length - ii);
//                count += n;
                for (int jj = ii; jj < A.Length; ++jj)
                {
                    substrings.Add(A.Substring(ii,jj-ii));
                }
            }
        }
        count = substrings.Count;

        return count;
    }        
    static void Main(string[] args)
        {
            Console.WriteLine("Checking # of substrings !");

            string test = new string(
//"ABEc"
// ""
//"B"
//"A"
//";A;"
//"dfgdgda"
//"AbAb"
"pGpEusuCSWEaPOJmamlFAnIBgAJGtcJaMPFTLfUfkQKXeymydQsdWCTyEFjFgbSmknAmKYFHopWceEyCSumTyAFwhrLqQXbWnXSn" //expect 1244

//"AzZGBauYuTknYjjWEEbLvqMQwnoSgXKBdHKEVpeoxYNNtBfrxQrPauttMzjKFayKwMeuChjzCocgAHfAmPCatOqarzLuabyTnxoheeocVshfERNssVPfRyPmwvOVGbzNAuvryYNWwIeyZLMlLbkcFFJRHjEIgIwOThRJJFpLbunVrbhAYsMtdsKslLAGElwrZjvZweIytMpPEYVmktQeNleNROcTjrNxXeHvOMMTMfqZHTUjetojHFzZwOekfAILYISANxeJFRNgeZDKoOTddXqxduPIjGXsRSSkgIqKMeSqlQwAKtdrkvHLgmKleNAPEztGMPmZzUuCImLAhzUnXmsVzFvJUTeIKleuRnMPNAPWJYAZLXgzTBPmkXVShbBSlIAJSeFgvRFvcoqfVFgHUefxUxuYFCfUxbxlOslUhYRFXKmMmqDIQhhfXyGqUwGMSYeLLpEsKAhvFUzavDCOUgtmmNMnsvfmCdPWuWIjuUfZCBTrWnaDopbqXcjzSqRMpQWIBNnMcOQZjDkjPkxsuwENYQyjgSHFJrgSLnwbEInBfdeIfBbVuZZbBrblJgKHOmLZACLQkSRxxQJeUMPIQutraxFtrRcSeqAejOTSqaFGglQOoWPkcNOnLIgfclWNtjGQRVMlqCPUnUlOLbHfkzUyNAmTsswWtZjIGUBrLmRmstHgVcRUgWdQTCEPRzjPVTMJRJocYHftwoRzOSyQexjmceRHdqFdgNuGmGTUdXQaNwKmvOUzZPzGCBVcbVLgMoQrESbpVGteVVntOwEWxXsZnSAoIfBSsWVhDFBuDTkcrnsPdmmSHymouxHlcgtjgKUAPznxsIRUjDFsrjadJjEtPaWTVBHpatqYeSgrpWJDOGfgIGQPcTIXVsCVyCfKMpcXWGkvwuRuTmvCbNMLeUkZrEpYZdlKAgFELfwCCbZCYBcXhfUrsIHfdwhYyxHKAMYMERwlyRtxObDoxBhjXmynYkmkYZrkzlCuvrhW"
            );
            Console.WriteLine (test + " : " + solve(test));
        }
    }
}
