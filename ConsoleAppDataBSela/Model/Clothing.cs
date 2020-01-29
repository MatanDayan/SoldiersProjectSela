using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDataBSela.Model
{
    class Clothing : AbstractItem
    {
        public string color { get; set; } // enum?
        public int Size { get; set; }
    }
}
