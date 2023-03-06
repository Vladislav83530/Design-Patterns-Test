using AbstractFactory.Data;
using AbstractFactory.Data.Abstract;
using AbstractFactory.Factories.Abstract;

namespace AbstractFactory.Factories
{
    internal class XmlFileFactory : IFileFactory
    {
        public IFileReader CreateReader()
        {
            return new XmlFileReader();
        }

        public IFileWriter CreateWriter()
        {
            return new XmlFileWriter();
        }
    }
}
