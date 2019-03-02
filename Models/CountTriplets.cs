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
            if( r == 1)
            {
                dict[1] += 1;
            }
            else
            {
                if(dict.ContainsKey(l))
                {
                    dict[l] += 1;
                }
            }
        }

        var n = dict.Count();

        if(r == 1)
        {
            long count = dict[1];
            result = count * (count - 1) * (count - 2) / (3 * 2 * 1);
        }
        else
        {
            for(var i = 0; i < n - 2; i++)
            {
                var v1 = dict[(long)Math.Pow(r, i)];
                var v2 = dict[(long)Math.Pow(r, i+1)];
                var v3 = dict[(long)Math.Pow(r, i+2)];

                result += v1 * v2 * v3;
            }
        }

        return result;
    }

    // static void Main(string[] args) {

    //     // long r = Convert.ToInt64(1);
    //     long r = Convert.ToInt64(3);

    //     // List<long> arr = "1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1".TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt64(arrTemp)).ToList();
    //     // List<long> arr = "1 2 2 4".TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt64(arrTemp)).ToList();
    //     // List<long> arr = "1 3 9 9 27 81".TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt64(arrTemp)).ToList();
    //     // List<long> arr = "1237 1237 1237 1237 1237 1237 1237 1237 1237 1237 1237 1237 1237 1237".TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt64(arrTemp)).ToList();
    //     // List<long> arr = "1 17 80 68 5 5 58 17 38 81 26 44 38 6 12 11 37 67 70 16 19 35 71 16 32 45 7 39 2 14 16 78 82 5 18 86 61 37 12 8 27 90 13 26 57 24 36 4 52 67 71 71 11 51 48 42 57 16 43 58 29 58 8 20 24 25 15 84 61 78 53 49 39 66 75 6 51 72 9 13 49 79 45 21 1 2 63 20 17 67 39 45 86 46 26 19 70 2 64 2 79 78 51 28 53 87 85 14 68 55 78 78 5 32 9 57 85 71 76 11 9 25 17 4 32 42 74 64 5 47 65 83 34 77 72 49 73 66 24 13 82 11 90 86 4 8 53 88 40 38 8 48 24 76 13 56 79 86 29 83 4 3 37 38 42 19 48 24 46 71 36 38 81 88 85 46 57 47 43 7 85 50 16 70 87".TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt64(arrTemp)).ToList();
    //     List<long> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt64(arrTemp)).ToList();

    //     long ans = countTriplets(arr, r);

    //     Console.WriteLine(ans);

    // }
}
