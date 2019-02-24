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

class JumpingOnClouds {

    // Complete the jumpingOnClouds function below.
    static int jumpingOnClouds(int[] c) {
        int steps = 0;
        
        for(var i = 0; i < c.Length - 1; i++)
        {
            if(i < c.Length - 2 && c[i+2] == 0)
            {
                i++;
            }
            steps += 1;
        }

        return steps;
    }
}
