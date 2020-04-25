using Analogy.Interfaces;
using Analogy.Interfaces.Factories;
using System;
using System.Collections.Generic;

namespace Analogy.LogViewer.GenericProvider.IAnalogy
{
    public abstract class Factory : IAnalogyFactory
    {
        internal static Guid factoryId;
        public Guid FactoryId { get; } = factoryId;
        public string Title { get; }
        public IEnumerable<IAnalogyChangeLog> ChangeLog { get; }
        public IEnumerable<string> Contributors { get; }
        public string About { get; }

        protected Factory(Guid primaryFactoryId, string title, IEnumerable<IAnalogyChangeLog> changeLog, IEnumerable<string> contributors, string about)
        {
            factoryId = primaryFactoryId;
            Title = title ?? "Generic Factory";
            ChangeLog = changeLog ?? Array.Empty<IAnalogyChangeLog>();
            Contributors = contributors ?? Array.Empty<string>();
            About = about ?? string.Empty;
        }



    }
}
