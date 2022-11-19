using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NotEnoughNotifications.Extensions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotEnoughNotifications
{
    internal class FileUtilities
    {
        public static T JsonWalker<T>(JObject OriginalJson, string Path)
        {
            string[] SplitedPath = Path.Split('/');
            string ValueName = SplitedPath.Last();
            JObject FinalJson = OriginalJson;

            foreach (string Part in SplitedPath.SkipLast())
            {
                if (FinalJson[Part].Type == JTokenType.Array)
                {
                    FinalJson = FinalJson.Value<JArray>(Part)[0].ToObject<JObject>();
                }
                else
                {
                    FinalJson = FinalJson[Part].ToObject<JObject>();
                }
            }

            return FinalJson.Value<T>(ValueName);
        }

        public static T LoadJsonFromFile<T>(string path)
        {
            string Result = File.ReadAllText(path);
            return JsonConvert.DeserializeObject<T>(Result);
        }
    }
}
