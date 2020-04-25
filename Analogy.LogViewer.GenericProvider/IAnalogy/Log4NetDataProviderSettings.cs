using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using Analogy.DataProviders.Extensions;
using Analogy.LogViewer.GenericProvider.Managers;

namespace Analogy.LogViewer.GenericProvider.IAnalogy
{
    public class Log4NetDataProviderSettings : IAnalogyDataProviderSettings
    {
        public string Title { get; } = "Log4Net settings";
        public UserControl DataProviderSettings { get; } = new UserSetttingsUC();
        public Image SmallImage { get; }
        public Image LargeImage { get; }
        public Guid FactoryId { get; set; } = Log4NetFactory.Log4NetFactoryId;
        public Guid ID { get; set; } = new Guid("2D09F7E7-C55E-41B0-8068-A474D2361F85");

        public Task SaveSettingsAsync()
        {
            UserSettingsManager.UserSettings.Save();
            return Task.CompletedTask;
        }
    }
}
