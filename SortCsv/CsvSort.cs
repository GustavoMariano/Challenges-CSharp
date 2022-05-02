using System;
using System.Collections.Generic;

namespace SortCsv
{
    public class MorseCode
    {
        /*
         * Write a method that sorts the columns by the names of the columns alphabetically, and case-insensitive.
         * 
         * Original format:  
         * Beth,Charles,Danielle,Adam,Eric\n17945,10091,10088,3907,10132\n2,12,13,48,11
         *   
         * Final format:  
         * Adam,Beth,Charles,Danielle,Eric
         * 17945,10091,10088,3907,10132
         * 2,12,13,48,11
         */

        public static string SortCsvColumns(string csvData)
        {
            var originalRows = csvData.Split('\n');
            var header = originalRows[0];
            var originalColumnNames = header.Split(',');
            var columnNames = (string[])originalColumnNames.Clone();

            Array.Sort(columnNames, StringComparer.InvariantCultureIgnoreCase);
            var sortedHeader = string.Join(",", columnNames);
            var sortedRows = new List<string>();
            sortedRows.Add(sortedHeader);

            for (int i = 1; i < originalRows.Length; i++)
            {
                var row = originalRows[i];
                var columns = row.Split(',');
                var sortedColumns = new List<string>();
                for (int j = 0; j < columnNames.Length; j++)
                {
                    string name = columnNames[j];
                    int originalIndex = Array.IndexOf(originalColumnNames, name);

                    var columnValue = columns[originalIndex];
                    sortedColumns.Add(columnValue);
                }
                var sortedRow = string.Join(",", sortedColumns);
                sortedRows.Add(sortedRow);
            }
            var sortedCsvData = string.Join("\n", sortedRows);
            return sortedCsvData;
        }
    }
}
