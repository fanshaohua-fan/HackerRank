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

class CommonChild {

    // Complete the commonChild function below.
    static int commonChild(string s1, string s2) {
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
    }

    static void Main(string[] args) {

        string s1 = "SHINCHAN";
        string s2 = "NOHARAAA";

        // int a = "FG".IndexOf('G');

        int result = commonChild(s1, s2);
        Console.WriteLine(result);

        s1 = "WEWOUCUIDGCGTRMEZEPXZFEJWISRSBBSYXAYDFEJJDLEBVHHKS";
        s2 = "FDAGCXGKCTKWNECHMRXZWMLRYUCOCZHJRRJBOAJOQJZZVUYXIC";

        result = commonChild(s1, s2);
        Console.WriteLine(result);

    }
}
