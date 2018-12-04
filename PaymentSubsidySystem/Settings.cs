using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace PaymentSubsidySystem
{
    class Settings
    {
        public static String GetConnectionString()
        {
            String ConnectionString = "";
            String settingsPath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Settings.json");

            String json;
            using (StreamReader trmRead = new StreamReader(settingsPath)) { json = trmRead.ReadToEnd(); }

            JavaScriptSerializer javaScriptSerializer = new JavaScriptSerializer();
            Entities.Settings settings = javaScriptSerializer.Deserialize<Entities.Settings>(json);

            ConnectionString = settings.ConnectionString;

            return ConnectionString;
        }
    }
}
