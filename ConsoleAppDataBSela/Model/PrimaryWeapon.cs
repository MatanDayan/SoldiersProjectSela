using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDataBSela.Model
{
    class PrimaryWeapon : Weapon
    {
        public int AmountBalls { get; set; }
        public double ShootingRange { get; set; }
       
        public PrimaryWeapon(int amountBalls, double shootingRange , ColorType color, string creator, int year, int firePower, bool automatic, int serialNumber, string name, string uriImg, double price, int currentAmout, int starterAmount)
            : base(color ,creator,year,firePower,automatic,serialNumber, name, uriImg, price, currentAmout, starterAmount)
        {
            AmountBalls = amountBalls;
            ShootingRange = shootingRange;
            ObjType = AbstractItemId.PrimaryWeapon;
        } // ctor
    }
}
