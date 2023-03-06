using AbstractFactory.Data.Abstract;

namespace AbstractFactory.Data
{
    internal class XmlFileReader : IFileReader
    {
        public void Read()
        {
            Console.WriteLine("Read XML file");
        }
    }
}
