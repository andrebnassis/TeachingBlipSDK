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
using Lime.Messaging.Contents;

namespace TeachingBlipSDK
{
    class LocationMessageReceiver : IMessageReceiver
    {
        private readonly IMessagingHubSender _sender;
        public LocationMessageReceiver(IMessagingHubSender sender)
        {
            _sender = sender;
        }
        public async Task ReceiveAsync(Message envelope, CancellationToken cancellationToken = default(CancellationToken))
        {
            var location = (Location)envelope.Content;
            var lat = location.Latitude;
            var lon = location.Longitude;
            
            await _sender.SendMessageAsync("Location received!", envelope.From, cancellationToken);
        }
    }
}
