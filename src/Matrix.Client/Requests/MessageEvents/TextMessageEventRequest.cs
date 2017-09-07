﻿using Matrix.Client.Types;
using Newtonsoft.Json;

// ReSharper disable once CheckNamespace
namespace Matrix.Client.Requests
{
    [JsonObject(MemberSerialization.OptIn)]
    public class TextMessageEventRequest : MessageEventRequestBase
    {
        [JsonProperty("msgtype", Required = Required.Always)]
        public override string MsgType => MessageEventTypes.Text;

        [JsonProperty(Required = Required.Always)]
        public sealed override string Body { get; set; }

        public TextMessageEventRequest(string roomId, string txnId, string text)
        {
            RoomId = roomId;
            TxnId = txnId;
            Body = text;
        }
    }
}
