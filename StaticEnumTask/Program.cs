﻿namespace StaticEnumTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[0];
            arr = arr.Add(1);
            arr = arr.Add(2);
            arr = arr.Add(3);
            arr = arr.Add(4);
            int sum = 0;
            foreach (var item in arr)
            {
                sum += item;
            }
            Console.WriteLine(sum);
        }
    }
}
