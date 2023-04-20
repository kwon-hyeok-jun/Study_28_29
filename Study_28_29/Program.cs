using System;
using System.Linq;

class EnumerableDemo
{
    static void Main()
    {
        var numbers = Enumerable.Range(1, 5);
        foreach (var n in numbers)
        {
            Console.Write("{0}\t",n);
        }
        Console.WriteLine();

        var sameNumbers = Enumerable.Repeat(-1, 5);
        foreach (var n in sameNumbers)
        {
            Console.Write("{0}\t",n);
        }
        Console.WriteLine();


        //======================================================
        int num;
        List<string> list;

        list = null;

        num = list?.Count ?? 0;
        Console.WriteLine(num);

        list = new List<string>();
        list.Add("hi");

        num = list?.Count ?? 0;
        Console.WriteLine(num);

    }
}