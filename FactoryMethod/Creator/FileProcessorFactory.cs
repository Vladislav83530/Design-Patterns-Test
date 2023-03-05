using FactoryMethod.FileProcessors;

namespace FactoryMethod.Creator
{
    abstract class FileProcessorFactory
    {
        public abstract IFileProcessor Create(string extension);
    }
}
