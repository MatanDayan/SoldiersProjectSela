using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleAppDataBSela.Model.Enums;

namespace ConsoleAppDataBSela.Model
{
    class Bag : AbstractItem
    {
        public StorageBag StorageLevel { get; set; } // enum
        public ColorType Color { get; set; } // enum
        
    }
}
