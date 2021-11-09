using System;
using System.IO;
using System.Text;
using System.Text.Json;

namespace StatisticsAnalysisTool.Common.AppSettings
{
    public static class SettingsController
    {
        public static SettingsObject CurrentSettings = new();

        public static bool Load()
        {
            var localFilePath = $"{AppDomain.CurrentDomain.BaseDirectory}{SettingsDefault.SettingsFileName}";

            if (File.Exists(localFilePath))
            {
                try
                {
                    var settingsString = File.ReadAllText(localFilePath, Encoding.UTF8);
                    CurrentSettings = JsonSerializer.Deserialize<SettingsObject>(settingsString) ?? new SettingsObject();
                    return true;
                }
                catch (Exception e)
                {
                    return false;
                }
            }

            return false;
        }

        public static void Save()
        {
            var localFilePath = $"{AppDomain.CurrentDomain.BaseDirectory}{SettingsDefault.SettingsFileName}";

            try
            {
                var fileString = JsonSerializer.Serialize(CurrentSettings);
                File.WriteAllText(localFilePath, fileString, Encoding.UTF8);
            }
            catch (Exception e)
            {
            }
        }
    }
}