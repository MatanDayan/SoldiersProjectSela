using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleAppDataBSela.Model
{
    public abstract class AbstractItem 
    {
        public AbstractItemId ObjType { get; set; }
        public int SerialNumber { get; set; }// Id
        public string Name { get; set; } // null
        public string UriImg { get; set; }
        public double Price { get; set; }
        public int CurrentAmout { get; set; }
        public int StarterAmount { get; set; }
        
        public AbstractItem(int serialNumber, string name, string uriImg, double price, int currentAmout, int starterAmount)
        {
            SerialNumber = serialNumber;
            Name = name;
            UriImg = uriImg;
            Price = price;
            CurrentAmout = currentAmout;
            StarterAmount = starterAmount;
        } // ctor null
    }

    public enum ColorType
    {
        Red,
        Blue,
        Yellow,
        Black,
        Green
    }
}
