using System;
using System.Collections.Generic;

class Program
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());
        bool[] stats = new bool[n];
        int[] mbps = new int[m];
        
        for(int i = 0; i < n; i++)
        {
            string temp = Console.ReadLine();
            if (temp == "True") { stats[i] = true; }
            else { stats[i] = false; }
        }
        for(int i = 0;i < m; i++)
        {
            mbps[i]=int.Parse(Console.ReadLine());
        }

        int x = int.Parse(Console.ReadLine());
       
        for(int i = 0;i<m ; i++)
        {
            for(int j = 1; j <= n; j++)
            {
                if ((n*i)+j == x)
                {
                    if (stats[j-1]) { Console.WriteLine(mbps[i]+" Mbps"); }
                    else { Console.WriteLine("Offline"); }
                }
            }
        }
    }
}