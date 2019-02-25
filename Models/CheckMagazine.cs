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

class CheckMagazine {

    // Complete the checkMagazine function below.
    static void checkMagazine(string[] magazine, string[] note) {
        var dict = new Dictionary<string,int> ();

        foreach(var s in magazine)
        {
            if(!dict.ContainsKey(s))
            {
                dict.Add(s, 1);
            }
            else
            {
                dict[s] += 1; 
            }
        }

        foreach(var s in note)
        {
            if(!dict.ContainsKey(s))
            {
                System.Console.WriteLine("No");
                return;
            }
            else
            {
                dict[s] -= 1;
                if(dict[s] < 0)
                {
                    System.Console.WriteLine("No");
                    return;
                }
            }
        }

        System.Console.WriteLine("Yes");
    }

    // static void Main(string[] args) {
    //     string[] mn = Console.ReadLine().Split(' ');

    //     int m = Convert.ToInt32(mn[0]);

    //     int n = Convert.ToInt32(mn[1]);

    //     string[] magazine = Console.ReadLine().Split(' ');

    //     string[] note = Console.ReadLine().Split(' ');

    //     checkMagazine(magazine, note);
    // }
}
