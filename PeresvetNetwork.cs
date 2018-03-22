using Emgu.CV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PERESVET228
{
    class PeresvetNetwork
    {
        public bool run = false;

        IPAddress ipAddr;
        int portAddr;

        TcpClient client;
        NetworkStream stream;

        public void StartNet()
        {
            try
            {
                if (client != null)
                    client.Close();

                client = new TcpClient(ipAddr.ToString(), portAddr);
                //client.Connect();
                stream = client.GetStream();
                run = true;
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message, "Ошибка установки соединения");
                run = false;
            }
            
        }

        public void StopNet()
        {
            try
            {
                if (client != null) client.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Ошибка остановки сервера");
            }
            run = false;

        }

        public void SendData(Mat img)
        {
            if (img != null)
            {

                /*
                 * [0..3] (Int32) size
                 * [4..7] (Int32) width
                 * [8..11] (Int32) height
                 * [12..12+size]    (byte[size]) data
                 * 
                 * 
                */

                int size = img.Width * img.Height * img.ElementSize;
                byte[] buffer = new byte[12+size];
                Buffer.BlockCopy(BitConverter.GetBytes(buffer.Length), 0, buffer, 0, 4);
                Buffer.BlockCopy(BitConverter.GetBytes(img.Width), 0, buffer, 0, 4);
                Buffer.BlockCopy(BitConverter.GetBytes(img.Height), 0, buffer, 4, 4);
                byte[] imgData = img.GetData();
                Buffer.BlockCopy(imgData, 0, buffer, 8, size);

                int width = BitConverter.ToInt32(buffer, 0);
                int height = BitConverter.ToInt32(buffer, 4);
                stream.Write(buffer, 0, buffer.Length);
                
            }
        }

        public bool GetIpAdress(string _ipport)
        {
            string[] ipportStr = _ipport.Split(new char[] { ':' });

            if(ipportStr.Length != 2)
            {
                MessageBox.Show("Некорректно указан удаленный адрес сервер", "Ошибка");
                return false;
            }

            

            if (!IPAddress.TryParse(ipportStr[0], out ipAddr))
            {
                MessageBox.Show("Некорректно указан IP сервера", "Ошибка");
                return false;
            }

            if (!int.TryParse(ipportStr[1], out portAddr))
            {
                MessageBox.Show("Некорректно указан порт сервера", "Ошибка");
                return false;
            }

            return true;

        }
    }
}
