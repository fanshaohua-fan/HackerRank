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

class SubstrCount {
    // static bool isPalindromic (int n, string s)
    // {
    //     if( n % 2 == 1)
    //     {
    //         int mid = n / 2;

    //         for(int i = 0; i < n - 1; i++)
    //         {
    //             if(i + 1 == mid || i == mid)
    //             {
    //                 if(s[mid - 1] != s[mid + 1])
    //                 {
    //                     return false;
    //                 }
    //             }
    //             else
    //             {
    //                 if(s[i] != s[i+1])
    //                 {
    //                     return false;
    //                 }
    //             }
    //         }
    //     }
    //     else
    //     {
    //         for(int i = 0; i < n - 1; i++)
    //         {
    //             if(s[i] != s[i+1])
    //             {
    //                 return false;
    //             }
    //         }
    //     }

    //     return true;
    // }

    // Complete the substrCount function below.
    static long substrCount(int n, string s) {
        long result = 0;
        result += n;

        // for (var i = 2; i <= n; i++)
        // {
        //     for(var j = 0; j <= n - i; j++)
        //     {
        //         var p = isPalindromic(i, s.Substring(j, i));
        //         if(p)
        //         {
        //             result++;
        //         }
        //     }
        // }

        // reuse the result of previous round.
        /*
        for example: asassdss
        as, asa count++
        sa, sas count++
        as, asd 
        ss, ssd, ssds, ssdss, count + 2
        sd, sds count++
        ds, dss
        ss  count++

         */
        for (var i = 0; i < n; i++)
        {
            var sameCount = 1;
            var mid = false;
            for(var j = i + 1; j < n; j++)
            {
                if(s[i] == s[j])
                {
                    if(mid)
                    {
                        if(j - i == 2 * sameCount)
                        {
                            result++;
                            break;
                        }
                    }
                    else
                    {
                        sameCount++;
                        result++;
                    }
                }
                else
                {
                    if(!mid)
                    {
                        mid = true;
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }

        return result;

    }

    // static void Main(string[] args) {
    //     int n = 8;

    //     // string s = Console.ReadLine();
    //     string s = "asassdss";

    //     long result = substrCount(n, s);

    //     Console.WriteLine(result);

    // }
}
