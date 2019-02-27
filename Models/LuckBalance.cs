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

class LuckBalance {

    // Complete the luckBalance function below.
    static int luckBalance(int k, int[][] contests) {
        var arrIm = new List<int>();
        var arrUnIm = new List<int>();
        
        foreach(var arr in contests)
        {
            if(arr[1] > 0)
            {
                arrIm.Add(arr[0]);
            }
            else
            {
                arrUnIm.Add(arr[0]);
            }
        }

        arrIm.Sort();
        arrIm.Reverse();

        var lose = arrIm.Take(k);
        var sumLose = lose.Sum();

        return arrUnIm.Sum() + sumLose - (arrIm.Sum() - sumLose);
    }

    static void Main(string[] args) {


        int n = Convert.ToInt32(6);

        int k = Convert.ToInt32(3);

        int[][] contests = new int[n][];

        contests[0] = Array.ConvertAll("5 1".Split(' '), contestsTemp => Convert.ToInt32(contestsTemp));
        contests[1] = Array.ConvertAll("2 1".Split(' '), contestsTemp => Convert.ToInt32(contestsTemp));
        contests[2] = Array.ConvertAll("1 1".Split(' '), contestsTemp => Convert.ToInt32(contestsTemp));
        contests[3] = Array.ConvertAll("8 1".Split(' '), contestsTemp => Convert.ToInt32(contestsTemp));
        contests[4] = Array.ConvertAll("10 0".Split(' '), contestsTemp => Convert.ToInt32(contestsTemp));
        contests[5] = Array.ConvertAll("5 0".Split(' '), contestsTemp => Convert.ToInt32(contestsTemp));
        int result = luckBalance(k, contests);

    }
}
