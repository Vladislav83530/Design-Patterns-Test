using AbstractFactory.Data.Abstract;

namespace AbstractFactory.Data
{
    internal class CsvFileReader : IFileReader
    {
        public void Read()
        {
            Console.WriteLine("Read CSV file");
        }
    }
}
