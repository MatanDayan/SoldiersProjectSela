using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleAppDataBSela.Model
{
    public class Player
    {
        public string Name { get; set; }
        public Double Height { get; set; }
        public int Age { get; set; }
        public PlayerGender Gender { get; set; } //enum
        public List<AbstractItem> PlayerItems { get; set; }

        public Player()
        {

        }
        public Player(string name , double height, int age, PlayerGender gender)
        {
            Name = name;
            Height = height;
            Age = age;
            Gender = gender;
            PlayerItems = new List<AbstractItem>();
        } 

        public void AddItem(AbstractItem item)
        {
            PlayerItems.Add(item);
        }

    }




    public enum PlayerGender
    {
        Male,
        Female
    }
}
