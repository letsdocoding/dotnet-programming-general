using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace AsyncNewFeatures
{
    class HighResourceUser : IAsyncDisposable, IDisposable
    {
        private MemoryStream _memoryStream;
        public HighResourceUser()
        {
            _memoryStream = new MemoryStream();
        }
        public ValueTask DisposeAsync()
        {
            return default;
        }

        public void Dispose()
        {
            
        }
    }
}
