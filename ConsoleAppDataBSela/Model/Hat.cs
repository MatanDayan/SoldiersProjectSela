using ConsoleAppDataBSela.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDataBSela.Model
{
    class Hat : Clothing
    {
        public HatType HatType { get; set; } // enum

        public Hat(HatType hatType, ColorType color, int size, int serialNumber, string name, string uriImg, double price, int currentAmout, int starterAmount)
            : base(color, size, serialNumber, name, uriImg, price, currentAmout, starterAmount)
        {
            HatType = hatType;
            ObjType = AbstractItemId.Hat;
        }
    }
}
