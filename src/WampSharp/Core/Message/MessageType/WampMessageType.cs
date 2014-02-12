﻿namespace WampSharp.Core.Message
{
    /// <summary>
    /// Represents message types defined by the WAMP protocl.
    /// </summary>
    /// <remarks>
    /// This enum comntains the message types of both WAMPv1 and WAMPv2.
    /// The reason for this is that it would be more complicated to build
    /// the framework if this is seperated into two enums.
    /// </remarks>
    public enum WampMessageType
    {
        // I think the enum values are inicative,
        // but maybe in the future I'll document them.
#pragma warning disable 1591
        #region Version 1

        [MessageTypeDetails(MessageDirection.ServerToClient, MessageCategory.Auxiliary, 1)]
        v1Welcome = 0,
        [MessageTypeDetails(MessageDirection.ClientToServer, MessageCategory.Auxiliary, 1)]
        v1Prefix = 1,
        [MessageTypeDetails(MessageDirection.ClientToServer, MessageCategory.RemoteProcedureCall, 1)]
        v1Call = 2,
        [MessageTypeDetails(MessageDirection.ServerToClient, MessageCategory.RemoteProcedureCall, 1)]
        v1CallResult = 3,
        [MessageTypeDetails(MessageDirection.ServerToClient, MessageCategory.RemoteProcedureCall, 1)]
        v1CallError = 4,
        [MessageTypeDetails(MessageDirection.ClientToServer, MessageCategory.PublishSubscribe, 1)]
        v1Subscribe = 5,
        [MessageTypeDetails(MessageDirection.ClientToServer, MessageCategory.PublishSubscribe, 1)]
        v1Unsubscribe = 6,
        [MessageTypeDetails(MessageDirection.ClientToServer, MessageCategory.PublishSubscribe, 1)]
        v1Publish = 7,
        [MessageTypeDetails(MessageDirection.ServerToClient, MessageCategory.PublishSubscribe, 1)]
        v1Event = 8,

        #endregion

        #region Version 2

        [MessageTypeDetails(MessageDirection.AnyToAny, MessageCategory.Auxiliary, 2)]
        v2Hello = 1,
        [MessageTypeDetails(MessageDirection.AnyToAny, MessageCategory.Auxiliary, 2)]
        v2Welcome = 2,
        [MessageTypeDetails(MessageDirection.AnyToAny, MessageCategory.Auxiliary, 2)]
        v2Goodbye = 5,
        [MessageTypeDetails(MessageDirection.AnyToAny, MessageCategory.Auxiliary, 2)]
        v2Heartbeat = 6,
        [MessageTypeDetails(MessageDirection.AnyToAny, MessageCategory.Auxiliary, 2)]
        v2Error = 7,

        [MessageTypeDetails(MessageDirection.CallertoCallee, MessageCategory.RemoteProcedureCall, 2)]
        v2Call = 48,
        [MessageTypeDetails(MessageDirection.CallertoCallee, MessageCategory.RemoteProcedureCall, 2)]
        v2Cancel = 49,
        [MessageTypeDetails(MessageDirection.CalleetoCaller, MessageCategory.RemoteProcedureCall, 2)]
        v2Result = 50,
        [MessageTypeDetails(MessageDirection.CalleetoCaller, MessageCategory.RemoteProcedureCall, 2)]
        v2Register = 64,
        [MessageTypeDetails(MessageDirection.CalleetoCaller, MessageCategory.RemoteProcedureCall, 2)]
        v2Registered = 65,
        [MessageTypeDetails(MessageDirection.CalleetoCaller, MessageCategory.RemoteProcedureCall, 2)]
        v2Unregister = 66,
        [MessageTypeDetails(MessageDirection.CalleetoCaller, MessageCategory.RemoteProcedureCall, 2)]
        v2Unregistered = 67,
        [MessageTypeDetails(MessageDirection.CalleetoCaller, MessageCategory.RemoteProcedureCall, 2)]
        v2Invocation = 68,
        [MessageTypeDetails(MessageDirection.CalleetoCaller, MessageCategory.RemoteProcedureCall, 2)]
        v2Interrupt = 69,
        [MessageTypeDetails(MessageDirection.CalleetoCaller, MessageCategory.RemoteProcedureCall, 2)]
        v2Yield = 70,

        [MessageTypeDetails(MessageDirection.CallertoCallee, MessageCategory.PublishSubscribe, 2)]
        v2Subscribe = 64 + 0,
        [MessageTypeDetails(MessageDirection.CallertoCallee, MessageCategory.PublishSubscribe, 2)]
        v2Unsubscribe = 64 + 1,
        [MessageTypeDetails(MessageDirection.CallertoCallee, MessageCategory.PublishSubscribe, 2)]
        v2Publish = 64 + 2,
        [MessageTypeDetails(MessageDirection.CalleetoCaller, MessageCategory.PublishSubscribe, 2)]
        v2Event = 128 + 0,
        [MessageTypeDetails(MessageDirection.CalleetoCaller, MessageCategory.PublishSubscribe, 2)]
        v2Metaevent = 128 + 1,
        [MessageTypeDetails(MessageDirection.CalleetoCaller, MessageCategory.PublishSubscribe, 2)]
        v2PublishAck = 128 + 2,
        
        #endregion
#pragma warning restore 1591
    }
}
