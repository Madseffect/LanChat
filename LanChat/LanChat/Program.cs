using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlTypes;
using System.Linq;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using fcmcslib;
using Microsoft.Office.Interop.Access;
using Microsoft.Office.Interop.Access.Dao;
using Microsoft.Office.Interop.Excel;
using Application = Microsoft.Office.Interop.Excel.Application;
using ADODB;
using ADOX;
using DataTable = System.Data.DataTable;
using DataTypeEnum = ADOX.DataTypeEnum;

namespace LanChat
{
    public class Program
    {


        static void Main(string[] args)
        {

            ADODB.Connection conn = new ADODB.Connection();
            ADOX.Catalog Cat = new ADOX.Catalog();
            ADOX.Table objTable = new ADOX.Table();




            string database = @"C:\Users\thema\Desktop\WOO\file24.accdb";
            Microsoft.Office.Interop.Access.Application app;
            app = new Microsoft.Office.Interop.Access.Application();
            app.NewCurrentDatabase(database,
                                   Microsoft.Office.Interop.Access.AcNewDatabaseFormat.acNewDatabaseFormatAccess2007,
                                  Type.Missing);
            app.Visible = true;




            objTable.Name = "Navn";
            objTable.Columns.Append("Navn");

           //Cat.Tables.



            //Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            //if (xlApp == null)
            //{
            //    Console.WriteLine("cannot compute");
            //    return;
            //}

            //xlApp.Visible = true;

            //Workbook wb = xlApp.Workbooks.Add(XlWBATemplate.xlWBATWorksheet);
            //Worksheet ws = (Worksheet)wb.Worksheets[1];


            //if (ws == null)
            //{
            //    Console.WriteLine("couldnt not be created");
            //}


            //int i = 1;
            //foreach (var product in productList)
            //{
            //    ws.Cells[i, 1] = product.Name;
            //    ws.Cells[i, 2] = product.Amount;
            //    i++;
            //}

            ////int length = productList.Count;
            ////Range column1 = ws.get_Range("A1", "A"+length);
            ////Range column2 = ws.get_Range("B1", "B" + length);

            ////if (column1==null)
            ////{
            ////    Console.WriteLine("No range");
            ////}


        }
    }
}

