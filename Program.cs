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

            // var lines = File.ReadAllLines("./data/devices.tsv");
            //var csv = lines.Select(row => string.Join(",", Format(row).Split('\t')));   

            // 1. Map data from rows (lines) to the model (Devices in this case).
            // var listOfDevices = new List("./data/devices.tsv");
            
            // foreach (var line in lines)
            // {
            //     var columns = line.Split('\t');
            //     Console.WriteLine($"Line: \"{line}\"");
            //     foreach (var column in columns)
            //     {
            //         Console.WriteLine(column);
            //     }
            // }
            
            // 2. After data is mapped we can start with database and upload prepared models to the db.
            
            //Console.Read();

            var data = new TsvFileReader();
            var listOfLists = data.Read("./data/devices.tsv");
        }

        /// <summary>
        /// Says hello to the user with given name.
        /// </summary>
        /// <param name="username">The name of the user to say hello to.</param>
        public static void HelloWorld(string username)
        {
            Console.WriteLine($"Hello, {username}!");
        }
        
    }
}

// replace tabs with comas, make it csv
// parse csv
