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

class Pairs {

    // Complete the pairs function below.
    static int pairs(int k, int[] arr) {
        Array.Sort(arr);
        // Array.Reverse(arr);
        int count = 0;

        // for(var i = 0; i < arr.Length - 1; i++)
        // {
        //     for(var j = i + 1; j < arr.Length; j++)
        //     {
        //         if(arr[i] - arr[j] == k)
        //         {
        //             count++;
        //             break;
        //         }
        //     }
        // }

        var dict = new Dictionary<int, int>();
        foreach(var i in arr)
        {
            dict.Add(i, 1);
        }

        foreach(var i in arr)
        {
            var v = i + k;
            if(dict.ContainsKey(v))
            {
                count++;
            }
        }

        return count;
    }

    // static void Main(string[] args) {

    //     string[] nk = Console.ReadLine().Split(' ');

    //     int n = Convert.ToInt32(nk[0]);

    //     int k = Convert.ToInt32(nk[1]);

    //     int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
    //     ;
    //     int result = pairs(k, arr);

    //     Console.WriteLine(result);

    // }
}
