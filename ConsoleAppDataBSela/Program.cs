using ConsoleAppDataBSela.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;


namespace ConsoleAppDataBSela
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Player> players = new List<Player>();
            List<AbstractItem> items = new List<AbstractItem>();

            Player p = new Player(27, 23, PlayerGender.Male);

            players.Add(p);




            AbstractItem item1 = new Backpack(StorageBag.BackpackLeval3, ColorType.Green, 34,
                34, "34", "pictures/Backpacing/BackpackLeval3.png",
                387, 10, 0);

            items.Add(item1);
            items.Add(item1);
            items.Add(item1);
            items.Add(item1);
            items.Add(item1);
            items.Add(item1);
            items.Add(item1);





            p.AddItem(item1);

            JsonData.SaveDataItems(items);
            JsonData.SaveDataUsers(players);




        }
    }
}
