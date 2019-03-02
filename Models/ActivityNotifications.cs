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

class ActivityNotifications {

    static int median_2(List<int> list)
    {
        int n = list.Count();
        int index = n / 2;
        list.Sort();

        if(n % 2 == 1)
        {
            return 2 * list[index];
        }
        else
        {
            return list[index - 1] + list[index];
        }
    }

    // Complete the activityNotifications function below.
    static int activityNotifications(int[] expenditure, int d) {
        var exp = new List<int>(expenditure);
        var n = exp.Count();
        var count = 0;

        if(n <= d)
        {
            return 0;
        }

        for(var i = d; i < n; i++)
        {
            var tmp = exp.Skip(i - d).Take(d).ToList();
            if(exp[i] >= median_2(tmp))
            {
                count++;
            }
        }

        return count;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] nd = Console.ReadLine().Split(' ');

        int n = Convert.ToInt32(nd[0]);

        int d = Convert.ToInt32(nd[1]);

        int[] expenditure = Array.ConvertAll(Console.ReadLine().Split(' '), expenditureTemp => Convert.ToInt32(expenditureTemp))
        ;
        int result = activityNotifications(expenditure, d);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
