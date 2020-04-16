// <copyright>
//     Copyright (c) AIS Automation Dresden GmbH. All rights reserved.
// </copyright>

namespace ClassLibrary1
{
    using System.Threading;
    using System.Threading.Tasks;

    public interface ISomeService
    {
        Task DoSomethingAsync(CancellationToken token);
    }
}