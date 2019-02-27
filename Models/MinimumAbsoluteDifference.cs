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

class MinimumAbsoluteDifference {

    // Complete the minimumAbsoluteDifference function below.
    static int minimumAbsoluteDifference(int[] arr) {
        Array.Sort(arr);
        int min = arr[arr.Length - 1];

        for(var i = 0; i < arr.Length - 1; i++)
        {
            var abs = Math.Abs(arr[i] - arr[i+1]);
            min = Math.Min(min, abs);
        }

        return min;
    }

}
