using FactoryMethod.FileProcessors;

namespace FactoryMethod.Creator
{
    class ConcreteFileProcessorFactory : FileProcessorFactory
    {
        public override IFileProcessor Create(string extension)
        {
            switch(extension)
            {
                case "txt":
                    return new TxtFileProcessor();
                case "csv":
                    return new CsvFileProcessor();
                case "pdf":
                    return new PdfFileProcessor();
                default:
                    throw new ArgumentException($"Unsuported file extension: {extension}");
            }
        }
    }
}
