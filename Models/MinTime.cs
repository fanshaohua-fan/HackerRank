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

class MinTime {

    // Complete the minTime function below.
    static long minTime(long[] machines, long goal) {
        long minDays = (goal * machines.Min()) / machines.Length;
        long maxDays = (goal * machines.Max()) / machines.Length;

        while(minDays < maxDays)
        {
            long days = (minDays + maxDays) / 2;
            var result = (from m in machines
                            select days / m).Sum();

            if(result >= goal)
            {
                maxDays = days;
            }
            else
            {
                minDays = days + 1;
            }
        }

        return minDays;

        // long days = 1;
        // long count = 0;
        // var dict = new Dictionary<long, long>();

        // foreach(var m in machines)
        // {
        //     if(dict.ContainsKey(m))
        //     {
        //         dict[m] += 1;
        //     }
        //     else
        //     {
        //         dict.Add(m, 1);
        //     }
        // }

        // var distinct = machines.Distinct().ToArray();
        // Array.Sort(distinct);
        // var foundLCM = false;

        // while(count < goal && !foundLCM)
        // {
        //     var n = 0;
        //     foreach(var d in distinct)
        //     {
        //         if(days % d == 0)
        //         {
        //             count += dict[d];
        //             n++;
        //         }
        //     }

        //     if(n == distinct.Length)
        //     {
        //         foundLCM = true;
        //     }

        //     days++;
        // }

        // if(foundLCM && count < goal)
        // {
        //     var LCM = days - 1;
        //     long times = goal / count;
        //     long left = goal % count;


        //     days = LCM * times + 1;
        //     count = 0;

        //     while(count < left)
        //     {
        //         foreach(var d in distinct)
        //         {
        //             if(days % d == 0)
        //             {
        //                 count += dict[d];
        //             }
        //         }

        //         days++;
        //     }
        // }

        // return days - 1;

    }

    static void Main(string[] args) {

        string[] nGoal = Console.ReadLine().Split(' ');

        int n = Convert.ToInt32(nGoal[0]);

        long goal = Convert.ToInt64(nGoal[1]);

        long[] machines = Array.ConvertAll(Console.ReadLine().Split(' '), machinesTemp => Convert.ToInt64(machinesTemp))
        ;
        long ans = minTime(machines, goal);

        Console.WriteLine(ans);

    }
}
