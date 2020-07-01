using System;
using HelperLibrary;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = @"D:\Project C#\GitHub\SaveStoredProcedure\YML.xml";

            var offers = DeserializeOffer.DeserializeFormXml(fileName);

            Console.ReadLine();
        }
    }
}
