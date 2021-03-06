using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Takenet.MessagingHub.Client;
using Takenet.MessagingHub.Client.Sender;
using Takenet.MessagingHub.Client.Listener;
using System.Diagnostics;
using System;
using Takenet.MessagingHub.Client.Extensions.Bucket;
using Lime.Protocol.Serialization;

namespace TeachingBlipSDK
{
    public class Startup : IStartable
    {
        private readonly IMessagingHubSender _sender;
        private readonly IDictionary<string, object> _settings;

        public Startup(IMessagingHubSender sender, IDictionary<string, object> settings)
        {
            _sender = sender;
            _settings = settings;
        }

        public Task StartAsync(CancellationToken cancellationToken)
        {
            TypeUtil.RegisterDocument<NoDocumentObjectExample>();
			Trace.Listeners.Add(new TextWriterTraceListener(Console.Out)); 
            return Task.CompletedTask;
        }
    }
}
