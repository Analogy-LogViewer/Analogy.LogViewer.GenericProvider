using System.Collections.Generic;

namespace Analogy.LogViewer.GenericProvider.Managers
{
    public interface IUserSettings
    {
        string UserSettingFile { get; }
        IReadOnlyList<OfflineDataProviderContainer> OfflineDataProviderContainers { get; set; }
        IReadOnlyList<OnlineDataProviderContainer> OnlineDataProviderContainers { get; set; }
        bool Save();

    }
}
