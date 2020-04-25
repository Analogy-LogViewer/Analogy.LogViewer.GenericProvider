using System;
using System.Collections.Generic;

namespace Analogy.LogViewer.GenericProvider
{

    [Serializable]
    public class OfflineDataProviderUserSettingsContainer
    {
        public string OptionalTitle { get; set; }
        public bool UseCustomColors { get; set; }
        public string FileOpenDialogFilters { get; set; }
        public string FileSaveDialogFilters { get; set; }
        public IEnumerable<string> SupportFormats { get; set; }
        public string InitialFolderFullPath { get; set; }
        public bool DisableFilePoolingOption { get; set; }

        public OfflineDataProviderUserSettingsContainer()
        {

        }

        public OfflineDataProviderUserSettingsContainer(string optionalTitle, bool useCustomColors, string fileOpenDialogFilters, string fileSaveDialogFilters, IEnumerable<string> supportFormats, string initialFolderFullPath, bool disableFilePoolingOption)
        {
            OptionalTitle = optionalTitle;
            UseCustomColors = useCustomColors;
            FileOpenDialogFilters = fileOpenDialogFilters;
            FileSaveDialogFilters = fileSaveDialogFilters;
            SupportFormats = supportFormats;
            InitialFolderFullPath = initialFolderFullPath;
            DisableFilePoolingOption = disableFilePoolingOption;
        }
    }

    public class OfflineDataProviderContainer : OfflineDataProviderUserSettingsContainer
    {
        public Guid ID { get; set; }
        public bool CanSaveToLogFile { get; }

        public OfflineDataProviderContainer()
        {

        }

        public OfflineDataProviderContainer(Guid id, string optionalTitle, bool useCustomColors, bool canSaveToLogFile,
            string fileOpenDialogFilters, string fileSaveDialogFilters, IEnumerable<string> supportFormats,
            string initialFolderFullPath, bool disableFilePoolingOption) : base(optionalTitle, useCustomColors,
            fileOpenDialogFilters, fileSaveDialogFilters, supportFormats, initialFolderFullPath,
            disableFilePoolingOption)
        {
            ID = id;
            UseCustomColors = useCustomColors;
            CanSaveToLogFile = canSaveToLogFile;
        }
    }
}
