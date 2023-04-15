using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework14._04._23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length <= 0)
            {
                Console.WriteLine("Usage: ToCelsius.exe <temperature in F>");
                return;
            }

            double fahrenheit;
            if (!double.TryParse(args[0], out fahrenheit))
            {
                Console.WriteLine("Invalid input: {0}", args[0]);
                return;
            }

            double celsius = (fahrenheit - 32) * 5 / 9;

            Console.WriteLine("{0} F = {1} C", fahrenheit, celsius);

        }
    }
}
