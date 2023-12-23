using System;
using QuickTools.QCore;
using QuickTools.QData;

namespace Auto606
{
    public class Auto606Settings
    {
        public const string SettingFile = "Auto606.settings";
        private MiniDB db;
        public string GetSetting(string setting)
        {
            string value = Null.Value; 
            db = new MiniDB();
            db.Create(SettingFile);
            db.Load();
            DB request = db.SelectWhereKey(setting);
            Get.Yellow($"Getting Setting: {setting}");
            if (request.Key == setting)
            {
                Get.Yellow($"Value Exist returning: '{setting}'");
                return request.Value;
            }
            Get.Red($"Setting Not Found returning {value}");
            return value; 
        }
        public Auto606Settings()
        {
            Get.Yellow($"Auto606Settings Started...");
            db = new MiniDB();
            if(!db.Load(SettingFile))
            {
                Get.Red($"Settings File Not Found Creatting it... {SettingFile}");
                db.Create();
                db.AddKey("ByPassInit", "true", "DefaultConfig");
                db.SaveChanges();
                return;
            }
            else
            {
                Get.Yellow($"Settings Loaded!!!");
                return;
            }

        }
    }
}
