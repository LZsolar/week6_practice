using System;

class Program
{
    public static void Main(string[] args)
    {
        Dictionary<int, bool> used = new Dictionary<int, bool>();
        PriorityQueue<int, int> q = new PriorityQueue<int, int>();

        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
           int temp = int.Parse(Console.ReadLine());
           if (!used.ContainsKey(temp))
            {
                q.Enqueue(temp,temp);
                used.Add(temp, true);
            }
        }

        int m = int.Parse(Console.ReadLine());
        for (int i = 0; i < m; i++)
        {
            int temp = int.Parse(Console.ReadLine());
            if (!used.ContainsKey(temp))
            {
                q.Enqueue(temp, temp);
                used.Add(temp, true);
            }
        }

        
        while(q.Count > 0)
        {
            Console.WriteLine(q.Dequeue());
        }
    }
}