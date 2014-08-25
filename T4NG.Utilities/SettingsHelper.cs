using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace T4NG.Utilities
{
    public static class SettingsHelper
    {
        public static SettingsModel Settings { get; set; }

        public static void LoadSettings(string settingsFile)
        {
            using (StreamReader r = new StreamReader(settingsFile))
            {
                string json = r.ReadToEnd();
                Settings = JsonConvert.DeserializeObject<SettingsModel>(json);
            }
        }
    }
}
