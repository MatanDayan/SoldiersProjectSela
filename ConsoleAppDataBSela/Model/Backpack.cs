using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDataBSela.Model
{
    class Backpack : Clothing
    {
        public StorageBag StorageLevel { get; set; } // enum

    }


     public enum StorageBag
    {
        BackpackLeval1 = 100,
        BackpackLeval2 = 250,
        BackpackLeval3 = 500
    }
}
