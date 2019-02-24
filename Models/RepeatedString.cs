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

class RepeatedString {

    // Complete the repeatedString function below.
    static long repeatedString(string s, long n) {
        long count = 0;
        int single = 0;
        
        foreach(var i in s)
        {
            if(i == 'a')
            {
                single += 1;
            }
        }

        count = single * ( n / s.Length);

        foreach(var j in s.Substring(0, (int)(n % s.Length)))
        {
            if(j == 'a')
            {
                count += 1;
            }
        }

        return count;
    }

}
