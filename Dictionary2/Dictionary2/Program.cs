using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ToDictionaryEx1();
            Console.ReadLine();
            
        }

        public static void ToDictionaryEx1()
        {
            List<Package> packages = new List<Package>();
            packages.Add(new Package("Coles Notes", 25.2, 89453312L));
            packages.Add(new Package("Davids Tea", 68.4, 89112755L));
            packages.Add(new Package("Sydneys Goats", 200, 299456122L));
            packages.Add(new Package("Andrew Lettuce", 4, 4665518773L));
            packages.Add(new Package("Griffins Volleyball Players", 2000, 122445448));
            packages.Add(new Package("Michael's Tears", 5000, 122445446));

            packages.ForEach(p => { Console.WriteLine(p); });

            //Create a Dictionary of Package objects,
            //using TrackingNumber as the key
            //watch out because duplicate keys cause errors!!
            Dictionary<long, Package> dictPackages = packages.ToDictionary(p => p.TrackingNumber);

            //let's say you want the key of the dictionary to be the package??
            //how could we do that?
            Dictionary<Package,long> sample = dictPackages.ToDictionary(kvp => kvp.Value, kvp => kvp.Key);

            foreach (KeyValuePair<long, Package> kvp in dictPackages)
            {
                Console.WriteLine($"{kvp.Key} {kvp.Value}");
            }

            foreach (KeyValuePair<Package, long> kvp in sample)
            {
                Console.WriteLine($"{kvp.Key} {kvp.Value}");
            }

            //create a dictionary from a list, key is tracking number, value is "company"
            Dictionary<long, string> newDictionary = packages.ToDictionary(kvp => kvp.TrackingNumber,
                kvp => kvp.Company);

            foreach (KeyValuePair<long,string> kvp in newDictionary)
            {
                Console.WriteLine($"{kvp.Key} {kvp.Value}");
            }

            Console.WriteLine("This is how you get something from dictionary specifically: " + newDictionary[89112755L]);

            List<KeyValuePair<string,int>> colesList = new List<KeyValuePair<string,int>>();
            colesList.Add(new KeyValuePair<string, int>("Apples", 1));
            colesList.Add(new KeyValuePair<string, int>("Oranges", 2));

            Dictionary<string,int> ColesDictionary = colesList.OrderByDescending(i => i.Value).
                ToDictionary(kvp => kvp.Key, kvp => kvp.Value);

            foreach (KeyValuePair<string, int> kvp in ColesDictionary)
            {
                Console.WriteLine($"{kvp.Key} {kvp.Value}");
            }

            colesList.Where(i => i.Key == "Oranges").ToList().ForEach(i => Console.WriteLine(i.Key));

        }

        class Package
        {
            public string Company { get; set; }
            public double Weight { get; set; }
            public long TrackingNumber { get; set; }
            public Package(string co, double w, long tn)
            {
                Company = co;
                Weight = w;
                TrackingNumber = tn;
            }

            public override string ToString()
            {
                return Company + ": " + Weight + " [" + TrackingNumber + "]";
            }
        }
    }
}
