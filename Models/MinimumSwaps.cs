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

class MinimumSwaps {

    // Complete the minimumSwaps function below.
    static int minimumSwaps(int[] arr) {
        var n = arr.Length;
        int minIdx = 0;
        int swap = 0;
        for (var i = 0; i < n - 1; i++)
        {
            minIdx = i;
            for (var j = i + 1; j < n; j++)
            {
                if(arr[minIdx] > arr[j])
                {
                    minIdx = j;
                }
            }

            if(minIdx != i)
            {
                var t = arr[i];
                arr[i] = arr[minIdx];
                arr[minIdx] = t;
                swap++;
            }
        }
        return swap;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        int res = minimumSwaps(arr);

        textWriter.WriteLine(res);

        textWriter.Flush();
        textWriter.Close();
    }
}
