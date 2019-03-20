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

class Replace {
    static void Main(string[] args) {
        string s = "fashaohua_@abc.nl";
        string replaced = s.Replace("_@", "@");

        Console.WriteLine(replaced);

        var cur = DateTime.Now.ToString("yyyy-MM-ddTHH\\:mm\\:ss.fffZ");
        Console.WriteLine(cur);
        Console.ReadKey();
    }

}
