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

        public SecondaryWeapon()
        {

        }// ctor null
        public SecondaryWeapon(int knifeLength, KnifeType typeKnife)
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
