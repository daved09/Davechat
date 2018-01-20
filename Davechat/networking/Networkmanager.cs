using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

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


        private void AsyncSendData(IAsyncResult ar)
        {
            try
            {

            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }


    }
}
