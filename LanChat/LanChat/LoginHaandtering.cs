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
            bool tf = true;
            while (tf)
            {
                
                switch (Console.ReadLine())
                {
                    case "j":
                        Console.WriteLine("Opretter forbindelse til server!");
                        tf = false;
                        break;
                    case "n":
                        VelkommenTekst();
                        break;
                }
            }
            
        }

        protected bool Equals(LoginHaandtering other)
        {
            return string.Equals(bruger, other.bruger);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((LoginHaandtering) obj);
        }

        public override int GetHashCode()
        {
            return (bruger != null ? bruger.GetHashCode() : 0);
        }
    }
}
