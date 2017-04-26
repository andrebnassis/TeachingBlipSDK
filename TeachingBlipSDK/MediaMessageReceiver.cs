using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Lime.Protocol;
using Takenet.MessagingHub.Client.Listener;
using Takenet.MessagingHub.Client.Sender;
using Takenet.MessagingHub.Client;

namespace TeachingBlipSDK
{
    class MediaMessageReceiver : IMessageReceiver
    {
        private readonly IMessagingHubSender _sender;

        public MediaMessageReceiver(IMessagingHubSender sender)
        {
            _sender = sender;
        }
        public async Task ReceiveAsync(Message envelope, CancellationToken cancellationToken = default(CancellationToken))
        {
            await _sender.SendMessageAsync("Sorry, I cannot understand media yet", envelope.From, cancellationToken);
        }
    }
}
