﻿using MessageWire.ZeroKnowledge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MessageWire
{
    public class Session
    {
        private readonly ZkProtocolHostSession _session;

        internal Session(ZkProtocolHostSession session)
        {
            _session = session;
        }

        public DateTime Created {
            get {
                return _session.Created;
            }
        }
        public DateTime LastMessageReceived {
            get {
                return _session.LastMessageReceived;
            }
        }
        public DateTime LastHeartbeatReceived {
            get {
                return _session.LastHeartbeatReceived;
            }
        }
        public int HeartBeatsReceivedCount {
            get {
                return _session.HeartBeatsReceivedCount;
            }
        }
        public int MessagesReceivedCount {
            get {
                return _session.MessagesReceivedCount;
            }
        }
    }
}