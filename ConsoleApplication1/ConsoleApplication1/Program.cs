using System;

// Абстрактний клас Document
public abstract class Document
{
    // Абстрактний метод print
    public abstract void Print();

    // Метод для підготовки до друку, викликає абстрактний метод Print
    public void PrepareForPrinting()
    {
        Console.WriteLine("Preparing document for printing...");
        Print();
    }
}

// Підклас PDFDocument, що успадковує Document і реалізує метод Print
public class PDFDocument : Document
{
    public override void Print()
    {
        Console.WriteLine("Printing PDF document.");
        // Логіка для друку PDF документа
    }
}

// Підклас WordDocument, що успадковує Document і реалізує метод Print
public class WordDocument : Document
{
    public override void Print()
    {
        Console.WriteLine("Printing Word document.");
        // Логіка для друку Word документа
    }
}

// Підклас ExcelDocument, що успадковує Document і реалізує метод Print
public class ExcelDocument : Document
{
    public override void Print()
    {
        Console.WriteLine("Printing Excel document.");
        // Логіка для друку Excel документа
    }
}

// Фабричний метод DocumentFactory
public class DocumentFactory
{
    // Метод, що створює об'єкти різних типів документів згідно з параметром
    public static Document CreateDocument(string documentType)
    {
        switch (documentType.ToLower())
        {
            case "pdf":
                return new PDFDocument();
            case "word":
                return new WordDocument();
            case "excel":
                return new ExcelDocument();
            default:
                throw new ArgumentException("Unsupported document type.");
        }
    }
}

class Program
{
    static void Main()
    {
        // Приклад використання фабричного методу для створення і роботи з об'єктами документів

        // Створення PDF документа через фабричний метод
        Document pdfDocument = DocumentFactory.CreateDocument("pdf");
        pdfDocument.PrepareForPrinting();

        Console.WriteLine();

        // Створення Word документа через фабричний метод
        Document wordDocument = DocumentFactory.CreateDocument("word");
        wordDocument.PrepareForPrinting();

        Console.WriteLine();

        // Створення Excel документа через фабричний метод
        Document excelDocument = DocumentFactory.CreateDocument("excel");
        excelDocument.PrepareForPrinting();

        Console.ReadLine();
    }
}
