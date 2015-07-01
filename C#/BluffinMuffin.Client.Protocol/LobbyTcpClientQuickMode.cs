﻿using BluffinMuffin.Protocol.Lobby.QuickMode;

namespace BluffinMuffin.Client.Protocol
{
    public class LobbyTcpClientQuickMode : LobbyTcpClient
    {
        public LobbyTcpClientQuickMode(string serverAddress, int serverPort)
            : base(serverAddress, serverPort)
        {
        }

        public bool Identify(string name)
        {
            PlayerName = name;

            Send(new IdentifyCommand() { Name = PlayerName });

            return WaitAndReceive<IdentifyResponse>().Success;
        }
    }
}
