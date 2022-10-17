// Decompiled with JetBrains decompiler
// Type: f1.Classes.AppSetting
// Assembly: f1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8176C681-E52F-4362-9348-6544A7AEFF71
// Assembly location: D:\Reverse Engineer\Lighthoues erp system - Copy\f1.exe
// Compiler-generated code is shown

using System.Configuration;
using static DevExpress.Data.Mask.BaseDateTimeMaskManager;

namespace Aswaq_Barcode
{
    internal class AppSetting
    {
        private System.Configuration.Configuration config;

        public AppSetting()
        {
            //base.\u002Ector();
            this.config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        }

        public string GetConnectionString(string key)
        {
            return this.config.ConnectionStrings.ConnectionStrings[key].ConnectionString;
        }

        public void SaveConnectionString(string key, string value)
        {
            this.config.ConnectionStrings.ConnectionStrings[key].ConnectionString = value;
            this.config.ConnectionStrings.ConnectionStrings[key].ProviderName = "System.Data.SqlClient";
            this.config.Save(ConfigurationSaveMode.Modified);
        }
    }
}
