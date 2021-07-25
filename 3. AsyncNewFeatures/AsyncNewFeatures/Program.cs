using System;
using System.Threading.Tasks;

namespace AsyncNewFeatures
{
    class Program
    {
        static async Task Main(string[] args)
        {
            ////////////////////Async Stream
            var asyncStreamInstance = new AsyncStreamFeatures();
            await asyncStreamInstance.Execute();
            Console.ReadLine();
        }


    }
}
