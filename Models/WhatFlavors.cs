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

class WhatFlavors {

    // Complete the whatFlavors function below.
    static void whatFlavors(int[] cost, int money) {
        
        // for(var i = 0; i < cost.Length; i++)
        // {
        //     var cost1 = cost[i];
        //     var cost2 = money - cost1;

        //     var index = Array.IndexOf(cost, cost2);
        //     if(index == i)
        //     {
        //         index = Array.IndexOf(cost, cost2, i+1);
        //     }

        //     if(index >= 0)
        //     {
        //         System.Console.WriteLine((i + 1) + " " + (index + 1));
        //         return;
        //     }
        // }

        /*
        HashMap<Integer, Integer> ids = new HashMap<>();
		for (int i = 0; i < cost.length; i++) {

			if (ids.containsKey(cost[i])) {
				int id1 = i + 1;
				int id2 = ids.get(cost[i]);

				System.out.print(Math.min(id1, id2) + " " + Math.max(id1, id2));
				break;
			} else {
				int key = money - cost[i];
				int value = i + 1;
				ids.put(key, value);
			}
		}
         */

        var dict = new Dictionary<int, int>();

        for(var i = 0; i < cost.Length; i++)
        {
            if(dict.ContainsKey(cost[i]))
            {
                int id1 = i + 1;
				int id2 = dict[cost[i]];
                Console.WriteLine(Math.Min(id1, id2) + " " + Math.Max(id1, id2));
                return;
            }
            else
            {
                var key = money - cost[i];
                var v = i + 1;
                dict[key] = v;
            }
        }


    }

    static void Main(string[] args) {
        // int t = Convert.ToInt32(Console.ReadLine());

        // for (int tItr = 0; tItr < t; tItr++) {
            int money = Convert.ToInt32(4);

            // int n = Convert.ToInt32(Console.ReadLine());

            int[] cost = Array.ConvertAll("1 4 5 3 2".Split(' '), costTemp => Convert.ToInt32(costTemp))
            ;
            whatFlavors(cost, money);
        // }
    }
}
