using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Http.Json;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;
using Newtonsoft.Json;

namespace ConsoleApp1
{
    internal class Json
    {
        public static void Serialize(List<Player> list)
        {
            File.WriteAllText("C:\\Users\\Admin\\Desktop\\Json.json", JsonConvert.SerializeObject(list));
        }
        public static List<Player> Deserialize()
        {
            return JsonConvert.DeserializeObject<List<Player>>(File.ReadAllText("C:\\Users\\Admin\\Desktop\\Json.json"));
        }
        public static bool SearchPlayer(List<Player> list, string Name)
        {
            foreach (var element in list)
            {
                if (element.Name == Name)
                {
                    return true;
                }
            }
            return false;
        }
    }
}