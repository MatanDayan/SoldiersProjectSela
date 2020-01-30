using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleAppDataBSela.Model.Enums;

namespace ConsoleAppDataBSela.Model
{
    class Clothing : AbstractItem
    {
        public ColorType color { get; set; } // enum?
        public int Size { get; set; } 
    }
}
