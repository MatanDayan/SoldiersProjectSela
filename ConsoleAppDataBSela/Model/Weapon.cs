using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDataBSela.Model
{

   public class Weapon : AbstractItem
    {

        public ColorType Color { get; set; } //enum
        public string Creator { get; set; } 
        public int Year { get; set; }
        public int FirePower { get; set; }
        public bool Automatic { get; set; } // You can change that to enum

        
        public Weapon(ColorType color, string creator, int year, int firePower, bool automatic, int serialNumber, string name, string uriImg, double price, int currentAmout, int starterAmount)
            : base(serialNumber, name, uriImg, price, currentAmout, starterAmount)
        {
            Color = color;
            Creator = creator;
            Year = year;
            FirePower = firePower;
            Automatic = automatic;
        } // ctor 


    }
}
