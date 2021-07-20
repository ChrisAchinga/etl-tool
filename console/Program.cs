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
            try
            {
                static void getFileDecryption(string  fileName) {
                    var encryptFile = File.ReadAllText(fileName);
                    byte[] decryptFile = Convert.FromBase64String(encryptFile);
                    string decodedFile = Encoding.Unicode.GetString(decryptFile);

                    Console.WriteLine(decodedFile);
                }
                getFileDecryption("../data/companies-encrypted.tsv");
                getFileDecryption("../data/devices-encrypted.tsv");
                
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
