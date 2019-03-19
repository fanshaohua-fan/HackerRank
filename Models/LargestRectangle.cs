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


class LargestRectangle {

    // Complete the largestRectangle function below.
    static long largestRectangle(int[] h) {
        long max = 0;

        for(var i = 0; i < h.Length - 1; i++)
        {
            var height = h[i];
            var queue = new Queue<int>();
            for(var j = i; j >= 0; j--)
            {
                if(h[j] < height)
                {
                    break;
                }
                queue.Enqueue(h[j]);
            }

            for(var j = i + 1; j < h.Length; j++)
            {
                if(h[j] < height)
                {
                    break;
                }
                queue.Enqueue(h[j]);
            }

            var rectangle = height * queue.Count;

            if(rectangle > max)
            {
                max = rectangle;
            }
        }

        return max;

    }

    // static void Main(string[] args) {

    //     int n = Convert.ToInt32(Console.ReadLine());

    //     int[] h = Array.ConvertAll(Console.ReadLine().Split(' '), hTemp => Convert.ToInt32(hTemp))
    //     ;
    //     long result = largestRectangle(h);

    //     Console.WriteLine(result);

    // }
}
