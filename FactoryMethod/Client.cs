using FactoryMethod.Creator;

namespace FactoryMethod
{
    class Client
    {
        public void Main(string extension, string filePath)
        {
            FileProcessorFactory pf = new ConcreteFileProcessorFactory();
            var fileProcessor = pf.Create(extension);
            fileProcessor.ProcessFile(filePath);
        }
    }
}
