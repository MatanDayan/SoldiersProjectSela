using ConsoleAppDataBSela.Model;
using ConsoleAppDataBSela.Model.Enums;
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

            //List<Player> players = JsonData.LoadDataPlayers().ToList();
            //List<AbstractItem> items = JsonData.LoadDataItems().ToList();



            // user
            Player player1 = new Player("Matan",1.80, 23, PlayerGender.Male);
            Player player2 = new Player("Agam",2.10, 27, PlayerGender.Female);
            Player player3 = new Player("Anztasia",1.56, 14, PlayerGender.Female);
            players.Add(player1);
            players.Add(player2);
            players.Add(player3);

            //items = to plaers
            AbstractItem item1 = new Backpack(StorageBag.BackpackLeval3, ColorType.Green,
                34, "34", "pictures/Backpacing/BackpackLeval3.png",
                387, 10, 0);

            AbstractItem item2 = new SecondaryWeapon(12, KnifeType.Leatherman, ColorType.Green, "Or", 1475, 78, true, 49029,
                "Gclass", "Pictures/WeaponImg/knife1.png",250,100,99);



            // add itmes to itmes list
            items.Add(item1);
            items.Add(item2);




            // add itmes to Player
            player1.AddItem(item1);
            player1.AddItem(item2);


            JsonData.SaveDataItems(items);
            JsonData.SaveDataUsers(players);




        }
    }
}
