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

class FlippingBits {

    // Complete the flippingBits function below.
    static long flippingBits(long n) {
        var bits = Convert.ToString(n, 2);
        var newBits = "";
        foreach(var c in bits)
        {
            if(c == '0')
            {
                newBits += "1";
            }
            else
            {
                newBits += "0";
            }
        }

        var a = 32 - newBits.Length;
        for(var i = 0; i < a; i++)
        {
            newBits = "1" + newBits;
        }

        return Convert.ToInt64(newBits, 2);
    }

    // static void Main(string[] args) {
    //     long n = Convert.ToInt64("1");

    //     long result = flippingBits(n);

    // }
}
