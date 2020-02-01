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

    }
}
