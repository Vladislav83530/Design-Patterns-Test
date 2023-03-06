using AbstractFactory.Data.Abstract;

namespace AbstractFactory.Data
{
    internal class CsvFileWriter : IFileWriter
    {
        public void Write()
        {
            Console.WriteLine("Write CSV file");
        }

        public void Compress()
        {
            Console.WriteLine("Compress data before writing to CSV file"); 
        }

        public void Encrypt()
        {
            Console.WriteLine("Encrypt data before writing to CSV file");
        }
    }
}
