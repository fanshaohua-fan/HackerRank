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

class Candies {

    // Complete the candies function below.
    static long candies(int n, int[] arr) {
        var dict = new Dictionary<int, int>();
        var posInc = 0;

        dict.Add(0, 1);
        for(var i = 1; i < arr.Length; i++)
        {
            if(arr[i - 1] > arr[i])
            {
                dict.Add(i, 1);
                if(dict[i - 1] == 1)
                {
                    var t = i - 1;
                    while(t >= posInc)
                    {
                        dict[t] += 1;
                        t--;
                    }

                    if(posInc != 0 && dict[posInc] > dict[posInc - 1] + 1 && dict[posInc] > dict[posInc + 1] + 1)
                    {
                        dict[posInc]--;
                    }
                }
            }
            else if(arr[i - 1] < arr[i])
            {
                dict.Add(i, dict[i - 1] + 1);
                posInc = i;
            }
            else
            {
                dict.Add(i, 1);
                posInc = i;
            }
        }

        long min = 0;
        foreach(KeyValuePair<int, int> kv in dict)
        {
            // Console.WriteLine($"{kv.Key} - {kv.Value}");
            
            min += kv.Value;

        }

        return min;
    }

    static void Main(string[] args) {

        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = new int [n];

        for (int i = 0; i < n; i++) {
            int arrItem = Convert.ToInt32(Console.ReadLine());
            arr[i] = arrItem;
        }

        long result = candies(n, arr);

        Console.WriteLine(result);

    }
}
