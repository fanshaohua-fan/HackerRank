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

class MaxSubsetSum {
    // static int maxN;

    // Complete the maxSubsetSum function below.
    static int maxSubsetSum(int[] arr) {
        int result;

        var n = arr.Length - 1;
        if(n == 2){
            
            result = arr[0] + arr[2];
        }
        else{
            int value = arr[n];
                        
            Array.Resize(ref arr, arr.Length - 1);
            if(value > 0)
            {
                int maxN = arr[0];
                for(var i = 1; i < arr.Length - 1; i++)
                {
                    if(i > maxN)
                    {
                        maxN = i;
                    }
                }

                var sum = maxSubsetSum(arr);
                result = (maxN + value > sum ? maxN + value: sum) ;
            }
            else
            {
                result = maxSubsetSum(arr);
            }

        }

        return result;
    }

    static void Main(string[] args) {

        int[] arr = Array.ConvertAll("3 7 4 6 5".Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        // int[] arr = Array.ConvertAll("2 1 5 8 4".Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        int res = maxSubsetSum(arr);
        Console.WriteLine(res);
    }
}
