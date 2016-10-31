using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows;
using Windows.Storage;
using Windows.Storage.Pickers;
using ADOX;
using Microsoft.Office.Core;
using Application = Microsoft.Vbe.Interop.Application;


namespace LanChat
{
    
    public class Program
    {

    

        static void Main(string[] args)
        {
            #region MyRegion
            List<Product> productList = new List<Product>();
            productList.Add(new Product("Grøn Tuborg", 10));
            productList.Add(new Product("Gulddame", 15));
            productList.Add(new Product("Carlsberg", 20));
            #endregion
            //Angiver sted og navn på db
            //Console.WriteLine("Please insert the filepath to where you want to store your data:");

           // string location =  Console.ReadLine();

           // Console.WriteLine("Please insert the name you want for your Access database:");

            string[] lines = File.ReadAllLines(@"C:\Users\thema\Desktop\WOO\temptext.txt");
           string location = lines[0];
            string name = lines[1];

            string database = location + @"\" + name + ".accdb";
            //string database = location + @"\" + Console.ReadLine() + ".accdb";

            Console.WriteLine(database);

            //string database = @"C:\Users\thema\Desktop\WOO\file005.accdb


            //Opretter databasen
            Microsoft.Office.Interop.Access.Application app;
            app = new Microsoft.Office.Interop.Access.Application();
            app.NewCurrentDatabase(database,
                                   Microsoft.Office.Interop.Access.AcNewDatabaseFormat.acNewDatabaseFormatAccess2007,
                                  Type.Missing);
            app.CloseCurrentDatabase();

            //Laver mine connection kald til db via Oledb
            OleDbConnection con;
            OleDbCommand com;
            OleDbDataReader dr;

            con = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source ='" + database + "' ");
            com = new OleDbCommand("Select*from Tabel1", con);
           

            //SQL kald som opretter table og inserter values
            string strTemp = " [KEY] Text, [VALUE] Text ";
            //com.CommandText = "insert into Tabel1 ([Navn]) values ('" + "value" + "')";
            com.CommandText = "CREATE TABLE [Person5](" + strTemp + ")";

            OleDbCommand com2;
            OleDbDataReader dr2;
            com2 = new OleDbCommand("Select*from Person5", con);


            string test = "hej";
            com2.CommandText = "insert into Person5 ([KEY]) values ('hej')";


            con.Open();

            dr = com.ExecuteReader();
            dr2 = com2.ExecuteReader();




            


            #region excel code


            //Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            //if (xlApp == null)
            //{
            //    Console.WriteLine("cannot compute");
            //    return;
            //}

            //xlApp.Visible = false;

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




            //int length = productList.Count;
            //Range column1 = ws.get_Range("A1", "A" + length);
            //Range column2 = ws.get_Range("B1", "B" + length);


            #endregion

        }
    }
}

