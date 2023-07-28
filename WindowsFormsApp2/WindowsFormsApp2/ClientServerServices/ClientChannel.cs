using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClientServerServices
{
    internal static class ClientChannel
    {
        static int port = 5005;
        static string ip = "127.0.0.1";
        static Channel channel;
        internal static Channel GetChannel()
        {
            return channel is null ? new Channel(ip, port, ChannelCredentials.Insecure) : channel;
        }
        internal static void SetConnectionSettings(int port, string ip)
        {
            ClientChannel.port = port;
            ClientChannel.ip = ip;
        }
    }
}
