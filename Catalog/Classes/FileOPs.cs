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
        public static void SaveXml(List<Book> books, string filename)
        {
            if (!File.Exists(filename)) using (File.Create(filename))
            ParseListToXml(books).Save(filename);
        }
        
        public static XDocument LoadXml(string filename)
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

        public static void AppendXml(Book bookAppend, string filename)
        {
            XDocument bookDoc = LoadXml(filename);
            
            bookDoc.Descendants("Bookshelf").First().Add(ParseBookToXml(bookAppend));

            bookDoc.Save(filename);
        }

        public static List<Book> ParseXmlToList (string filename)
        {
            XDocument bookDoc = XDocument.Load(filename);
            List<Book> bookList = bookDoc.Descendants("Book").Select(b => new Book {
                                                bookID = int.Parse(b.Attribute("ID").Value),
                                                bookMajorSeries = b.Element("MajorSeries").Value.ToString(),
                                                bookAuthor = b.Element("Author").Value.ToString(),
                                                bookName = b.Element("Name").Value.ToString(),
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
                                                new XElement("Name", b.bookName),
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
                                                            new XElement("Name", bookAppend.bookName),
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
    }
}
