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

class MakeAnagram {

    // Complete the makeAnagram function below.
    static int makeAnagram(string a, string b) {
        var dict_a = new Dictionary<char, int>();
        var dict_b = new Dictionary<char, int>();
        int result = 0;

        foreach(var i in a)
        {
            
            if(dict_a.ContainsKey(i))
            {
                dict_a[i] += 1;
            }
            else
            {
                dict_a.Add(i, 1);
            }
        }

        foreach(var i in b)
        {
            if(dict_b.ContainsKey(i))
            {
                dict_b[i] += 1;
            }
            else
            {
                dict_b.Add(i, 1);
            }
        }

        foreach (var key in dict_a.Keys)
        {
            // Console.WriteLine(kv.Key + kv.Value);
            if(dict_b.ContainsKey(key))
            {
                result += Math.Abs(dict_b[key]-dict_a[key]);
            }
            else
            {
                result += dict_a[key];
            }
        }

        foreach (var key in dict_b.Keys)
        {
            if(!dict_a.ContainsKey(key))
            {
                result += dict_b[key];
            }
        }

        return result;
    }

    // static void Main(string[] args) {

    //     string a = "cde";

    //     string b = "aec";

    //     int res = makeAnagram(a, b);
    //     Console.WriteLine(res);
    // }
}
