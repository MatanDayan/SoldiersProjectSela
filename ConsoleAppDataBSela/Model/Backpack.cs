using ConsoleAppDataBSela.Model.Enums;
using ConsoleAppDataBSela.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDataBSela.Model
{
    class Backpack : AbstractItem, Wearable
    {
        public StorageBag StorageLevel { get; set; } // enum
        public ColorType Color { get; set; } // enum

        public Backpack(StorageBag storageLevel, ColorType color, int serialNumber, string name, string uriImg, double price, int currentAmout, int starterAmount)
            : base(serialNumber, name, uriImg, price, currentAmout, starterAmount)
        {
            StorageLevel = storageLevel;
            Color = color;
            ObjType = AbstractItemId.Backpack;
        } // ctor
    }
}
