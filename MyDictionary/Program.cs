using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, int> _dictionary = new Dictionary<int, int>();

            MyDictionary<int, string> arkadas = new MyDictionary<int, string>();
            arkadas.Add(1, "orhan");
            arkadas.Add(2, "fatih");
            arkadas.Add(3, "emre");

            foreach (var key in arkadas.Keys)
            {
                Console.WriteLine(key);
            }

            foreach (var value in arkadas.Values)
            {
                Console.WriteLine(value);
            }
        }
    }
}
