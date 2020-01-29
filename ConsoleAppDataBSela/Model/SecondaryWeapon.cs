using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleAppDataBSela.Model.Enums;

namespace ConsoleAppDataBSela.Model
{
   public class SecondaryWeapon : Weapon
    {
        public int KnifeLength { get; set; }
        public KnifeType TypeKnife { get; set; }
        
    }
}
