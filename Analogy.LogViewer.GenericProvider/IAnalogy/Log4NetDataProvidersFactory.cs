using System;
using System.Collections.Generic;
using Analogy.Interfaces;
using Analogy.Interfaces.Factories;

namespace Analogy.LogViewer.GenericProvider.IAnalogy
{
    public class Log4NetDataProvidersFactory : IAnalogyDataProvidersFactory
    {
        public Guid FactoryId { get; } = Log4NetFactory.Log4NetFactoryId;
        public string Title { get; } = "Log4Net Data Providers";
        public IEnumerable<IAnalogyDataProvider> DataProviders { get; } = new List<IAnalogyDataProvider>
            {
                new OfflineDataProvider()
            };
    }
}
