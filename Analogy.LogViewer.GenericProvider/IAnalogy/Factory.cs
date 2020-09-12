using Analogy.Interfaces;
using Analogy.Interfaces.Factories;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace Analogy.LogViewer.GenericProvider.IAnalogy
{
    public abstract class Factory : IAnalogyFactory
    {
        internal static Guid factoryId;
        public Guid FactoryId { get; set; } = factoryId;
        public string Title { get; set; }
        public IEnumerable<IAnalogyChangeLog> ChangeLog { get; set; }
        public Image LargeImage { get; set; }
        public Image SmallImage { get; set; }
        public IEnumerable<string> Contributors { get; set; }
        public string About { get; set; }

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
