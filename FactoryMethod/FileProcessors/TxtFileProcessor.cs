namespace FactoryMethod.FileProcessors
{
    class TxtFileProcessor : IFileProcessor
    {
        public void ProcessFile(string filePath)
        {
            Console.WriteLine($"Processing .txt file: {filePath}");
        }
    }
}
