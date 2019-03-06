using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

class Queue {
    static private Stack<int> sA = new Stack<int>();
    static private Stack<int> sB = new Stack<int>();

    static public void Enqueue(int data)
    {
        while(sB.Count > 0)
        {
            int t = sB.Pop();
            sA.Push(t);
        }

        sA.Push(data);
    }

    static public void Dequeue()
    {
        while(sA.Count > 0)
        {
            int t = sA.Pop();
            sB.Push(t);
        }

        if(sB.Count > 0)
        {
            sB.Pop();
        }
    }

    static public int Front()
    {
        while(sA.Count > 0)
        {
            var t = sA.Pop();
            sB.Push(t);
        }

        return sB.Peek();
    }

    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int t = Convert.ToInt32(Console.ReadLine());
        var list = new List<string>();
        string path = Path.GetTempFileName();
        using (FileStream fs = File.Open(path, FileMode.Open, FileAccess.Write, FileShare.None)) 
        {
            
            for (int tItr = 0; tItr < t; tItr++) {
                string s = Console.ReadLine();
                list.Add(s);
            }

            foreach(var s in list)
            {
                if(s == "2")
                {
                    Dequeue();
                }
                else if(s == "3")
                {
                    var res = Front();
                    // Console.WriteLine(res);
                    Byte[] info = new UTF8Encoding(true).GetBytes(res.ToString() + "\n");
                    // Add some information to the file.
                    fs.Write(info, 0, info.Length);
                }
                else
                {
                    string data = s.Split(' ')[1];
                    Enqueue(Convert.ToInt32(data));
                }
            }
        }
    }
}

