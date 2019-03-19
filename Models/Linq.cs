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
using PushCustomersToMpoint.Modles;
using Newtonsoft.Json;

class Linq{
    static void Main(string[] args) {
        // Initialization
        var path = "C:\\temp\\customers300K.json";
        var lines = File.ReadAllLines(path);

        var list = new List<CustomerDetails>();

        foreach(var line in lines)
        {
            var customer = JsonConvert.DeserializeObject<CustomerDetails>(line);
            list.Add(customer);
        }

        // LINQ
        var start = DateTime.Now;
        var result = (from c in list
                        where c.balance > 100
                        where c.gender == "M"
                        where c.addresses.FirstOrDefault().city == "Amsterdam"
                        select c).ToList();
        var end = DateTime.Now;
        TimeSpan interval = end - start;
        Console.WriteLine($"{result.Count}: {interval.TotalMilliseconds}ms");
        // Console.ReadKey();
    }
}