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


        public Clothing(ColorType color, int size, int serialNumber, string name, string uriImg, double price, int currentAmout, int starterAmount) 
            : base(serialNumber,name,uriImg,price,currentAmout,starterAmount)
        {
            this.color = color;
            Size = size;
        } // ctor
        
    }



}
