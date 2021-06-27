using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNinja.Fundamentals
{
    class Mamal
    {
        public bool DrinksMilk { get; set; }
        public int NumberOfEyes { get; set; }
    }

    class Tiger : Mamal
    {
        public int NumberOfLegs { get; set; }
        public string JungleName { get; set; }
    }

    class Cheetah: Tiger
    {
        public string Origin { get; set; }
    }
}
