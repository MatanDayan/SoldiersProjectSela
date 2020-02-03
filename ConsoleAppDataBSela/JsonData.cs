using ConsoleAppDataBSela.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDataBSela
{
    public class JsonData
    {

        public static void SaveDataUsers(List<Player> Players) 
        {
            using (StreamWriter file = File.CreateText("players.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, Players);
            }
        }

        public static IEnumerable<Player> LoadDataPlayers() 
        {
            if (File.Exists("players.json"))
            {
                using (StreamReader file = File.OpenText("players.json"))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    serializer.Converters.Add(new BaseConverter());
                    return (List<Player>)serializer.Deserialize(file, typeof(List<Player>));
                }
            }
            return new List<Player>();
        }


        public static void SaveDataItems(List<AbstractItem> Items) 
        {
            using (StreamWriter file = File.CreateText("items.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, Items);
            }
        }

        public static IEnumerable<AbstractItem> LoadDataItems() 
        {
            if (File.Exists("items.json"))
            {
                using (StreamReader file = File.OpenText("items.json"))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    serializer.Converters.Add(new BaseConverter());
                    return (List<AbstractItem>)serializer.Deserialize(file, typeof(List<AbstractItem>));
                }
            }
            return new List<AbstractItem>();
        }

        public static void ClearDataPlayers()
        {
            if (File.Exists("players.json"))
                File.Delete("players.json");
        }

        public static void ClearDataItems()
        {
            if (File.Exists("items.json"))
            {
                File.Delete("items.json");
            }
        }
    }
}
