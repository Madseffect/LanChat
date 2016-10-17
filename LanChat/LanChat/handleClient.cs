using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LanChat
{
    public class handleClient
    {
        TcpClient clientSocket;
        string clNo;
        Hashtable clientsList;

        public void startClient(TcpClient inClientSocket, string clientNo, Hashtable cList)
        {
            clientSocket = inClientSocket;
            clNo = clientNo;
            clientsList = cList;
            Thread ctThread = new Thread(doChat);
            ctThread.Start();
        }

        private void doChat()
        {
            int requestCount = 0;
            byte[] bytesFrom= new byte[10025];
            string dataFromClient = null;
            byte[] sendBytes = null;
            string serverResponse = null;
            string rCount = null;
            requestCount = 0;

            try

            {

                requestCount = requestCount + 1;

                NetworkStream networkStream = clientSocket.GetStream();

                networkStream.Read(bytesFrom, 0, (int)clientSocket.ReceiveBufferSize);

                dataFromClient = System.Text.Encoding.ASCII.GetString(bytesFrom);

                dataFromClient = dataFromClient.Substring(0, dataFromClient.IndexOf("$"));

                Console.WriteLine("From client - " + clNo + " : " + dataFromClient);

                rCount = Convert.ToString(requestCount);



                Program.broadcast(dataFromClient, clNo, true);

            }

            catch (Exception ex)

            {

                Console.WriteLine(ex.ToString());

            }
        }
    }
}
