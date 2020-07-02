using System;
using System.IO;
using System.Reflection;
using HelperLibrary;
using HelperLibrary.EF;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            #region CreateDB

            var operationDB = new OperationDB("Server=(localdb)\\mssqllocaldb;Database=SaveProcedureDB;Trusted_Connection=True;");

            Console.WriteLine("Creating DB and Table...");
            
            operationDB.CreateSqlDb();
            
            Console.WriteLine("Finish to create DB and Table");
            Console.WriteLine(new string('-', 200));

            #endregion

            #region Deserialize offers from Xml

            Console.WriteLine("Start to deserialize xml file...");

            var path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);            
            string fileName = path + "\\YML.xml";

            var offers = DeserializeXml.DeserializeFormXml(fileName);

            Console.WriteLine($"Finish to deserialize xml file {fileName}");
            Console.WriteLine(new string('-', 200));

            #endregion

            #region Save Offers to DB by Stored Procedure

            Console.WriteLine("Start to insert data of offers to DB by stored procedure...");

            operationDB.SaveOffersToDbBySP(offers);

            Console.WriteLine("Finish to insert data of offers to DB by stored procedure");
            Console.WriteLine(new string('-', 200));

            #endregion

            Console.WriteLine("Press enter to close...");
            Console.ReadLine();
        }
    }
}
