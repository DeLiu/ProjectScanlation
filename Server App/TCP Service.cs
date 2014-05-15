using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace Server_App
{
    class TCP_Service
    {
        private static TCP_Service _instance;

        private static TCP_Service Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new TCP_Service();
                }
                return _instance;
            }
        }

        private TCP_Service()
        {
            IPAddress ipAd = IPAddress.Parse("127.0.0.1");
            int portnumb = 65535;
            TcpListener clientList = new TcpListener(ipAd, portnumb);

            clientList.Start();

            Socket s = clientList.AcceptSocket();
            if (s.Connected)
            {
                NetworkStream stream = new NetworkStream(s);
            }

        }
    }
}
