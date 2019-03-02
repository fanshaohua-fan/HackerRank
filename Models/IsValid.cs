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

class IsValid {

    // Complete the isValid function below.
    static string isValid(string s) {
        var dict = new Dictionary<char, int>();

        foreach(var c in s)
        {
            if(dict.ContainsKey(c))
            {
                dict[c] += 1;
            }
            else
            {
                dict.Add(c, 1);
            }
        }

        

        int gap = 0;
        int common = 0;
        foreach(var key in dict.Keys)
        {
            if(common == 0)
            {
                common = dict[key];
            }
            else{
                if(Math.Abs(dict[key] - common) > 1 && dict[key] != 1)
                {
                    return "NO";
                }
                else if(Math.Abs(dict[key] - common) == 1 || dict[key] == 1)
                {
                    gap++;
                    if(gap > 1)
                    {
                        return "NO";
                    }
                }
            }

        }

        return "YES";

    }

    // static void Main(string[] args) {

    //     string result = isValid("ibfdgaeadiaefgbhbdghhhbgdfgeiccbiehhfcggchgghadhdhagfbahhddgghbdehidbibaeaagaeeigffcebfbaieggabcfbiiedcabfihchdfabifahcbhagccbdfifhghcadfiadeeaheeddddiecaicbgigccageicehfdhdgafaddhffadigfhhcaedcedecafeacbdacgfgfeeibgaiffdehigebhhehiaahfidibccdcdagifgaihacihadecgifihbebffebdfbchbgigeccahgihbcbcaggebaaafgfedbfgagfediddghdgbgehhhifhgcedechahidcbchebheihaadbbbiaiccededchdagfhccfdefigfibifabeiaccghcegfbcghaefifbachebaacbhbfgfddeceababbacgffbagidebeadfihaefefegbghgddbbgddeehgfbhafbccidebgehifafgbghafacgfdccgifdcbbbidfifhdaibgigebigaedeaaiadegfefbhacgddhchgcbgcaeaieiegiffchbgbebgbehbbfcebciiagacaiechdigbgbghefcahgbhfibhedaeeiffebdiabcifgccdefabccdghehfibfiifdaicfedagahhdcbhbicdgibgcedieihcichadgchgbdcdagaihebbabhibcihicadgadfcihdheefbhffiageddhgahaidfdhhdbgciiaciegchiiebfbcbhaeagccfhbfhaddagnfieihghfbaggiffbbfbecgaiiidccdceadbbdfgigibgcgchafccdchgifdeieicbaididhfcfdedbhaadedfageigfdehgcdaecaebebebfcieaecfagfdieaefdiedbcadchabhebgehiidfcgahcdhcdhgchhiiheffiifeegcfdgbdeffhgeghdfhbfbifgidcafbfcd");

    //     Console.WriteLine(result);

    // }
}
