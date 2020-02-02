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

        public Hat()// ctor null
        {

        }
        public Hat(HatType hatType)
        {
            HatType = hatType;
        } // ctor 
    }


    public enum HatType
    {
        hat1,
        hat2,
        hat3,
        santaHet
    }
}
