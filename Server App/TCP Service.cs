using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace Server_App
{
    class TCP_Service
    {
        private static TCP_Service _instance;
        private NetworkStream stream;

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
                stream = new NetworkStream(s);
                BinaryReader reader = new BinaryReader(stream);
                BinaryWriter writer = new BinaryWriter(stream);

                try
                {
                    while (true)
                    {
                        switch (reader.ReadString())
                        {
                            case "DOWN": Console.WriteLine("Download initiated."); break;
                            case "UPLD": Console.WriteLine("Upload initiated."); break;
                        }



                    }
                }
                catch (Exception exc) { } // client closes, do nothing, but stop communicating
                Console.WriteLine("Client has left the building, so server TCP also stops now.");
            }

        }

        private void Download()
        {

        }

        private void Upload()
        {
            byte[] bytebuffer = new byte[1024];

            using (FileStream filetest = File.Create(@"c:\temp\imagetest.png"))
            {
                stream.CopyTo(filetest);
            }
        }
    }
}
