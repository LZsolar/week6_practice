using System;
using System.Collections.Generic;

class Program
{
    public static void Main(string[] args)
    {
       int n = int.Parse(Console.ReadLine());
       int[] co = new int[n];
        for(int i = 0; i < n; i++)
        {
            co[i] = int.Parse(Console.ReadLine());
        }

        int now = int.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine());

        while(step> 0)
        {
            now = co[now - 1];
            step--;
        }
        Console.WriteLine(now);
    }
}