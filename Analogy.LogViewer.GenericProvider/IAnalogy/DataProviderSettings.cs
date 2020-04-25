using Analogy.DataProviders.Extensions;
using Analogy.LogViewer.GenericProvider.Managers;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Analogy.LogViewer.GenericProvider.IAnalogy
{
    public abstract class GenericDataProviderSettings : IAnalogyDataProviderSettings
    {
        public Guid FactoryId { get; set; } = Factory.factoryId;
        public string Title { get; }
        public UserControl DataProviderSettings { get; }
        public Image SmallImage { get; }
        public Image LargeImage { get; }
        public Guid ID { get; set; }

        private IUserSettings Settings { get; }
        protected GenericDataProviderSettings(string title, Guid id, IUserSettings userSettings, UserControl dataProviderSettings = null, Image smallImage = null, Image largeImage = null)
        {
            Title = title ?? "Generic Provider";
            Settings = userSettings;
            DataProviderSettings = dataProviderSettings ?? new UserSetttingsUC();
            SmallImage = smallImage;
            LargeImage = largeImage;
            ID = id;
        }

        public Task SaveSettingsAsync()
        {
            Settings.Save();
            return Task.CompletedTask;
        }
    }
}
