namespace Analogy.LogViewer.GenericProvider.Managers
{
    public interface IUserSettings
    {
        string UserSettingFile { get; }
        bool Save();
        bool Load();
    }
}
