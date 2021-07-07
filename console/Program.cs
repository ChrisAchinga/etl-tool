using System;
using System.IO;


namespace etl
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var fileName = "../data/companies-encrypted.tsv";
                File.Decrypt(fileName);
                String st = File.ReadAllText(fileName);
                Console.WriteLine(st);
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
