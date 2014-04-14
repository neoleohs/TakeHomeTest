using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetPrimeFactors
{
    /// <summary>
    /// Question 2.1
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 1)
            {
                Console.WriteLine("Please enter file name.");
                return;
            }

            string filename = args[0];
            Console.WriteLine(File.Exists(filename) ? "File exists." : "File does not exist.");

            var primeFactors = new CalculatePrimeFactors();

            var numbers = GetNumbers(filename);

            foreach (string s in numbers)
            {
                try
                {
                    primeFactors.Calculate(int.Parse(s));
                }
                catch { continue; }

                Console.WriteLine(string.Join(",", primeFactors.PrimeNumbers.ToArray()));
            }
        }

        static ArrayList GetNumbers(string path)
        {
            ArrayList numbers = new ArrayList();

            using (StreamReader sr = File.OpenText(path))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    numbers.Add(s);
                }
            }

            return numbers;
        }
    }
}
