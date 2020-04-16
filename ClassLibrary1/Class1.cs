using System;

namespace ClassLibrary1
{
    using System.Threading;
    using System.Threading.Tasks;

    public class Class1 : ISomeService
    {
        public async Task DoSomethingAsync(CancellationToken token)
        {
            Console.WriteLine("DoSomethingAsync Called");
            await Task.Delay(1000);
        }
    }
}