using System;
using System.IO;
using Newtonsoft.Json;

namespace Analogy.LogViewer.GenericProvider.Managers
{
    public class UserSettingsManager
    {
        private static readonly Lazy<UserSettingsManager> _instance =
            new Lazy<UserSettingsManager>(() => new UserSettingsManager());
        public static UserSettingsManager UserSettings { get; set; } = _instance.Value;
        private string RepositoriesSettingFile { get; } = "AnalogyLog4net.Settings";
        public UserSettings Settings { get; }

        public UserSettingsManager()
        {         
            if (File.Exists(RepositoriesSettingFile))
            {
                try
                {
                    var settings = new JsonSerializerSettings
                    {
                        ObjectCreationHandling = ObjectCreationHandling.Replace
                    };
                    string data = File.ReadAllText(RepositoriesSettingFile);
                    Settings = JsonConvert.DeserializeObject<UserSettings>(data,settings);
                }
                catch (Exception ex)
                {
                    LogManager.Instance.LogCritical("", $"Unable to read file {RepositoriesSettingFile}: {ex}");
                }
            }
            else
            { 
                Settings = new UserSettings(); 
            }
        }

        public void Save()
        {
            try
            {
                File.WriteAllText(RepositoriesSettingFile, JsonConvert.SerializeObject(Settings));
            }
            catch (Exception ex)
            {
                LogManager.Instance.LogCritical("", $"Unable to save file {RepositoriesSettingFile}: {ex}");

            }


        }
    }
}
