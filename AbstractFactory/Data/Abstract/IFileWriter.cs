namespace AbstractFactory.Data.Abstract
{
    internal interface IFileWriter
    {
        void Write();
        void Compress();
        void Encrypt();
    }
}
