using System;
using System.Collections.Generic;

namespace DictionaryIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare a dictionary variable and add key value 
            Dictionary<string, int> cohortCount = new Dictionary<string, int>();

            cohortCount.Add("Cohort 34",20);
            cohortCount.Add("Cohort 35",14);
            cohortCount.Add("Cohort 36",28);
            cohortCount.Add("Cohort 37",28);

            // Iterating over key value pairs
            foreach( KeyValuePair<string, int> item in cohortCount )
            {
                Console.WriteLine($"{item.Key} has {item.Value} students");
            }

            // Another way to declare dictionary
            Dictionary<string, double> products = new Dictionary<string, double>()
            {
                {"Deodorant", 8.50},
                {"Hair Brush", 8.50},
                {"Heidi Hair Brush", 8.50},
                {"Shampoo", 4.5},
                {"Tooth Brush", 40}
            };

            foreach( KeyValuePair<string, double> product in products )
            {
                Console.WriteLine($"{product.Key} costs ${product.Value}");
            }

            //Console.WriteLine("Hello World!");
        }
    }
}
