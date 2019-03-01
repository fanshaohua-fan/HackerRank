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

class CountTriplets {

    // Complete the countTriplets function below.
    static long countTriplets(List<long> arr, long r) {
        var dict = new Dictionary<long, int>();
        var max = arr.Max();
        long result = 0;

        if( r == 1)
        {
            dict.Add(1, 0);
        }
        else
        {
            long cur = 1;
            while(cur <= max)
            {
                dict.Add(cur, 0);
                cur = cur * r;
            }
        }

        foreach(var l in arr)
        {
            if(dict.ContainsKey(l))
            {
                dict[l] += 1;
            }
        }

        var n = dict.Count();

        for(var i = 0; i < n - 2; i++)
        {
            var v1 = dict[(long)Math.Pow(r, i)];
            var v2 = dict[(long)Math.Pow(r, i+1)];
            var v3 = dict[(long)Math.Pow(r, i+2)];

            result += v1 * v2 * v3;
        }

        return result;
    }

    static void Main(string[] args) {

        long r = Convert.ToInt64(1);

        List<long> arr = "1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1".TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt64(arrTemp)).ToList();

        long ans = countTriplets(arr, r);

        Console.WriteLine(ans);

    }
}
