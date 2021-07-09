using System;
using System.IO;
using System.Security.AccessControl;
using System.Text;


namespace etl
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // get file
                var fileName = "../data/companies-encrypted.tsv";
                // File.Decrypt(fileName);
                // RemoveEncryption(fileName); (didn't declare the function)
                // Convert.FromBase64CharArray(fileName);
                // File.ReadAllBytes(fileName);
                // Convert.FromBase64String(fileName);
                string encryptedData = File.ReadAllText(fileName);
                byte[] decryptedData = Convert.FromBase64String(encryptedData);
                string decodedString = Encoding.Unicode.GetString(decryptedData);
                Console.WriteLine(decodedString);
                // string decryptedData = Convert.FromBase64String(encryptedData);
                String st = File.ReadAllText(fileName);
                // Console.WriteLine(st);
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
                Console.WriteLine("This file cannot be read");
                Console.WriteLine(e.Message);
            }
            Console.Read();
        }
    }
}
