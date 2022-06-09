using EventStore.ClientAPI;

namespace EventSourcing
{
    public interface IEventStoreService
    {
        IEventStoreConnection GetConnection();
    }

}

//www.eventstore.com/
//docker pull eventstore / eventstore
//docker run --name eventstore-node -it -p 2113:2113 - p 1113:1113 eventstore / eventstore:latest--insecure--run - projections = All--enable - external - tcp--enable - atom - pub - over - http
//127.0.0.1:2113/web/index.html#/dashboard
//install-package EventStore.Client -v 5.0.2
//install-package Microsoft.Extensions.Configuration -v 2.2.0