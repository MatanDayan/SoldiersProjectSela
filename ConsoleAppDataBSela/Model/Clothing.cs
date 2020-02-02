using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDataBSela.Model
{
    class Clothing : AbstractItem
    {
        public ColorType color { get; set; } // enum
        public int Size { get; set; }

        public Clothing()
        {

        } // ctor null
        public Clothing(ColorType color, int size)
        {
            this.color = color;
            Size = size;
        } // ctor
        
    }



}
