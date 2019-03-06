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

class BalancedBrackets {

    // Complete the isBalanced function below.
    static string isBalanced(string s) {
        var stack = new Stack<char>();
        
        foreach(var c in s)
        {
            char t = 'a';
            switch(c){
            case '{' :
            case '[' :
            case '(' :
                stack.Push(c);
                break; 
            case '}'  :
                if(stack.Count == 0)
                    return "NO";

                t = stack.Peek();
                if(t == '{')
                {
                    stack.Pop();
                }
                else
                {
                    return "NO";
                }
                break; 
            case ']'  :
                if(stack.Count == 0)
                    return "NO";

                t = stack.Peek();
                if(t == '[')
                {
                    stack.Pop();
                }
                else
                {
                    return "NO";
                }
                break; 
            case ')'  :
                if(stack.Count == 0)
                    return "NO";

                t = stack.Peek();
                if(t == '(')
                {
                    stack.Pop();
                }
                else
                {
                    return "NO";
                }
                break; 
            }
        }

        if(stack.Count == 0)
        {
            return "YES";
        }
        else
        {
            return "NO";
        }

    }

    // static void Main(string[] args) {

    //     int t = Convert.ToInt32(Console.ReadLine());

    //     for (int tItr = 0; tItr < t; tItr++) {
    //         string s = Console.ReadLine();

    //         string result = isBalanced(s);

    //         Console.WriteLine(result);
    //     }

    // }
}
