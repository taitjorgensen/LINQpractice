using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LINQProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };
            List<string> names = new List<string>() { "Mike", "Brad", "Nevin", "Zack", "Mike" };
            List<string> classGrades = new List<string>() { "80,100,92,89,65", "93,81,78,84,69", "73,88,83,99,64", "98,100,66,74,55" };

            var thWords = words.Where(w => w.Contains("th"));
            foreach (var word in thWords)
            {
                Console.WriteLine(word);
                Console.ReadLine();
            }

            var distinctNames = names.Select(n => n).Distinct();
            foreach (var name in distinctNames)
            {
                Console.WriteLine(name);
                Console.ReadLine();
            }

            var listOfList = classGrades.Select(c => c.Split(',')).ToList();
            List<double> averages = new List<double>();
            double totalAverage;

            foreach (var item in listOfList)
            {
                List<int> studentGrades = new List<int>();
                foreach (var thing in item)
                {
                    studentGrades.Add(int.Parse(thing));
                }
                studentGrades.OrderByDescending(s => s);
                studentGrades.RemoveAt(studentGrades.Count - 1);
                double studentAverage = studentGrades.Average();
                averages.Add(studentAverage);
            }
            totalAverage = averages.Average();
            Console.WriteLine(totalAverage);
            Console.ReadLine();

            //String Letters
            string stringEntered = "Terrill";
            var letterRepeat = from l in stringEntered.ToLower().ToArray().OrderBy(l => l)
                               group l by l into letterFrequency
                               select letterFrequency;

            foreach (var l in letterRepeat)
            Console.Write($"{l.Key}{l.Count()}");
            Console.ReadLine();
        }
    
    }
}
