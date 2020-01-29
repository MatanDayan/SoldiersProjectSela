using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDataBSela.Model
{

   public class Weapon : AbstractItem
    {
        public string Coler { get; set; }
        public string Creator { get; set; } 
        public int Yaer { get; set; }
        public int FierPower { get; set; }
        public bool Automatic { get; set; }

    }
}
