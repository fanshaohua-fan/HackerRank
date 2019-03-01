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
        // var n = arr.Length;
        // int minIdx = 0;
        // int swap = 0;
        // for (var i = 0; i < n - 1; i++)
        // {
        //     minIdx = i;
        //     for (var j = i + 1; j < n; j++)
        //     {
        //         if(arr[minIdx] > arr[j])
        //         {
        //             minIdx = j;
        //         }
        //     }

        //     if(minIdx != i)
        //     {
        //         var t = arr[i];
        //         arr[i] = arr[minIdx];
        //         arr[minIdx] = t;
        //         swap++;
        //     }
        // }
        // return swap;


        int n = arr.Length;
        var m = new Dictionary<int, int>();
        for (int i = 0; i < n; i++) {
            m.Add(arr[i], i);
        }
        Array.Sort(arr);
        for (int i = 0; i < n; i++) {
            arr[i] = m[arr[i]];
        }
        m = null;
        int swaps = 0;
        for (int i = 0; i < n; i++) {
            int val = arr[i];
            if (val < 0) continue;
            while (val != i) {
                int new_val = arr[val];
                arr[val] = -1;
                val = new_val;
                swaps++;
            }
            arr[i] = -1;
        }
        return swaps;
    }

    static void Main(string[] args) {

        int[] arr = Array.ConvertAll("1 3 5 2 4 6 7".Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        int res = minimumSwaps(arr);
        Console.WriteLine(res);
    }
}
