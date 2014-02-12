﻿using Newtonsoft.Json.Linq;
using WampSharp.Core.Listener;
using WampSharp.Core.Serialization;
using WampSharp.Fleck;
using WampSharp.Newtonsoft;

namespace WampSharp.V2
{
    public class DefaultWampHost : DefaultWampHost<JToken>
    {
        public DefaultWampHost(string location) :
            base(location, new JTokenMessageParser(), new JsonFormatter())
        {
        }
    }

    public class DefaultWampHost<TMessage> : WampSharp.V2.Api.WampHost<TMessage>
        where TMessage : class 
    {
        public DefaultWampHost(string location,
                               IWampMessageParser<TMessage> parser,
                               IWampFormatter<TMessage> formatter) :
            this(new FleckWampConnectionListener<TMessage>("wamp.2.json", location, parser), formatter)
        {
        }

        public DefaultWampHost(IWampConnectionListener<TMessage> connectionListener, IWampFormatter<TMessage> formatter)
            : base(connectionListener, formatter)
        {
        }
    }
}