using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

// class Data{
//     public char c;
//     public int i;
// }

class CommonChild {

    // Complete the commonChild function below.
    static int commonChild(string s1, string s2) {
        /* 
        int result = 0;
        int pA = 0;
        int pB = 0;
        
        var resultList = new List<char>();

        for(var i=0; i<s1.Length; i++)
        {
            var t1 = s1.Substring(pA, i + 1 - pA);
            var t2 = s2.Substring(pB, i + 1 - pB);

            Console.WriteLine(t1 + "-" + s2[i]);
            Console.WriteLine(t2 + "-" + s1[i]);

            if(s2[i] == s1[i])
            {
                result++;
                pB = i + 1;
                pA = i + 1;
                resultList.Add(s1[i]);
            }
            else
            {
                if(t1.IndexOf(s2[i]) >= 0)
                {
                    result++;
                    pB = i + 1;
                    pA += t1.IndexOf(s2[i]) + 1;
                    resultList.Add(s2[i]);
                }
                
                if(t2.IndexOf(s1[i]) >= 0)
                {
                    result++;
                    pA = i + 1;
                    pB += t2.IndexOf(s1[i]) + 1;
                    resultList.Add(s1[i]);
                }
            }
        }

        return result;

        */

        var results = new List<int>();
        var maxLen = 0;

        foreach(var c in s1)
        {
            var index = s2.IndexOf(c);

            while(results.Contains(index))
            {
                index = s2.IndexOf(c, index + 1);
            }

            if(index >= 0)
            {
                Console.WriteLine(c + "-" + index);
                var j=0;
                for(; j<results.Count; j++)
                {
                    if(results[j] >= index)
                    {
                        results[j] = index;
                        break;
                    }
                }

                if(j == results.Count)
                {
                    results.Add(index);
                }
            }
        }


        return maxLen = results.Count;
    }

    // static void Main(string[] args) {

    //     string s1 = "SHINCHANHA";
    //     string s2 = "NOHARAAAHA";

    //     // int a = "FG".IndexOf('G');

    //     int result = commonChild(s1, s2);
    //     Console.WriteLine(result);

    //     s1 = "HARRY";
    //     s2 = "SALLY";
    //     result = commonChild(s1, s2);
    //     Console.WriteLine(result);

    //     s1 = "ABCDEF";
    //     s2 = "FBDAMN";
    //     result = commonChild(s1, s2);
    //     Console.WriteLine(result);

    //     s1 = "SHINCHAN";
    //     s2 = "NOHARAAA";
    //     result = commonChild(s1, s2);
    //     Console.WriteLine(result);

    //     s1 = "WEWOUCUIDGCGTRMEZEPXZFEJWISRSBBSYXAYDFEJJDLEBVHHKS";
    //     s2 = "FDAGCXGKCTKWNECHMRXZWMLRYUCOCZHJRRJBOAJOQJZZVUYXIC";
    //     result = commonChild(s1, s2);
    //     Console.WriteLine(result);

    // }
}
