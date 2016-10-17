using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using fcmcslib;
using Microsoft.Office.Interop.Excel;

namespace LanChat
{
    class Program
    {
        
        static void Main(string[] args)
        {
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


            Range aRange = ws.get_Range("C1", "C7");

            if (aRange==null)
            {
                Console.WriteLine("No range");
            }

            Object[] hej= new object[1];
            hej[0] = 6;
            aRange.GetType().InvokeMember("Value", BindingFlags.SetProperty, null, aRange, hej);

            aRange.Value2 = "Karsten";
        }
    }
}
