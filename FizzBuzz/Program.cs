using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("FizzBuzz");
            Console.WriteLine("0--------------------------0");
            Console.WriteLine("");

            for (int i = 0; i < 100; i++)
            {
                string output = "";

                Method(3, "Fizz", i, ref output);
                Method(5, "Buzz", i, ref output);

                if (output == "") output = i.ToString();

                Console.WriteLine(output);
            }
            Console.ReadLine();

            // 10/3 = 3.3333
            Console.WriteLine();

        }
        static void Method(int num, string name, int i, ref string output)
        {
            if (i % num == 0) output += name;
        } 
    }
}
