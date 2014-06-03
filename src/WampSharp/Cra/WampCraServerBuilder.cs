﻿using WampSharp.Core.Contracts.V1;
using WampSharp.Core.Serialization;
using WampSharp.PubSub.Server;
using WampSharp.Rpc.Server;

namespace WampSharp.Cra
{
    public class WampCraServerBuilder<TMessage> : WampServerBuilder<TMessage>, IWampCraServerBuilder<TMessage>
    {
        private readonly WampCraAuthenticaticatorBuilder<TMessage> mCraAuthenticaticatorBuilder;

        public WampCraServerBuilder(WampCraAuthenticaticatorBuilder<TMessage> craAuthenticaticatorBuilder)
        {
            mCraAuthenticaticatorBuilder = craAuthenticaticatorBuilder;
        }

        public void InitializeAuthenticationBuilder(IWampFormatter<TMessage> formatter,
            IWampRpcMetadataCatalog rpcMetadataCatalog,
            IWampTopicContainerExtended<TMessage> topicContainer)
        {
            mCraAuthenticaticatorBuilder.Initialize(formatter, rpcMetadataCatalog, topicContainer);
        }

        public override IWampServer<TMessage> Build(IWampFormatter<TMessage> formatter,
            IWampRpcMetadataCatalog rpcMetadataCatalog,
            IWampTopicContainerExtended<TMessage> topicContainer)
        {
            IWampRpcServer<TMessage> rpcServer = BuildRpcServer(formatter, rpcMetadataCatalog);
            IWampPubSubServer<TMessage> pubSubServer = BuildPubSubServer(formatter, topicContainer);
            IWampAuxiliaryServer auxiliaryServer = BuildAuxiliaryServer(formatter);

            WampCraServer<TMessage> server =
                new WampCraServer<TMessage>(mCraAuthenticaticatorBuilder, rpcServer, rpcMetadataCatalog, pubSubServer,
                    auxiliaryServer);

            return server;
        }
    }
}