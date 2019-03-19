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

class LargestRectangle {

    // Complete the largestRectangle function below.
    static long largestRectangle(int[] h) {
        var linkedList = new LinkedList<int>();
        for(var i = 0; i < h.Length - 1; i++)
        {
            var pos = i;
            var height = h[i];

            

        }

        return 0;
    }

    // static void Main(string[] args) {
    //     TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

    //     int n = Convert.ToInt32(Console.ReadLine());

    //     int[] h = Array.ConvertAll(Console.ReadLine().Split(' '), hTemp => Convert.ToInt32(hTemp))
    //     ;
    //     long result = largestRectangle(h);

    //     textWriter.WriteLine(result);

    //     textWriter.Flush();
    //     textWriter.Close();
    // }
}
