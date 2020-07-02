using System;
using System.IO;
using System.Reflection;
using HelperLibrary;
using HelperLibrary.Config;
using HelperLibrary.EF;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                #region Read config file

                var path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

                var configuration = new Configuration($"{path}\\config.json");

                var config = configuration.GetConfiguration();

                var fileNameXml = config.FileName;
                var connectionString = config.ConnectionString;

                #endregion

                #region CreateDB

                var operationDB = new OperationDB(connectionString);

                Console.WriteLine("Creating DB and Table...");

                operationDB.CreateSqlDb();

                Console.WriteLine("Finish to create DB and Table");
                Console.WriteLine(new string('-', 200));

                #endregion

                #region Deserialize offers from Xml

                Console.WriteLine("Start to deserialize xml file...");

                string fileName = $"{path}\\{fileNameXml}";

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
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Program stoped by error: {ex.Message}");
            }

            Console.WriteLine("Press enter to close...");
            Console.ReadLine();
        }
    }
}
