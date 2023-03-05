namespace FactoryMethod.FileProcessors
{
    class CsvFileProcessor : IFileProcessor
    {
        public void ProcessFile(string filePath)
        {
            Console.WriteLine($"Processing .csv file: {filePath}");
        }
    }
}
