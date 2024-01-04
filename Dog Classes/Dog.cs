using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    public class Dog : IDogWalker
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Dog()
        {
            Name = "Arlo";
            Age = 6;
        }
        public void Bark()
        {
            Console.WriteLine("Bark");
        }

        public void WalkToHome()
        {
            Console.WriteLine("Walk Home");
        }

        public void WalkToPark()
        {
            Console.WriteLine("Walk to the Park");
        }

        public void WalkToCountry()
        {
            Console.WriteLine("Walk to the Country");
        }
    }

}
