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

class MaximumToys {

    // Complete the maximumToys function below.
    static int maximumToys(int[] prices, int k) {
        int result = 0;
        Array.Sort(prices);

        foreach(var i in prices)
        {
            k -= i;
            if(k >= 0)
            {
                result++;
            }
            else
            {
                break;
            }
        }

        return result;
    }

    // static void Main(string[] args) {

    //     int k = 50;

    //     int[] prices = Array.ConvertAll("1 12 5 111 200 1000 10".Split(' '), pricesTemp => Convert.ToInt32(pricesTemp))
    //     ;
    //     int result = maximumToys(prices, k);

    //     System.Console.WriteLine(result);

    // }
}
