using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleAppDataBSela.Model.Enums;

namespace ConsoleAppDataBSela.Model
{
    class Bag : Clothing
    {
        public StorageBag StorageLevel { get; set; } // enum
    }
}
