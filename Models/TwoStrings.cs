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

class TwoStrings {

    // Complete the twoStrings function below.
    static string twoStrings(string s1, string s2) {
        var dict1 = new Dictionary<char, int>();
        var dict2 = new Dictionary<char, int>();

        foreach(var c in s1)
        {
            if(!dict1.ContainsKey(c))
            {
                dict1.Add(c, 1);
            }
        }

        foreach(var c in s2)
        {
            if(!dict2.ContainsKey(c))
            {
                dict2.Add(c, 1);
            }
        }

        foreach(var key in dict1.Keys)
        {
            if(dict2.ContainsKey(key))
            {
                return "YES";
            }
        }

        return "NO";
    }

}
