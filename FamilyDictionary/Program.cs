using System;
using System.Collections.Generic;

namespace FamilyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            var myFamily = new Dictionary<string, Dictionary<string, string>>();
            myFamily.Add("sister", new Dictionary<string, string>() { { "name", "Ily" }, { "age", "29" } });
            myFamily.Add("dad", new Dictionary<string, string>() { { "name", "Steve" }, { "age", "64" } });
            myFamily.Add("mom", new Dictionary<string, string>() { { "name", "Tamara" }, { "age", "66" } });

            foreach (var familyMember in myFamily)
            {
                Console.WriteLine($"{familyMember.Value["name"]} is my {familyMember.Key} and is {familyMember.Value["age"]} years old.");
            }
        }
    }
}
