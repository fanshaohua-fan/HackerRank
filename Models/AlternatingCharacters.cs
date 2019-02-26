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

class AlternatingCharacters {

    // Complete the alternatingCharacters function below.
    static int alternatingCharacters(string s) {
        var t = s[0];
        var result = 0;

        foreach(var c in s.Substring(1))
        {
            if(c == t)
            {
                result++;
            }
            else
            {
                t = c;
            }
        }

        return result;
    }

    // static void Main(string[] args) {
    //     TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

    //     int q = Convert.ToInt32(Console.ReadLine());

    //     for (int qItr = 0; qItr < q; qItr++) {
    //         string s = Console.ReadLine();

    //         int result = alternatingCharacters(s);

    //         textWriter.WriteLine(result);
    //     }

    //     textWriter.Flush();
    //     textWriter.Close();
    // }
}
