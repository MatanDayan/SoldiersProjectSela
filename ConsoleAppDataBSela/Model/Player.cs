using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleAppDataBSela.Model
{
    class Player 
    {
        public Double Height { get; set; }
        public int Age { get; set; }
        public PlayerGender Gender { get; set; } //enum
        public List<AbstractItem> PlayerItem { get; set; }

    }


    public enum PlayerGender
    {
        Male,
        Female
    }
}
