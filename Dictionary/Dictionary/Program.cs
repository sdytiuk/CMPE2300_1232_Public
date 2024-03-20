using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    internal class Program
    {
        internal static bool StartsWithM(KeyValuePair<string,double> kvp)
        {
            return kvp.Key.ToLower().StartsWith("m");
        }

        static void Main(string[] args)
        {
            Random random = new Random();
            /*
             * ListOfSomething[0] ListOfSomething[1]...
             * DictOfStudentGrades["Michael"] = 0
             * DictOfStudentGrades["Sydney"] = 100
             */
            Dictionary<string,double> DictOfStudentGrades = new Dictionary<string,double>();
            Dictionary<string, List<double>> DictOfGradeList = new Dictionary<string, List<double>>();
            DictOfStudentGrades.Add("Michael", random.NextDouble()*100);
            DictOfStudentGrades.Add("Shane", random.Next(0, 100));
            DictOfStudentGrades.Add("Andrew", random.Next(0, 100));

            //try catch
            try
            {
                DictOfStudentGrades.Add("Michael", 99.2);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            //NORMALLY CHECK IF A KEY already exists
            if (DictOfStudentGrades.ContainsKey("Michael"))
                DictOfStudentGrades["Michael"] += 99.2;
            else
                DictOfStudentGrades.Add("Michael", 99.2);

            foreach (KeyValuePair<string,double> kvp  in DictOfStudentGrades)
            {
                Console.WriteLine($"{kvp.Key} has a grade of: {kvp.Value}");
            }

            //show all the keys of the dictionary
            List<string> skeys = DictOfStudentGrades.Keys.ToList();

            skeys.ForEach(s => Console.WriteLine(s));
            skeys.Sort();
            skeys.ForEach(s => Console.WriteLine(s));

            foreach (string s in DictOfStudentGrades.Keys)
            {
                Console.WriteLine(s);
            }

            //only display values of keys that start with m
            foreach(KeyValuePair<string,double> kvp in DictOfStudentGrades.Where(StartsWithM))
                Console.WriteLine($"{kvp.Key} has a grade of: {kvp.Value}");

            Console.ReadLine();
        }
    }
}
