using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleAppDataBSela.Model.Enums;

namespace ConsoleAppDataBSela.Model
{
    class Player : AbstractItem
    {
        public Double Height { get; set; }
        public int Age { get; set; }
        public PlayerGender Gender { get; set; } //enum

    }
}
