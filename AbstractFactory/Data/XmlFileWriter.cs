using AbstractFactory.Data.Abstract;

namespace AbstractFactory.Data
{
    internal class XmlFileWriter : IFileWriter
    {
        public void Write()
        {
            Console.WriteLine("Write XML file");
        }

        public void Compress()
        {
            Console.WriteLine("Compress data before writing to XML file");
        }

        public void Encrypt()
        {
            Console.WriteLine("Encrypt data before writing to XML file");
        }
    }
}
