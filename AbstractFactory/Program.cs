using AbstractFactory;
using AbstractFactory.Factories;

FileProcessor processor = new FileProcessor(new CsvFileFactory());
processor.ProcessFile();

processor = new FileProcessor(new XmlFileFactory());
processor.ProcessFile();
