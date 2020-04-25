using Analogy.Interfaces;
using Analogy.Interfaces.Factories;
using System;
using System.Collections.Generic;

namespace Analogy.LogViewer.GenericProvider.IAnalogy
{
    public abstract class DataProvidersFactory : IAnalogyDataProvidersFactory
    {
        public Guid FactoryId { get; } = Factory.factoryId;
        public string Title { get; }
        public IEnumerable<IAnalogyDataProvider> DataProviders { get; }

        protected DataProvidersFactory(string title, IEnumerable<IAnalogyDataProvider> dataProviders)
        {
            Title = title ?? "Generic Factory";
            DataProviders = dataProviders ?? Array.Empty<IAnalogyDataProvider>();
        }
    }
}
