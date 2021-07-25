using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncNewFeatures
{
    class AsyncStreamFeatures
    {
        public async Task Execute()
        {
            Console.WriteLine($"Start: {DateTime.Now.ToLongTimeString()}");

            //sync operation
            //var numbers = GetNumbers(1, 10);
            //Console.WriteLine(string.Join(Environment.NewLine,numbers));

            //async operations
            var cancellationTokenSource = new CancellationTokenSource();
            //cancellationTokenSource.CancelAfter(3000);
            var numbersAsync = GetNumberAsync(1, 10, cancellationTokenSource.Token)
                .ConfigureAwait(false);

            await foreach (var number in numbersAsync)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine($"Start: {DateTime.Now.ToLongTimeString()}");
        }
        async IAsyncEnumerable<int> GetNumberAsync(int start, int end,
            [EnumeratorCancellation] CancellationToken token = default)
        {
            var random = new Random();
            for (int i = start; i < end; i++)
            {
                await Task.Delay(random.Next(500, 1500), token);
                yield return i;
            }
        }

        IEnumerable<int> GetNumbers(int start, int end)
        {
            var random = new Random();
            var returnList = new List<int>();
            for (int i = start; i < end; i++)
            {
                returnList.Add(i);
                Thread.Sleep(random.Next(500, 1500));
            }

            return returnList;
        }
    }
}
