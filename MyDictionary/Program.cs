using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, int> _dictionary = new Dictionary<int, int>();

            MyDictionary<int, string> _myDictionary = new MyDictionary<int, string>();
            _myDictionary.Add(1, "orhan");
            _myDictionary.Add(2, "fatih");
            _myDictionary.Add(3, "emre");
        }
    }
}
