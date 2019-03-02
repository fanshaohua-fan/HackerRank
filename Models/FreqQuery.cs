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

class FreqQuery {

    // Complete the freqQuery function below.
    static List<int> freqQuery(List<List<int>> queries) {
        var dict = new Dictionary<int, int>();
        var count = new Dictionary<int, int>();
        var result = new List<int>();

        foreach(var list in queries)
        {
            if(list[0] == 1)
            {
                var value = list[1];
                if(dict.ContainsKey(value))
                {
                    // old count --
                    count[dict[value]] -= 1;

                    dict[value] += 1;
                    
                    // new count ++
                    if(count.ContainsKey(dict[value]))
                    {
                        count[dict[value]] += 1;
                    }
                    else
                    {
                        count.Add(dict[value], 1);
                    }
                }
                else
                {
                    dict.Add(value, 1);
                    
                    // new count ++
                    if(count.ContainsKey(dict[value]))
                    {
                        count[dict[value]] += 1;
                    }
                    else
                    {
                        count.Add(dict[value], 1);
                    }
                }
            }
            else if(list[0] == 2)
            {
                var value = list[1];
                if(dict.ContainsKey(value))
                {
                    // old count --
                    count[dict[value]] -= 1;

                    dict[value] -= 1;
                    if(dict[value] < 0){
                        dict[value] = 0;
                    }

                    // new count ++
                    if(count.ContainsKey(dict[value]))
                    {
                        count[dict[value]] += 1;
                    }
                    else
                    {
                        count.Add(dict[value], 1);
                    }
                }
            }
            else if(list[0] == 3)
            {
                var freq = list[1];
                // var found = false;
                // foreach(var key in dict.Keys)
                // {
                //     if(freq == dict[key])
                //     {
                //         found = true;
                //         break;
                //     }
                // }

                if( count.ContainsKey(freq))
                {
                    result.Add(count[freq] > 0 ? 1: 0);
                }
                else
                {
                    result.Add(0);
                }
            }
        }

        return result;
    }

    // static void Main(string[] args) {
    //     TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

    //     int q = Convert.ToInt32(Console.ReadLine().Trim());

    //     List<List<int>> queries = new List<List<int>>();

    //     for (int i = 0; i < q; i++) {
    //         queries.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(queriesTemp => Convert.ToInt32(queriesTemp)).ToList());
    //     }

    //     List<int> ans = freqQuery(queries);

    //     textWriter.WriteLine(String.Join("\n", ans));

    //     textWriter.Flush();
    //     textWriter.Close();
    // }
}
