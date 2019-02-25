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

class MinimumBribes {

    static int _count = 0;
    // Complete the minimumBribes function below.
    static void minimumBribes(int[] q) {
        if(q.Length == 1)
        {
            System.Console.WriteLine( _count);
            return;
        }

        int index = Array.IndexOf(q, q.Length);
        if(index == q.Length - 1)
        {
            Array.Resize(ref q, q.Length - 1);
        }
        else if(q.Length - index > 3)
        {
            System.Console.WriteLine("Too chaotic");
            return;
        }
        else
        {
            int t = q[index+1];
            q[index+1] = q[index];
            q[index] = t;
            _count++;
        }

        minimumBribes(q);
    }

    // static void Main(string[] args) {
    //     int t = Convert.ToInt32(Console.ReadLine());

    //     for (int tItr = 0; tItr < t; tItr++) {
    //         int n = Convert.ToInt32(Console.ReadLine());

    //         int[] q = Array.ConvertAll(Console.ReadLine().Split(' '), qTemp => Convert.ToInt32(qTemp))
    //         ;
    //         minimumBribes(q);
    //     }
    // }
}
