using System;

namespace etl
{
    class FileParser
    {
        // This class is just an example of how you can use public and private methods inside your class. 
        
        public string Parse(string filePath)
        {
            // Opens file
            var file = OpenFile(filePath);
            
            // Reads file
            var someData = ReadFile(file);
            
            // Makes some parsing
            var parsedData = ParseFile(someData);

            return parsedData;
        }

        private string OpenFile(string path)
        {
            // This exception is usually used when you know for sure that you'll need the
            // method in future, but don't have an implementation for it in the moment.
            
            throw new NotImplementedException();
        }

        private string ReadFile(string file)
        {
            throw new NotImplementedException();
        }

        private string ParseFile(string rawData)
        {
            throw new NotImplementedException();
        }
    }
}