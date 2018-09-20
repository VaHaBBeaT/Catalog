using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Catalog
{
    public class FileOPs
    {
        public static void SaveXmlFile(List<Book> books, string filename)
        {
            if (!File.Exists(filename)) using (File.Create(filename))
            ParseListToXml(books).Save(filename);
        }
        
        public static XDocument LoadXmlFile(string filename)
        {
            try
            {
                XDocument bookDoc = XDocument.Load(filename);
                return bookDoc;
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public static void EditXmlFile (Book bookEdit, string filename)
        {
            XDocument bookDoc = LoadXmlFile(filename);
            
            var book = bookDoc.Descendants("Book").SingleOrDefault(b => b.Attribute("ID").Value == bookEdit.bookID.ToString());

            //MessageBox.Show(string.Format("{0}|{1}", bookDoc.Descendants("Book").SingleOrDefault(b => b.Attribute("ID").Value == bookEdit.bookID.ToString()), bookEdit.bookID.ToString()));

            if (book.Element("MajorSeries").Value != bookEdit.bookMajorSeries) book.Element("MajorSeries").Value = bookEdit.bookMajorSeries;
            if (book.Element("Author").Value != bookEdit.bookAuthor) book.Element("Author").Value = bookEdit.bookAuthor;
            if (book.Element("Title").Value != bookEdit.bookTitle) book.Element("Title").Value = bookEdit.bookTitle;
            if (book.Element("Series").Value != bookEdit.bookSeries) book.Element("Series").Value = bookEdit.bookSeries;
            if (book.Element("NumberInSeries").Value != bookEdit.bookNumberInSeries.ToString()) book.Element("NumberInSeries").Value = bookEdit.bookNumberInSeries.ToString();
            if (book.Element("Genre").Value != bookEdit.bookGenre) book.Element("Genre").Value = bookEdit.bookGenre;
            if (book.Element("PagesCount").Value != bookEdit.bookPagesCount.ToString()) book.Element("PagesCount").Value = bookEdit.bookPagesCount.ToString();
            if (book.Element("Publisher").Value != bookEdit.bookPublisher) book.Element("Publisher").Value = bookEdit.bookPublisher;
            if (book.Element("PrintYear").Value != bookEdit.bookPrintYear.ToString()) book.Element("PrintYear").Value = bookEdit.bookPrintYear.ToString();
            if (book.Element("PrintCity").Value != bookEdit.bookPrintCity) book.Element("PrintCity").Value = bookEdit.bookPrintCity;
            if (book.Element("ISBN").Value != bookEdit.bookISBN.ToString()) book.Element("ISBN").Value = bookEdit.bookISBN.ToString();
            if (book.Element("Translator").Value != bookEdit.bookTranslator) book.Element("Translator").Value = bookEdit.bookTranslator;
            if (book.Element("Artist").Value != bookEdit.bookArtist) book.Element("Artist").Value = bookEdit.bookArtist;
            if (book.Element("Notes").Value != bookEdit.bookNotes) book.Element("Notes").Value = bookEdit.bookNotes;

            book.Element("picPath").Value = "";
            foreach (var bE in bookEdit.picPath) book.Element("picPath").Value += "@" + bE;

            bookDoc.Save(filename);
        }

        public static void AppendToXmlFile(Book bookAppend, string filename)
        {
            XDocument bookDoc = LoadXmlFile(filename);
            
            bookDoc.Descendants("Bookshelf").First().Add(ParseBookToXml(bookAppend));

            bookDoc.Save(filename);
        }
        
        public static void RemoveFromXmlFile(Book bookRemove, string filename)
        {
            XDocument bookDoc = LoadXmlFile(filename);

            DirectoryInfo bookDir = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory + @"Pics\" + bookRemove.bookAuthor + @"\" + bookRemove.bookTitle);
            DirectoryInfo authorDir = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory + @"Pics\" + bookRemove.bookAuthor);

            bookDoc.Descendants("Book").Where(b => b.Attribute("ID").Value == bookRemove.bookID.ToString()).Remove();

            bookDir.Delete(true);
            if (authorDir.GetDirectories().Length == 0 && authorDir.GetFiles().Length == 0) authorDir.Delete(true);

            bookDoc.Save(filename);
        }

        public static List<Book> ParseXmlToList (string filename)
        {
            XDocument bookDoc = LoadXmlFile(filename);
            List<Book> bookList = bookDoc.Descendants("Book").Select(b => new Book {
                                                bookID = int.Parse(b.Attribute("ID").Value),
                                                bookMajorSeries = b.Element("MajorSeries").Value.ToString(),
                                                bookAuthor = b.Element("Author").Value.ToString(),
                                                bookTitle = b.Element("Title").Value.ToString(),
                                                bookSeries = b.Element("Series").Value.ToString(),
                                                bookNumberInSeries = int.Parse(b.Element("NumberInSeries").Value),
                                                bookGenre = b.Element("Genre").Value.ToString(),
                                                bookPagesCount = int.Parse(b.Element("PagesCount").Value),
                                                bookPublisher = b.Element("Publisher").Value.ToString(),
                                                bookPrintYear = int.Parse(b.Element("PrintYear").Value),
                                                bookPrintCity = b.Element("PrintCity").Value.ToString(),
                                                bookISBN = long.Parse(b.Element("ISBN").Value),
                                                bookTranslator = b.Element("Translator").Value.ToString(),
                                                bookArtist = b.Element("Artist").Value.ToString(),
                                                bookNotes=b.Element("Notes").Value.ToString(),
                                                picPath = b.Element("picPath").Value.Split(new[] { "@" }, StringSplitOptions.RemoveEmptyEntries).ToList(),
                                            }).ToList();

            return bookList;
        }

        public static XElement ParseListToXml (List<Book> books)
        {
            XElement bookDoc = new XElement("Bookshelf",
                from b in books
                select new XElement("Book", new XAttribute("ID", b.bookID),
                                                new XElement("MajorSeries", b.bookMajorSeries),
                                                new XElement("Author", b.bookAuthor),
                                                new XElement("Title", b.bookTitle),
                                                new XElement("Series", b.bookSeries),
                                                new XElement("NumberInSeries", b.bookNumberInSeries),
                                                new XElement("Genre", b.bookGenre),
                                                new XElement("PagesCount", b.bookPagesCount),
                                                new XElement("Publisher", b.bookPublisher),
                                                new XElement("PrintYear", b.bookPrintYear),
                                                new XElement("PrintCity", b.bookPrintCity),
                                                new XElement("ISBN", b.bookISBN),
                                                new XElement("Translator", b.bookTranslator),
                                                new XElement("Artist", b.bookArtist),
                                                new XElement("Notes", b.bookNotes),
                                                new XElement("picPath", b.picPath.Select(s => s = "@" + s))
                                                ));

            return bookDoc;
        }

        public static XElement ParseBookToXml (Book bookAppend)
        {
            XElement newElement = new XElement("Book", new XAttribute("ID", bookAppend.bookID),
                                                            new XElement("MajorSeries", bookAppend.bookMajorSeries),
                                                            new XElement("Author", bookAppend.bookAuthor),
                                                            new XElement("Title", bookAppend.bookTitle),
                                                            new XElement("Series", bookAppend.bookSeries),
                                                            new XElement("NumberInSeries", bookAppend.bookNumberInSeries),
                                                            new XElement("Genre", bookAppend.bookGenre),
                                                            new XElement("PagesCount", bookAppend.bookPagesCount),
                                                            new XElement("Publisher", bookAppend.bookPublisher),
                                                            new XElement("PrintYear", bookAppend.bookPrintYear),
                                                            new XElement("PrintCity", bookAppend.bookPrintCity),
                                                            new XElement("ISBN", bookAppend.bookISBN),
                                                            new XElement("Translator", bookAppend.bookTranslator),
                                                            new XElement("Artist", bookAppend.bookArtist),
                                                            new XElement("Notes", bookAppend.bookNotes),
                                                            new XElement("picPath", bookAppend.picPath.Select(s => s = "@" + s)
                                                            ));
            return newElement;
        }

        public static void SetLastID()
        {
            List<Book> book = ParseXmlToList(form_Catalog.fileName);

            form_Catalog.lastID = book.Max(b => b.bookID);
        }
    }
}
