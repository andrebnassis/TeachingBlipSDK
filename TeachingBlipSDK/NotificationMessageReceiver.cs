using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Lime.Protocol;
using Takenet.MessagingHub.Client.Listener;

namespace TeachingBlipSDK
{

    class NotificationMessageReceiver : INotificationReceiver
    {
        public async Task ReceiveAsync(Notification envelope, CancellationToken cancellationToken = default(CancellationToken))
        {
            //throw new NotImplementedException();
        }
    }
}
