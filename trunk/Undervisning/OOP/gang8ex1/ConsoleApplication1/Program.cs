using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> randomNumbers = new List<int>();
            Random r = new Random();
            for (int i = 0; i < 20; i++)
            {
                randomNumbers.Add(r.Next(100));
            }

            //Opgave 1.a
            /*
            IEnumerable<int> b = from n in randomNumbers
                                 orderby n
                                 select n;
            */
            //Opgave 1.b

            IEnumerable<int> b = from n in randomNumbers
                                 orderby n descending
                                 select n;

            //Opgave 1.c
            b = b.Reverse();

            //Opgave 1.e
            b = b.Distinct(); 

            //Opgave 1.d
            int min = 2;
            int max = 50; 
            IEnumerable<int> c = from n in randomNumbers
                                 where min < n && n < max
                                 orderby n
                                 select (int)Math.Pow(n, 2);

            foreach (int n in b)
            {
                Console.WriteLine("Org value: " + n);
            }

            foreach (int m in c) {
                Console.WriteLine("The power is " + m);
            }

            Console.ReadLine();

        }
    }
}
