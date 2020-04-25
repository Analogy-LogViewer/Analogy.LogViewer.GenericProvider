using System.Collections.Generic;

namespace Analogy.LogViewer.GenericProvider.Managers
{
    public interface IUserSettings
    {
        string UserSettingFile { get; }
        IReadOnlyList<OfflineDataProviderContainer> OfflineDataProviderContainers { get; }
        IReadOnlyList<OnlineDataProviderContainer> OnlineDataProviderContainers { get; }
        bool Save();
        bool Load();
    }
}
