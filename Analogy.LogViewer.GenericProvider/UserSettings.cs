using System.Collections.Generic;

namespace Analogy.LogViewer.GenericProvider
{
    public class UserSettings
    {
        public string FileOpenDialogFilters { get; set; }
        public string FileSaveDialogFilters { get; } = string.Empty;
        public List<string> SupportFormats { get; set; }
        public string LogsLocation { get; set; }
        public RegExPattern RegExPattern { get; set; }

        public UserSettings()
        {
            LogsLocation = string.Empty;
            FileOpenDialogFilters = "Plain log text file (*.log)|*.log";
            SupportFormats = new List<string> { "*.log" };
            RegExPattern = new RegExPattern();
        }

    }
}
