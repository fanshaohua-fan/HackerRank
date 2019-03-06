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

class Abbreviation {

    // Complete the abbreviation function below.
    static string abbreviation(string a, string b) {
        if(a == "" && b != "")
        {
            return "NO";
        }
        else if(a == "" && b == "")
        {
            return "YES";
        }
        else if(a != "" && b == "")
        {
            foreach(var c in a){
                if(Char.IsUpper(c))
                {
                    return "NO";
                }
            }

            return "YES";
        }

        int lenA = a.Length;
        int lenB = b.Length;
        char c_a = a[lenA - 1];
        char c_b = b[lenB - 1];

        if(Char.IsUpper(c_a))
        {
            if(c_a != c_b)
            {
                return "NO";
            }
            else
            {
                return abbreviation(a.Substring(0, lenA - 1), b.Substring(0, lenB - 1));
            }
        }
        else
        {
            var upperA = Char.ToUpper(c_a);
            if(upperA != c_b)
            {
                return abbreviation(a.Substring(0, lenA - 1), b);
            }
            else
            {
                var result1 = abbreviation(a.Substring(0, lenA - 1), b.Substring(0, lenB - 1));
                var result2 = abbreviation(a.Substring(0, lenA - 1), b);
                if(result1 == "NO" && result2 == "NO")
                {
                    return "NO";
                }
                else
                {
                    return "YES";
                }
            }
        }

    }

    // static void Main(string[] args) {
    //     TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

    //     int q = Convert.ToInt32(Console.ReadLine());

    //     for (int qItr = 0; qItr < q; qItr++) {
    //         string a = Console.ReadLine();

    //         string b = Console.ReadLine();

    //         string result = abbreviation(a, b);

    //         textWriter.WriteLine(result);
    //     }

    //     textWriter.Flush();
    //     textWriter.Close();
    // }
}
