using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDataBSela.Model
{
    class Bag : Clothing
    {
        public StorageBag StorageLevel { get; set; } // enum

    }


     public enum StorageBag
    {
        Level1 = 100,
        level2 = 250,
        level3 = 500,
    }
}
