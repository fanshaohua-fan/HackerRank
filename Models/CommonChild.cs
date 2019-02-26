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
        var dict = new Dictionary<char, int>();
        var l = new List<int>();
        var maxLen = 0;

        foreach(var c in s1)
        {
            var start = dict.ContainsKey(c) ? dict[c] : 0;
            var i = s2.IndexOf(c, start);
            if(i >= 0)
            {
                Console.WriteLine(c + "-" + i);
                l.Add(i);

                if(dict.ContainsKey(c))
                {
                    dict[c] = i;
                }
                else
                {
                    dict.Add(c, i);
                }
            }
        }

        var count = 1;
        for(var i = 0; i < l.Count - 1; i++)
        {
            Console.WriteLine(i + "-" + l[i]);
            if(l[i] < l[i+1])
            {
                count++;
                if(count > maxLen)
                {
                    maxLen = count;
                }
            }
            else
            {
                count = 1;
            }
        }

        return maxLen;
    }

    static void Main(string[] args) {

        string s1 = "ABCDEFA";

        string s2 = "FBDAMN";

        int result = commonChild(s1, s2);

        Console.WriteLine(result);

    }
}
