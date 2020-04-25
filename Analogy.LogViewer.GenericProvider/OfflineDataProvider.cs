using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using Analogy.Interfaces;
using Analogy.LogViewer.GenericProvider.Managers;

namespace Analogy.LogViewer.GenericProvider
{
    public class OfflineDataProvider : IAnalogyOfflineDataProvider
    { 
        public Guid ID { get; } = new Guid("E1696270-97BE-489F-9440-453BEA1AB7B8");
        public string OptionalTitle { get; } = string.Empty;
        public bool UseCustomColors { get; set; } = false;
        public bool CanSaveToLogFile { get; } = false;
        public string FileOpenDialogFilters => UserSettingsManager.UserSettings.Settings.FileOpenDialogFilters;
        public string FileSaveDialogFilters { get; } = string.Empty;
        public IEnumerable<string> SupportFormats => UserSettingsManager.UserSettings.Settings.SupportFormats;
        public string InitialFolderFullPath { get; } = Environment.CurrentDirectory;
        public bool DisableFilePoolingOption { get; } = false;
        public IEnumerable<(string originalHeader, string replacementHeader)> GetReplacementHeaders()
            => Array.Empty<(string, string)>();

        public (Color backgroundColor, Color foregroundColor) GetColorForMessage(IAnalogyLogMessage logMessage)
            => (Color.Empty, Color.Empty);
        public async Task<IEnumerable<AnalogyLogMessage>> Process(string fileName, CancellationToken token,
            ILogMessageCreatedHandler messagesHandler)
        {
            var parser = new Parser();
            List<AnalogyLogMessage> messages = await parser.ParseLog(fileName, token, messagesHandler);
            return messages;
        }

        public IEnumerable<FileInfo> GetSupportedFiles(DirectoryInfo dirInfo, bool recursiveLoad)
            => GetSupportedFilesInternal(dirInfo, recursiveLoad);

        public Task SaveAsync(List<AnalogyLogMessage> messages, string fileName) => Task.CompletedTask;

        public bool CanOpenFile(string fileName)
        {
            foreach (string pattern in UserSettingsManager.UserSettings.Settings.SupportFormats)
            {
                if (PatternMatcher.StrictMatchPattern( pattern, fileName))
                    return true;
            }
            return false;
        } 
        private bool FitsMask(string fileName, string fileMask)
        {
            Regex mask = new Regex(fileName.Replace(".", "[.]").Replace("*", ".*").Replace("?", "."));
            return mask.IsMatch(fileMask);
        }
        public bool CanOpenAllFiles(IEnumerable<string> fileNames) => fileNames.All(CanOpenFile);


        public static List<FileInfo> GetSupportedFilesInternal(DirectoryInfo dirInfo, bool recursive)
        {
            List<FileInfo> files = dirInfo.GetFiles("*.log").ToList();
            if (!recursive)
                return files;
            try
            {
                foreach (DirectoryInfo dir in dirInfo.GetDirectories())
                {
                    files.AddRange(GetSupportedFilesInternal(dir, true));
                }
            }
            catch (Exception)
            {
                return files;
            }

            return files;
        }

        public Task InitializeDataProviderAsync(IAnalogyLogger logger)
        {
            LogManager.Instance.SetLogger(logger);
            return Task.CompletedTask;
        }

        public void MessageOpened(AnalogyLogMessage message)
        {
            //to nothing with information tat the messages was opened/read
        }

    }
}