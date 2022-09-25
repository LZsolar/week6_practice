using System;
using System.Collections.Generic;

class Program
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        PriorityQueue<int,int> q = new PriorityQueue<int, int>();
        for(int i = 0; i < n; i++)
        {
            int temp = int.Parse(Console.ReadLine());
            q.Enqueue(temp,temp);
        }
        for(int i = 0; i < n; i++)
        {
            Console.WriteLine(q.Dequeue());
        }
    }
}