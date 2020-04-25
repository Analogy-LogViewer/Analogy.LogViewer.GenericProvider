using Newtonsoft.Json;
using System;
using System.IO;

namespace Analogy.LogViewer.GenericProvider.Managers
{
    public abstract class UserSettings<T> : IUserSettings where T : new()
    {
        public string UserSettingFile { get; }
        private T Settings { get; set; }

        public UserSettings(string userSettingFile)
        {
            UserSettingFile = userSettingFile ?? "AnalogyGenericProvider.Settings";
        }
        public bool Load()
        {
            if (File.Exists(UserSettingFile))
            {
                try
                {
                    var settings = new JsonSerializerSettings
                    {
                        ObjectCreationHandling = ObjectCreationHandling.Replace
                    };
                    string data = File.ReadAllText(UserSettingFile);
                    Settings = JsonConvert.DeserializeObject<T>(data, settings);
                }
                catch (Exception ex)
                {
                    LogManager.Instance.LogCritical("", $"Unable to read file {UserSettingFile}: {ex}");
                }
            }
            else
            {
                Settings = new T();
            }

            return true;
        }
        public bool Save()
        {
            try
            {
                File.WriteAllText(UserSettingFile, JsonConvert.SerializeObject(Settings));
                return true;
            }
            catch (Exception ex)
            {
                LogManager.Instance.LogCritical("", $"Unable to save file {UserSettingFile}: {ex}");
                return false;
            }
        }
    }
}
