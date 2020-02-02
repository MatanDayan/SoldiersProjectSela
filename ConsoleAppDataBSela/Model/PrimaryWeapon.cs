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


        public PrimaryWeapon() // ctor null
        {

        }
        public PrimaryWeapon(int amountBalls, double shootingRange)
        {
            AmountBalls = amountBalls;
            ShootingRange = shootingRange;
        } // ctor
    }
}
