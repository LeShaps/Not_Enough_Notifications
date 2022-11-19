using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotEnoughNotifications.Config
{
    internal class ConfigReader
    {
        public static List<AddonConfig> Addons = new List<AddonConfig>();

        public static bool LoadConfig()
        {
            JObject AddonConfigJson = JsonConvert.DeserializeObject<JObject>(File.ReadAllText("Config/Addons.json"));

            if (AddonConfigJson != null && AddonConfigJson.Value<bool>("Verified")) {
                Addons = AddonConfigJson.Value<JArray>("Addons")
                         .ToObject<List<AddonConfig>>();

                return true;
            }

            return false;
        }
    }
}
