using _4gün_odev5;
using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> names = new MyList<string>();
            names.Add("Eda");
            Console.WriteLine("List Count: {0}", names.Count);

            MyDictionary<int, string> names2 = new MyDictionary<int, string>();
            names2.Add(1, "Eda");
            names2.Add(2, "Derya");
            Console.WriteLine("Dictionary Count: {0}", names2.Count);
            Console.WriteLine("Values: {0} , {1} ", names2.GetValue[0], names2.GetValue[1]);
            Console.WriteLine("Keys: {0} , {1} ", names2.GetKey[0], names2.GetKey[1]);



        }
    }
}