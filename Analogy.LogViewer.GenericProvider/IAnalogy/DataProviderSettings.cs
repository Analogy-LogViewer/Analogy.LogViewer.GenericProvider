using Analogy.LogViewer.GenericProvider.Managers;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using Analogy.Interfaces;

namespace Analogy.LogViewer.GenericProvider.IAnalogy
{
    public abstract class GenericDataProviderSettings : IAnalogyDataProviderSettings
    {
        public Guid FactoryId { get; set; } = Factory.factoryId;
        public string Title { get; set; }
        public UserControl DataProviderSettings { get; }
        public Image SmallImage { get; set; }
        public Image LargeImage { get; set; }
        public Guid Id { get; set; }

        private IUserSettings Settings { get; }
        protected GenericDataProviderSettings(string title, Guid id, IUserSettings userSettings, UserControl dataProviderSettings = null, Image smallImage = null, Image largeImage = null)
        {
            Title = title ?? "Generic Provider";
            Settings = userSettings;
            DataProviderSettings = dataProviderSettings ?? new UserSetttingsUC();
            SmallImage = smallImage;
            LargeImage = largeImage;
            Id = id;
        }

        public Task SaveSettingsAsync()
        {
            Settings.Save();
            return Task.CompletedTask;
        }
    }
}
