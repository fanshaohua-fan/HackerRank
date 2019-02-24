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

class Solution {

    // Complete the sockMerchant function below.
    static int sockMerchant(int n, int[] ar) {
        var d = new Dictionary<int,int> ();
        foreach (var i in ar)
        {
            if(d.ContainsKey(i))  
            {  
                int v = d[i];
                d[i] = v + 1;
            }
            else
            {
                d.Add(i, 1);
            }
        }

        int result = 0;
        foreach (KeyValuePair<int, int> kvp in d)  
        {  
            result += kvp.Value / 2;
        } 

        return result;
    }

    static void Main(string[] args) {
        // TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        // int n = Convert.ToInt32(Console.ReadLine());

        // int[] ar = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), arTemp => Convert.ToInt32(arTemp))
        // ;
        // int result = sockMerchant(n, ar);

        // textWriter.WriteLine(result);

        // textWriter.Flush();
        // textWriter.Close();

        String s = "abcdefg";
        System.Console.WriteLine(s.Substring(0,2));

        long n = 1000000000000;
        int i = (int)(n % 1);
        System.Console.WriteLine(i);

    }
}
