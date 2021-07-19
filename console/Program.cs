using System;
using System.IO;
using System.Text;


namespace etl
{
    class Program
    {
        static void Main(string[] args)
        {
            // geting the files and encoding
            try
            {
                // file paths
                var companyFile = "../data/companies-encrypted.tsv";
                var deviceFile = "../data/devices-encrypted.tsv";

                var companyEncrypted = File.ReadAllText(companyFile);
                var deviceEncrypted = File.ReadAllText(deviceFile);
                
                byte[] companyDecrypted = Convert.FromBase64String(companyEncrypted);
                byte[] deviceDecrypted = Convert.FromBase64String(deviceEncrypted);

                string companyDecoded = Encoding.Unicode.GetString(companyDecrypted);
                string deviceDecoded = Encoding.Unicode.GetString(deviceDecrypted);

                Console.WriteLine("Company Data");
                Console.WriteLine(companyDecoded);

                Console.WriteLine("Device Data");
                Console.WriteLine(deviceDecoded);

            }
            catch (System.Exception e)
            {
                
                Console.WriteLine("This file cannot be read");
                Console.WriteLine(e.Message);
            }

            try
            {
                Console.WriteLine("Creating MySQL Database");
            }
            catch (System.Exception e)
            {
                Console.WriteLine("Database operations failed");
                Console.WriteLine(e.Message);
            }
            Console.Read();
        }
    }
}
