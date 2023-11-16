using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Reptile : Animal 
    {
        public bool HasScales { get; set; } = true;
        public bool IsColdBlooded { get; set; } = true; 
        public bool LaysEggs { get; set; } = true; 
        public bool ScaryLooking { get; set; } = true;

        public void PrintReptileDetails()
        {
            Console.WriteLine(""); 
            Console.WriteLine("");
            Console.WriteLine($"A lizard has {NumberOfLegs} legs");
            Console.WriteLine($"The color: {Color}");
            Console.WriteLine($"Lays eggs: {LaysEggs}"); 
              Console.WriteLine($"Is coldblooded: {IsColdBlooded}"); 
        }
    }
}
