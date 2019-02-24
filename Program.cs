using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace DotnetCoreConsole
{
    class Program
    {
        // static void Main(string[] args)
        // {
        //     Console.WriteLine("Hello World!");

        //     int n = 10;

        //     int[] ar = Array.ConvertAll("1 1 3 1 2 1 3 3 3 3 ".Trim().Split(' '), arTemp => Convert.ToInt32(arTemp));
        //     int result = sockMerchant(n, ar);
        //     Console.WriteLine(result);
        // }

        // Complete the sockMerchant function below.
        static int sockMerchant(int n, int[] ar) {
            var d = new Dictionary<int,int> ();
            foreach (var i in ar)
            {
                if(d.ContainsKey(i))  
                {  
                    int v = d[i];
                    d[i] = v + 1;
                }
                else
                {
                    d.Add(i, 1);
                }
            }

            int result = 0;
            foreach (KeyValuePair<int, int> kvp in d)  
            {  
            　　 //Console.WriteLine("Key = {0}, Value = {1}",kvp.Key, kvp.Value);  
                result += kvp.Value / 2;
            } 

            return result;
        }
    }
}
