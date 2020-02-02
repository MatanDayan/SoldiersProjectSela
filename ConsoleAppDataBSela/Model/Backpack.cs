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


        public Backpack(StorageBag storageLevel, ColorType color, int size, int serialNumber, string name, string uriImg, double price, int currentAmout, int starterAmount)
            : base(color, size, serialNumber, name, uriImg, price, currentAmout, starterAmount)
        {
            StorageLevel = storageLevel;
        } // ctor

    }


    public enum StorageBag
    {
        BackpackLeval1 = 100,
        BackpackLeval2 = 250,
        BackpackLeval3 = 500
    }
}
