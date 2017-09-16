﻿using System.Net.Http;
using Matrix.NET.Client.Responses;
using Matrix.NET.Models;

// ReSharper disable once CheckNamespace
namespace Matrix.NET.Client.Requests
{
    public abstract class MessageEventRequestBase : RequestBase<SendEventResponse>
    {
        public string RoomId
        {
            get => _roomId;
            set
            {
                _roomId = value;
                PathParameters.Add("roomId", _roomId);
            }
        }

        public string TxnId
        {
            get => _txnId;
            set
            {
                _txnId = value;
                PathParameters.Add("txnId", _txnId);
            }
        }

        public abstract string MsgType { get; }

        public abstract string Body { get; set; }

        private string _roomId;

        private string _txnId;

        protected MessageEventRequestBase()
            : base("client/{version}/rooms/{roomId}/send/{eventType}/{txnId}?access_token={accessToken}", HttpMethod.Put, true)
        {
            PathParameters.Add("eventType", "m.room.message");
        }
    }
}