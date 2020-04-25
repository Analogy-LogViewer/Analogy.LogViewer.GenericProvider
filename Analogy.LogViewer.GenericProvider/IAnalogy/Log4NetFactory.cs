using Analogy.Interfaces;
using Analogy.Interfaces.Factories;
using System;
using System.Collections.Generic;

namespace Analogy.LogViewer.GenericProvider.IAnalogy
{
    public abstract class Factory : IAnalogyFactory
    {
        internal static Guid factoryId;
        public Guid FactoryId { get; } = Log4NetFactoryId;
        public string Title { get; } = "Log4Net Parser";
        public IEnumerable<IAnalogyChangeLog> ChangeLog { get; } = ChangeLogList.GetChangeLog();
        public IEnumerable<string> Contributors { get; } = new List<string> { "Lior Banai" };
        public string About { get; } = "Log4Net Parser for Analogy Log Viewer";



    }
}
