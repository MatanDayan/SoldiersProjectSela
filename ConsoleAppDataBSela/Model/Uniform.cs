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

        public Uniform(bool shielding, ColorType color, int size, int serialNumber, string name, string uriImg, double price, int currentAmout, int starterAmount)
            : base(color, size, serialNumber, name, uriImg, price, currentAmout, starterAmount)
        {
            Shielding = shielding;
            ObjType = AbstractItemId.Uniform;
        }//ctor
    }
}
