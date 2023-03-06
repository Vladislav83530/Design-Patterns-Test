using AbstractFactory.Data.Abstract;
using AbstractFactory.Factories.Abstract;

namespace AbstractFactory
{
    internal class FileProcessor
    {
        private readonly IFileFactory factory;

        public FileProcessor(IFileFactory factory)
        {
            this.factory = factory;
        }

        public void ProcessFile()
        {
            IFileReader reader = factory.CreateReader();
            reader.Read();

            IFileWriter writer = factory.CreateWriter();
            writer.Compress();
            writer.Encrypt();
            writer.Write();
        }
    }
}
