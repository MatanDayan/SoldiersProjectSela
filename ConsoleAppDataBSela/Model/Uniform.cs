using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDataBSela.Model
{
    class Uniform : Clothing
    {
        public bool Shielding { get; set; }

        public Uniform()//ctor null
        {

        }
        public Uniform(bool shielding)
        {
            Shielding = shielding;
        }//ctor
    }
}
