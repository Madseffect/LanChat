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

        public string Bruger { get; set; }
        public List<string> BrugerList { get; set; }
        

        public LoginHaandtering()
        {
           BrugerList = new List<string>();
        }
        
        
        
        string operationInput;

        public void VelkommenTekst()
        {
            Console.WriteLine("");
            Console.WriteLine("Venligst angiv dit bruger navn!");
            Bruger = Console.ReadLine();
            BrugerList.Add(Bruger);
            Console.WriteLine("");
            Console.WriteLine("Dit bruger navn er: " + Bruger);
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
            return string.Equals(Bruger, other.Bruger);
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
            return (Bruger != null ? Bruger.GetHashCode() : 0);
        }
    }
}
