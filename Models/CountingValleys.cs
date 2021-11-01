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

class CountingValleys {

    // Complete the countingValleys function below.
    static int countingValleys(int n, string path) {
        int level = 0;
        int valleyCount = 0;

        foreach(var i in path)
        {
            if(i == 'U')
            {
                level += 1;
                // when level goes from -1 to 0
                if (level == 0)
                {
                    valleyCount += 1;
                }
            }
            else
            {
                level -= 1;
            }            
        }

        return valleyCount;
    }
}
