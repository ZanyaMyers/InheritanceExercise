using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Bird : Animal
    {
        public bool CanFly { get; set; }
        public string TailType { get; set; }
        public double WingSpan { get; set; }
        public bool IsPretty { get; set; }

        public void PrintBirdDetails()
        {
            Console.WriteLine($"A Bird tail type: {TailType}");
            Console.WriteLine($"The wing span: {WingSpan}");
            Console.WriteLine($" the number of legs {NumberOfLegs}");
               Console.WriteLine($"Attractive looking:{IsPretty}"); 
        }
    }
}
