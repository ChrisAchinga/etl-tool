using System;
using System.IO;
using System.Text;


namespace etl
{
    class Program
    {
        static void Main(string[] args)
        {
            // creating a function to get the files and encode them
            static void getFileDecryption(string  fileName) {
                var encryptFile = File.ReadAllText(fileName);
                byte[] decryptFile = Convert.FromBase64String(encryptFile);
                string decodedFile = Encoding.Unicode.GetString(decryptFile);
                Console.WriteLine(decodedFile);
                Console.WriteLine("Testing a Function");
            }
            getFileDecryption("../data/companies-encrypted.tsv");
            getFileDecryption("../data/devices-encrypted.tsv");
            // geting the files and encoding
            // try
            // {
            //     var companyFile = "../data/companies-encrypted.tsv";
            //     var deviceFile = "../data/devices-encrypted.tsv";

            //     var companyEncrypted = File.ReadAllText(companyFile);
            //     var deviceEncrypted = File.ReadAllText(deviceFile);
                
            //     byte[] companyDecrypted = Convert.FromBase64String(companyEncrypted);
            //     byte[] deviceDecrypted = Convert.FromBase64String(deviceEncrypted);

            //     string companyDecoded = Encoding.Unicode.GetString(companyDecrypted);
            //     string deviceDecoded = Encoding.Unicode.GetString(deviceDecrypted);

            //     Console.WriteLine("Company Data");
            //     Console.WriteLine(companyDecoded);

            //     Console.WriteLine("Device Data");
            //     Console.WriteLine(deviceDecoded);

            // }
            // catch (System.Exception e)
            // {
                
            //     Console.WriteLine("This file cannot be read");
            //     Console.WriteLine(e.Message);
            // }

            // file parsing
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
