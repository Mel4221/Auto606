using System;
using QuickTools.QData;

namespace Auto606
{
    public class Auto606Settings
    {
        public const string SettingFile = "Auto606.settings"; 
        public string GetSetting(string setting)
        {
            string value = Null.Value; 
            MiniDB db = new MiniDB();
            db.Create(SettingFile);
            db.Load();
            DB request = db.SelectWhereKey(setting);
            if (request.Key == setting)
            {
                return request.Value;
            }
            return value; 
        }
    }
}
