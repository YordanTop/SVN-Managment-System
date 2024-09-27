using System.Collections.Generic;
using System.Globalization;
using System.IO;
using CsvHelper;


namespace DataConverter.Convert
{
    public class CsvConverter<T> where T: class
    {
        public string FileSavingPath {  get; set; }

        public void SaveCsvFile(List<T> entity)
        {
            using (var writer = new StreamWriter(FileSavingPath))
            {
                using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    csv.WriteHeader<T>();
                    csv.NextRecord();

                    csv.WriteRecords(entity);
                }
            }
        }
    }
}
