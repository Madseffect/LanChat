using System.Collections.Generic;
using System.Data.OleDb;

namespace LanChat
{
    public class Program
    {


        static void Main(string[] args)
        {
            List<Product> productList = new List<Product>();
            productList.Add(new Product("Grøn Tuborg", 10));
            productList.Add(new Product("Gulddame", 15));
            productList.Add(new Product("Carlsberg", 20));





            OleDbConnection con;
            OleDbCommand com;
            OleDbDataReader dr;
            con = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:/Users/thema/Desktop/WOO/Database42.accdb");
            com = new OleDbCommand("Select*from Tabel1", con);

            string strTemp = " [KEY] Text, [VALUE] Text ";
            //com.CommandText = "insert into Tabel1 ([Navn]) values ('" + "value" + "')";
            com.CommandText ="CREATE TABLE [Persons]("+strTemp+")";
            con.Open();
            dr = com.ExecuteReader();
            //com.CommandText = "insert into Tabel1 ([Navn]) values ('"+test+"')";


            //dr = com.ExecuteReader();




            //string database = @"C:\Users\thema\Desktop\WOO\file111.accdb";
            //Microsoft.Office.Interop.Access.Application app;
            //app = new Microsoft.Office.Interop.Access.Application();
            //app.NewCurrentDatabase(database,
            //                       Microsoft.Office.Interop.Access.AcNewDatabaseFormat.acNewDatabaseFormatAccess2007,
            //                      Type.Missing);

            //app.CurrentDb().CreateTableDef("Tabel1", "navnefternavn","tab1");




            #region reg1

            //Microsoft.Office.Interop.Access.Application app = new Microsoft.Office.Interop.Access.Application();
            //app.Visible = true;


            //Workspace hej = app.DBEngine.CreateWorkspace("WK1", "", "");
            //Database hej2 =  hej.CreateDatabase("hej", "dbLangNorwDan;pwd=NewPassword");

            //hej.CreateDatabase("DB1", "dbLangNorwDan;pwd=NewPassword", "dbEncrypt");

            // orkbook wb = xlApp.Workbooks.Add(XlWBATemplate.xlWBATWorksheet);

            //Microsoft.Office.Interop.Access.Application acc1 = new Microsoft.Office.Interop.Access.Application();
            //DataTable table = new DataTable();

            //table.TableName = "Tab1";
            //table.Columns.Add("Col1");
            //table.Rows.Add("row1");
            //acc1.DBEngine.CreateDatabase("MyDB", "hej");





            //accApp.Visible = true;
            //objTable.Name = "Navn";
            //objTable.Columns.Append("Navn");
            //accApp.CurrentDb().CreateTableDef()

            #endregion

            #region reg2

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

