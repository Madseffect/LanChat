using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using fcmcslib;
using Microsoft.Office.Interop.Excel;

namespace LanChat
{
   public class Program
    {
      
        
        static void Main(string[] args)
        {




         
     
            List<Product> productList=new List<Product>();
            productList.Add(new Product("Grøn Tuborg",10));
            productList.Add(new Product("Gulddame",15));
            productList.Add(new Product("Carlsberg", 20));

          
            Microsoft.Office.Interop.Access.Application acApp = new Microsoft.Office.Interop.Access.Application();

            acApp.Visible = true;
            
           //acApp.ac

            Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            if (xlApp == null)
            {
                Console.WriteLine("cannot compute");
                return;
            }

            xlApp.Visible = true;

            Workbook wb = xlApp.Workbooks.Add(XlWBATemplate.xlWBATWorksheet);
            Worksheet ws = (Worksheet) wb.Worksheets[1];
            

            if (ws == null)
            {
                Console.WriteLine("couldnt not be created");
            }


            int i = 1;
            foreach (var product in productList)
            {
                ws.Cells[i, 1] = product.Name;
                ws.Cells[i,2 ] = product.Amount;
                i++;
            }

            //int length = productList.Count;
            //Range column1 = ws.get_Range("A1", "A"+length);
            //Range column2 = ws.get_Range("B1", "B" + length);

            //if (column1==null)
            //{
            //    Console.WriteLine("No range");
            //}
          

        }
    }
}
