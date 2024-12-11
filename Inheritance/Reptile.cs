using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Reptile : Animal
    {
        public bool Shell { get; set; }
        public bool Scales { get; set; }
        public bool Legs { get; set; }
        public  string SkinColor { get; set; }
    }
}
