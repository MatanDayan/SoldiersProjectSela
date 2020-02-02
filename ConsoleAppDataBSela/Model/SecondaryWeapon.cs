using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDataBSela.Model
{
   public class SecondaryWeapon : Weapon
    {
        public int KnifeLength { get; set; }
        public KnifeType TypeKnife { get; set; } // enum

        
        public SecondaryWeapon(int knifeLength, KnifeType typeKnife, ColorType color, string creator, int year, int firePower, bool automatic, int serialNumber, string name, string uriImg, double price, int currentAmout, int starterAmount) 
            : base(color, creator, year, firePower, automatic, serialNumber, name, uriImg, price, currentAmout, starterAmount)
        {
            KnifeLength = knifeLength;
            TypeKnife = typeKnife;
        } // ctor
    }

    public enum KnifeType
    {
        Commando,
        Leatherman,
    }
}
