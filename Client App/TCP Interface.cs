using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace Client_App
{
    class TCP_Interface
    {
        private NetworkStream stream;
        private TcpClient client;
        private void Connect()
        {
            client = new TcpClient();
            client.Connect("127.0.0.1", 65535);
            stream = client.GetStream();
            BinaryReader reader = new BinaryReader(stream);
            BinaryWriter writer = new BinaryWriter(stream);
        }
  
        private void Download()
        {
            byte[] streambuffer = new byte[buffersize];
            
        }

        private void Upload()
        {
            byte[] streambuffer = File.ReadAllBytes(filepath);
            try
            {
                stream.Write(streambuffer, 0, streambuffer.Length);
            }
            catch (SocketException e1)
            {
                //MessageBox.Show("Socketexception: " + e1); 
            }
            client.Close();
        }

        private void Release()
        {

        }
    }
}
