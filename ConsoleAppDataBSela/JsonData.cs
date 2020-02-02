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

        public static void SaveDataUsers(List<Player> users) // serialize 
        {
            using (StreamWriter file = File.CreateText("players.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, users);
            }
        }

        public static IEnumerable<Player> LoadDataUsers() // deserialize 
        {
            if (File.Exists("players.json"))
            {
                using (StreamReader file = File.OpenText("players.json"))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    return (List<Player>)serializer.Deserialize(file, typeof(List<Player>));
                }
            }
            return new List<Player>();
        }


        public static void SaveDataItems(List<AbstractItem> journals) //serialize 
        {
            using (StreamWriter file = File.CreateText("items.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, journals);
            }
        }

        public static IEnumerable<AbstractItem> LoadDataItems() //deserialize
        {
            if (File.Exists("items.json"))
            {
                using (StreamReader file = File.OpenText("items.json"))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    return (List<AbstractItem>)serializer.Deserialize(file, typeof(List<AbstractItem>));
                }
            }
            return new List<AbstractItem>();
        }

        public static void ClearDataBook()
        {
            if (File.Exists("players.json"))
                File.Delete("players.json");
        }

        public static void ClearDataJournal()
        {
            if (File.Exists("items.json"))
            {
                File.Delete("items.json");
            }
        }
    }
}
