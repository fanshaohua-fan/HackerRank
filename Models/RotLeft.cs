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

class RotLeft {

    // Complete the rotLeft function below.
    static int[] rotLeft(int[] a, int d) {
        // var list = new List<int>(a);

        // for (var i = 0; i < d; i++)
        // {
        //     var t = list[0];
        //     list.RemoveAt(0);
        //     list.Add(t);
        // }

        // return list.ToArray();

        var q = new Queue<int>(a);
        for (var i = 0; i < d; i++)
        {
            var t = q.Dequeue();
            q.Enqueue(t);
        }

        return q.ToArray();
    }

    // static void Main(string[] args) {


    //     int d = Convert.ToInt32(4);

    //     int[] a = Array.ConvertAll("1 2 3 4 5".Split(' '), aTemp => Convert.ToInt32(aTemp))
    //     ;
    //     int[] result = rotLeft(a, d);

    // }
}
