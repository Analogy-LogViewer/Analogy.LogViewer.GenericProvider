using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace Analogy.LogViewer.GenericProvider.Managers
{
    public abstract class UserSettings<T> : IUserSettings where T : new()
    {
        public string UserSettingFile { get; }
        public IReadOnlyList<OfflineDataProviderContainer> OfflineDataProviderContainers { get; set; }
        public IReadOnlyList<OnlineDataProviderContainer> OnlineDataProviderContainers { get; set; }
        private T Settings { get; set; }

        public UserSettings(string userSettingFile, IReadOnlyList<OfflineDataProviderContainer> offlineDataProviderContainers = null, IReadOnlyList<OnlineDataProviderContainer> onlineDataProviderContainers = null)
        {
            UserSettingFile = userSettingFile ?? "AnalogyGenericProvider.Settings";
            OfflineDataProviderContainers = offlineDataProviderContainers ?? Array.Empty<OfflineDataProviderContainer>();
            OnlineDataProviderContainers = onlineDataProviderContainers ?? Array.Empty<OnlineDataProviderContainer>();
        }
        public static UserSettings<T> Load<T>(string filename) where T : new()
        {
            if (File.Exists(filename))
            {
                try
                {
                    var settings = new JsonSerializerSettings
                    {
                        ObjectCreationHandling = ObjectCreationHandling.Replace
                    };
                    string data = File.ReadAllText(filename);
                    return JsonConvert.DeserializeObject<UserSettings<T>>(data, settings);
                }
                catch (Exception ex)
                {
                    LogManager.Instance.LogCritical("", $"Unable to read file {filename}: {ex}");
                }
            }
            else
            {
                return new UserSettings<T>();
            }


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
