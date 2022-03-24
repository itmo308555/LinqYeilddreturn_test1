using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

class Program
{
    const int MAX = 10000000;
    static string[] colors = new string[]
        { "Red", "Blue", "Green", "White", "Grey", "Cyan", "Azure" };

    static void Main(string[] args)
    {
        Stopwatch sw = new Stopwatch();
        sw.Start();

        // Test1  
        Test1();
        Console.WriteLine($"Duration = {sw.Elapsed.TotalMilliseconds} ms");
        // Console.ReadLine();

        Test2();
        Console.WriteLine($"Duration yield return = {sw.Elapsed.TotalMilliseconds} ms");
        //  Console.WriteLine("Duration yield return = {0} ms", sw.ElapsedMilliseconds);
        //$"Time taken to consolidate with dictionary {stopwatch.Elapsed.TotalMilliseconds} ms"
        // sw.Stop();

        Test3();
        // sw.Restart();
        Console.WriteLine($"Duration LINQ = {sw.Elapsed.TotalMilliseconds} ms");

        Console.ReadLine();



        // Test3();
        // sw.Restart();
        // Console.WriteLine("Duration = {0} ms", sw.ElapsedMilliseconds);


    }

    public static void Test1()
    {
        for (int iter = 0; iter < MAX; iter++)
        {
            int len;
            for (int i = 0; i < colors.Length; i++)
            {
                if (colors[i].Length == 4) len = colors[i].Length;
            }
        }
    }


    public static IEnumerable MatchingRows(string[] collection, int criterion)
    {
        foreach (string color in collection)
        {
            if (color.Length == criterion) yield return color;
        }
    }


    public static void Test2()
    {
        for (int iter = 0; iter < MAX; iter++)
        {
            foreach (string color in MatchingRows(colors, 4))
            {
                int length = color.Length;
            }
        }
    }




    public static void Test3()
    {
        for (int iter = 0; iter < MAX; iter++)
        {
            IEnumerable<string> filtered = from color in colors where color.Length == 4 select color;
            foreach (string color in filtered)
            {
                int length = color.Length;
            }
        }
    }

}