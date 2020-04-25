using Analogy.Interfaces;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Analogy.LogViewer.GenericProvider.Interfaces
{
    public interface IFileParser
    {
        Task<IEnumerable<IAnalogyLogMessage>> Process(string fileName, CancellationToken token, ILogMessageCreatedHandler messagesHandler);

    }

}
