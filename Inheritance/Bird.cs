using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Bird : Animal
    {
        //Properties
        public int WingSpan { get; set; }
        public bool Migratory { get; set; }
        public string FeatherColor { get; set; }
        public string BeakColor { get; set; }
    }
}
