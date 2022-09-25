using System;
using System.Collections.Generic;

class Program
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        string ans = "";
        for(int i = 0; i < n; i++)
        {
            string temp = Console.ReadLine();
            ans = temp+ "\n" +ans;
        }
        Console.WriteLine(ans);
    }
 

}
