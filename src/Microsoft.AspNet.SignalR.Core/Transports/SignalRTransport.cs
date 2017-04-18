using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.AspNet.SignalR.Transports
{
    public enum SignalRTransport : byte
    {
        Unknown = 0,
        WebSockets = 1,
        ServerSentEvents = 2,
        ForeverFrame = 3,
        LongPolling = 4
    }
}