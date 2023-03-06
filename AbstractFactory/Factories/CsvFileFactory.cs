using AbstractFactory.Data;
using AbstractFactory.Data.Abstract;
using AbstractFactory.Factories.Abstract;

namespace AbstractFactory.Factories
{
    internal class CsvFileFactory : IFileFactory
    {
        public IFileReader CreateReader()
        {
            return new CsvFileReader();
        }

        public IFileWriter CreateWriter()
        {
            return new CsvFileWriter();
        }
    }
}
