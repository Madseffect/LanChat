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



            // Server forbindelse
            TcpClient clientSocket = new TcpClient("127.0.0.1",6789);

            Stream gs = clientSocket.GetStream();
            StreamReader streamReader = new StreamReader(gs);
            StreamWriter streamWriter = new StreamWriter(gs);
            streamWriter.AutoFlush = true;
            


            while (true)
            {
                string message = Console.ReadLine();
                streamWriter.WriteLine(message);
                

                



                if (message == "STOP CHAT") break;    
                
            }


            gs.Close();

            clientSocket.Close();

        }
    }
}
