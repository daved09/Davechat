using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Net;
using System.Net.Sockets;

namespace Davechat.networking
{
    class Networkmanager
    {
        
        public Networkmanager(string ipAdress, int port)
        {
            IpAdress = ipAdress;
            Port = port;
        }

        public string IpAdress { get; set; }
        public int Port { get; set; }

        private TcpClient client;

        private TcpListener listener;
        

        public void Connect()
        {
            try
            {
                client = new TcpClient();
                client.Connect(IpAdress, Port);
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message + Environment.NewLine + e.StackTrace, "Fehler");
            }
        }
        
        public void SendMessage(string msg)
        {
            if (client.Connected)
            {
                NetworkStream stream = client.GetStream();
                byte[] outStream = Encoding.ASCII.GetBytes(msg);
                stream.Write(outStream, 0, outStream.Length);
                stream.Flush();
                stream.Close();
            }
            else
            {
                MessageBox.Show("Du bist nicht verbunden.", "Fehler");
            }
        }

        public void StartHosting()
        {
            listener = new TcpListener(Port);
            listener.Start();
        }

    }
}
