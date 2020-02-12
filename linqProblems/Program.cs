using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linqProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            //LINQ #1
            //List<string> words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };
            //var thWords = words.Where(w => w.Contains("th"));

            //foreach (var word in thWords)
            //{
            //    Console.WriteLine(word);
            //}
            //Console.ReadLine();

            //LINQ #2
            //List<string> names = new List<string>() { "Mike", "Brad", "Nevin", "Ian", "Mike" };
            //var noDuplicateNames = names.Distinct();

            //foreach (var name in noDuplicateNames)
            //{
            //    Console.WriteLine(name);
            //}
            //Console.ReadLine();

            //LINQ #3
            List<string> classGrades = new List<string>()
            {
                "80,100,92,89,65",
                "93,81,78,84,69",
                "73,88,83,99,64",
                "98,100,66,74,55"
            };
            
            var splitGrades = classGrades.Select(s => s.Split(',')).Select(s => s.Select(x =>double.Parse(x)).OrderBy(x => x).Skip(1)).SelectMany(s => s).Average();

            Console.WriteLine(splitGrades);

            //LINQ #4
            /*
             * Write a function that takes in a string of letters(i.e. “Terrill”) 
             * and returns an alphabetically ordered string corresponding to the letter frequency(i.e. "E1I1L2R2T1")
             */
            var initialString = "Terrill".ToUpper();
            var frequency = string.Join("", initialString.OrderBy(s => s).Distinct().Select(x => $"{x}{initialString.Count(y => y == x)}"));

            Console.WriteLine(frequency);
            Console.ReadLine();



        }
    }
}
