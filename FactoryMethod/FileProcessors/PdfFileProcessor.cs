namespace FactoryMethod.FileProcessors
{
    class PdfFileProcessor : IFileProcessor
    {
        public void ProcessFile(string filePath)
        {
            Console.WriteLine($"Processing .pdf file: {filePath}");
        }
    }
}
