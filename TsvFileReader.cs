using System;
using System.IO;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace etl {
    public class TsvFileReader
    {
        /// <summary>
        /// A method to map data to lists
        /// </summary>
        public List<List<string>> Read(string filePath)
        {
            // creating rows with "name ..."

            // // Unsplitted rows
            // var unsplittedRows = file.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
             var splittedRows = new List<List<string>>();

            var unsplittedRows = File.ReadAllLines(filePath);

            foreach (var unsplitttedRow in unsplittedRows)
            {
                var row = new List<string>();
                var columns = unsplitttedRow.Split('\t');

                foreach (var column in columns)
                {
                    row.Add(column);
                }

                splittedRows.Add(row);
            }

            return splittedRows;

        }

}
}
