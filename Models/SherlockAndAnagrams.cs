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

class SherlockAndAnagrams {

    // Complete the sherlockAndAnagrams function below.
    static int sherlockAndAnagrams(string s) {
        int result = 0;
        var dict = new Dictionary<string, int>();

        for(var j = 1; j < s.Length; j++)
        {
            for(var i = 0; i < s.Length - j + 1; i++)
            {
                String t = s.Substring(i, j);
                String key = String.Concat(t.OrderBy(c => c));
                if(!dict.ContainsKey(key))
                {
                    dict.Add(key, 1);
                }
                else
                {
                    result += dict[key];
                    dict[key] += 1;
                }

                System.Console.WriteLine(key + "-" + dict[key]);
                
            }
        }

        // correct, but performance is not good
        // for(var z = 1; z < s.Length; z++)
        // {
        //     for(var i = 0; i < s.Length; i++)
        //     {
        //         for(var j = i + 1; j < s.Length - z + 1; j++)
        //         {
        //             String x = s.Substring(i, z);
        //             String y = s.Substring(j, z);
        //             System.Console.WriteLine(x + "-" + y);
        //             if( String.Concat(x.OrderBy(c => c))== String.Concat(y.OrderBy(c => c)))
        //             {
        //                 result++;
        //                 System.Console.WriteLine(result);
        //             }
        //         }
        //     }
        // }


        return result;

    }

    // static void Main(string[] args) {
    //     // string s = "ifailuhkqqhucpoltgtyovarjsnrbfpvmupwjjjfiwwhrlkpekxxnebfrwibylcvkfealgonjkzwlyfhhkefuvgndgdnbelgruel";
    //     string s = "kkkk";

    //     int result = sherlockAndAnagrams(s);

    //     System.Console.WriteLine(result);

    //     s = "ifailuhkqqhucpoltgtyovarjsnrbfpvmupwjjjfiwwhrlkpekxxnebfrwibylcvkfealgonjkzwlyfhhkefuvgndgdnbelgruel";

    //     result = sherlockAndAnagrams(s);

    //     System.Console.WriteLine(result);

// 5
// ifailuhkqqhucpoltgtyovarjsnrbfpvmupwjjjfiwwhrlkpekxxnebfrwibylcvkfealgonjkzwlyfhhkefuvgndgdnbelgruel
// gffryqktmwocejbxfidpjfgrrkpowoxwggxaknmltjcpazgtnakcfcogzatyskqjyorcftwxjrtgayvllutrjxpbzggjxbmxpnde
// mqmtjwxaaaxklheghvqcyhaaegtlyntxmoluqlzvuzgkwhkkfpwarkckansgabfclzgnumdrojexnrdunivxqjzfbzsodycnsnmw
// ofeqjnqnxwidhbuxxhfwargwkikjqwyghpsygjxyrarcoacwnhxyqlrviikfuiuotifznqmzpjrxycnqktkryutpqvbgbgthfges
// zjekimenscyiamnwlpxytkndjsygifmqlqibxxqlauxamfviftquntvkwppxrzuncyenacfivtigvfsadtlytzymuwvpntngkyhw

// 399
// 471
// 370
// 403
// 428
    // }
}
