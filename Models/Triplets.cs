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

class Triplets {

    // Complete the triplets function below.
    static long triplets(int[] a, int[] b, int[] c) {
        long result = 0;

        var dict_b = new Dictionary<int, int>();
        var dict_c = new Dictionary<int, int>();

        var count_a = new Dictionary<int, long>();
        var count_b = new Dictionary<int, long>();

        a.Distinct();
        b.Distinct();
        c.Distinct();
        Array.Sort(a);
        Array.Sort(b);
        Array.Sort(c);

        var len_b = b.Length;

        // for(var i = 0; i < len_b; i++)
        // {
        //     dict_b.Add(c[i], len_b - i);
        // }

        for(var i = 0; i < c.Length; i++)
        {
            dict_c.Add(c[i], i+1);
        }

        foreach(var i in b)
        {
            var found = false;
            var initial = i;
            while(found == false)
            {
                if(dict_c.ContainsKey(initial)){
                    count_b.Add(i, dict_c[i]);
                    found = true;
                }
                else
                {
                    initial++;
                }
            }
        }

        foreach(var i in a)
        {
            var found = false;
            var initial = i;
            while(found == false)
            {
                if(dict_b.ContainsKey(initial)){
                    count_a.Add(i, count_b[i]);
                    found = true;
                }
                else
                {
                    initial++;
                }
            }
        }
        return result;
    }

    // static void Main(string[] args) {
    //     TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

    //     string[] lenaLenbLenc = Console.ReadLine().Split(' ');

    //     int lena = Convert.ToInt32(lenaLenbLenc[0]);

    //     int lenb = Convert.ToInt32(lenaLenbLenc[1]);

    //     int lenc = Convert.ToInt32(lenaLenbLenc[2]);

    //     int[] arra = Array.ConvertAll(Console.ReadLine().Split(' '), arraTemp => Convert.ToInt32(arraTemp))
    //     ;

    //     int[] arrb = Array.ConvertAll(Console.ReadLine().Split(' '), arrbTemp => Convert.ToInt32(arrbTemp))
    //     ;

    //     int[] arrc = Array.ConvertAll(Console.ReadLine().Split(' '), arrcTemp => Convert.ToInt32(arrcTemp))
    //     ;
    //     long ans = triplets(arra, arrb, arrc);

    //     textWriter.WriteLine(ans);

    //     textWriter.Flush();
    //     textWriter.Close();
    // }
}
