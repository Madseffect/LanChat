using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LanChat
{
    class LoginHaandtering
    {

        string bruger;
        string operationInput;

        public void VelkommenTekst()
        {
            Console.WriteLine("");
            Console.WriteLine("Venligst angiv dit bruger navn!");
            bruger = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Dit bruger navn er: " + bruger);
            Console.WriteLine("");
            Console.WriteLine("Vil du oprette forbindelse til LanChat Serveren? j/n");
        }

        public void BrugerHaandtering()
        {
            while (true)
            {
                if (Console.ReadLine() == "n")
                {
                    VelkommenTekst();
                }

                if (Console.ReadLine() == "j")
                {
                    Console.WriteLine("Opretter forbindelse til server!");
                    break;
                }

            }
        }

    }
}
