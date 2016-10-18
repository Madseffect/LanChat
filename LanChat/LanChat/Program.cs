using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Mime;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LanChat
{ 
    class Program
    {

        static void Main(string[] args)
        {

            // LanChatClient    

            LoginHaandtering login = new LoginHaandtering();

            //Bruger

            Console.WriteLine("Velkommen til LanChat!");
          
            login.VelkommenTekst();

            login.BrugerHaandtering();

            // TcpClient
            TcpClient clientSocket = new TcpClient();
            NetworkStream serverStream = default(NetworkStream);
            string readData = null;


            //Info til Server
            byte[] outStream = System.Text.Encoding.ASCII.GetBytes(login.BrugerList[0]);
            serverStream.Write(outStream, 0, outStream.Length); // Fejl ved denne linje
            serverStream.Flush();

           
            clientSocket.Connect("127.0.0.1", 8888);
            serverStream = clientSocket.GetStream(); 
            StreamReader streamReader = new StreamReader(serverStream);
            StreamWriter streamWriter = new StreamWriter(serverStream);
            streamWriter.AutoFlush = true;

            // getMessage fra eksempel er ikke lavet ved dette punkt, vil prøve med vores egen måde.
            // http://csharp.net-informations.com/communications/files/src/csharp-chat-client.txt
            while (true)
            {
                string message = Console.ReadLine();
                streamWriter.WriteLine(message);
                

                



                if (message == "STOP CHAT") break;    
                
            }


            serverStream.Close();

            clientSocket.Close();

        }
    }
}
