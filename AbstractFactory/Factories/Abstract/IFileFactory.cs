using AbstractFactory.Data.Abstract;

namespace AbstractFactory.Factories.Abstract
{
    internal interface IFileFactory
    {
        IFileReader CreateReader();
        IFileWriter CreateWriter();
    }
}
