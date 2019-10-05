using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeDPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Developer dev = new Developer();
            dev.Name = "Rahul";
            dev.Role = "Team Leader";
            dev.PreferredLanguage = "C#";

            Developer devCopy = (Developer)dev.Clone();
            devCopy.Name = "Arif"; 

            Console.WriteLine(dev.GetDetails());
            Console.WriteLine(devCopy.GetDetails());

            TyPist typist = new TyPist();
            typist.Name = "Monu";
            typist.Role = "Typist";
            typist.WordsPerMinute = 120;

            TyPist typistCopy = (TyPist)typist.Clone();
            typistCopy.Name = "Sahil";
            typistCopy.WordsPerMinute = 115;

            Console.WriteLine(typist.GetDetails());
            Console.WriteLine(typistCopy.GetDetails());

            Console.ReadKey();
        }
    }
}
