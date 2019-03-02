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
        // var exp = new List<int>(expenditure);
        var n = expenditure.Length;
        var count = 0;

        if(expenditure.Length <= d)
        {
            return 0;
        }

        var isOdd = d % 2 == 1 ? true : false;
        int index = d / 2;
        var arr = expenditure.Take(d).ToList();
        arr.Sort();

        for(var i = d; i < n; i++)
        {
            //var tmp = exp.Skip(i - d).Take(d).ToList();
            var median = 0;
            if(isOdd)
            {
                median =  2 * arr[index];
            }
            else
            {
                median =  arr[index - 1] + arr[index];
            }

            if(expenditure[i] >= median)
            {
                count++;
            }


            // prepare for next round
            // remove first value
            var toBeRemovedIndex = arr.IndexOf(expenditure[i - d]);
            arr.RemoveAt(toBeRemovedIndex);

            // add new value
            var toBeAdded = expenditure[i];
            // since one element has been removed
            var pos = d - 1;
            arr.Add(toBeAdded);
            while(pos > 0 && toBeAdded < arr[pos - 1])
            {
                arr[pos] = arr[pos - 1];
                pos -= 1;
            }

            arr[pos] = toBeAdded;
        }

        return count;
    }

    // static void Main(string[] args) {


    //     int d = Convert.ToInt32(5);

    //     int[] expenditure = Array.ConvertAll(Console.ReadLine().Split(' '), expenditureTemp => Convert.ToInt32(expenditureTemp))
    //     ;
    //     int result = activityNotifications(expenditure, d);

    //     Console.WriteLine(result);

    // }
}
