using System;
using System.IO;
using System.Text;
using System.Linq;


namespace etl
{
    class Program
    {
        public static void Main(string[] args)
        {
            var encryptFile = File.ReadAllText("./data/devices-encrypted.tsv");
            byte[] decryptFile = Convert.FromBase64String(encryptFile);
            string decodedFile = Encoding.Unicode.GetString(decryptFile);
            File.WriteAllText("./data/devices.tsv", decodedFile);
            Console.WriteLine(decodedFile);

            var lines = File.ReadAllLines("./data/devices.tsv");
            //var csv = lines.Select(row => string.Join(",", Format(row).Split('\t')));   
            
            foreach (var line in lines)
            {
                var columns = line.Split('\t');
                Console.WriteLine($"Line: \"{line}\"");
                foreach (var column in columns)
                {
                    Console.WriteLine(column);
                }
            }
            
            Console.Read();
        }
    }
}

// replace tabs with comas, make it csv
// parse csv
