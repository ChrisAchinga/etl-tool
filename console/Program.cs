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
                String st = File.ReadAllText("../data/sample.tsv");
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
