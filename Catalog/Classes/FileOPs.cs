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

        public static void SaveXmlFile(List<Film> films, string filename)
        {
            if (!File.Exists(filename)) using (File.Create(filename))
                    ParseListToXml(films).Save(filename);
        }

        public static XDocument LoadXmlFile(string filename)
        {
            try
            {
                XDocument doc = XDocument.Load(filename);
                return doc;
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
            foreach (var bE in bookEdit.picturesPath) book.Element("picPath").Value += "@" + bE;

            bookDoc.Save(filename);
        }

        public static void EditXmlFile(Film filmEdit, string filename)
        {
            XDocument filmDoc = LoadXmlFile(filename);

            var film = filmDoc.Descendants("Film").SingleOrDefault(f => f.Attribute("ID").Value == filmEdit.filmID.ToString());

            if (film.Element("Title").Value != filmEdit.filmTitle) film.Element("Title").Value = filmEdit.filmTitle;
            if (film.Element("Genre").Value != filmEdit.filmGenre) film.Element("Genre").Value = filmEdit.filmGenre;
            if (film.Element("Producer").Value != filmEdit.filmProducer) film.Element("Producer").Value = filmEdit.filmProducer;
            if (film.Element("Actors").Value != filmEdit.filmActors) film.Element("Actors").Value = filmEdit.filmActors;
            if (film.Element("Length").Value != filmEdit.filmLengthInMinutes.ToString()) film.Element("Length").Value = filmEdit.filmLengthInMinutes.ToString();
            if (film.Element("Country").Value != filmEdit.filmCountry) film.Element("Country").Value = filmEdit.filmCountry;
            if (film.Element("Premiere").Value != filmEdit.filmPremiere.ToString()) film.Element("Premiere").Value = filmEdit.filmPremiere.ToShortDateString();
            if (film.Element("MPAARating").Value != filmEdit.filmMPAARating) film.Element("MPAARating").Value = filmEdit.filmMPAARating;
            if (film.Element("CriticsRating").Value != filmEdit.filmCriticsRating) film.Element("CriticsRating").Value = filmEdit.filmCriticsRating;
            if (film.Element("Grosses").Value != filmEdit.filmGrosses.ToString()) film.Element("Grosses").Value = filmEdit.filmGrosses.ToString();
            if (film.Element("Notes").Value != filmEdit.filmNotes) film.Element("Notes").Value = filmEdit.filmNotes;

            film.Element("picPath").Value = "";
            foreach (var fE in filmEdit.picturesPath) film.Element("picPath").Value += "@" + fE;

            filmDoc.Save(filename);
        }

        public static void AppendToXmlFile(Book bookAppend, string filename)
        {
            XDocument bookDoc = LoadXmlFile(filename);
            
            bookDoc.Descendants("Bookshelf").First().Add(ParseToXml(bookAppend));

            bookDoc.Save(filename);
        }

        public static void AppendToXmlFile(Film filmAppend, string filename)
        {
            XDocument filmDoc = LoadXmlFile(filename);

            filmDoc.Descendants("Filmography").First().Add(ParseToXml(filmAppend));

            filmDoc.Save(filename);
        }

        public static void RemoveFromXmlFile(Book bookRemove, string filename)
        {
            XDocument bookDoc = LoadXmlFile(filename);

            DirectoryInfo bookDir = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory + @"Pics\Books\" + bookRemove.bookAuthor + @"\" + bookRemove.bookTitle);
            DirectoryInfo authorDir = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory + @"Pics\Books\" + bookRemove.bookAuthor);

            bookDoc.Descendants("Book").Where(b => b.Attribute("ID").Value == bookRemove.bookID.ToString()).Remove();

            if (Directory.Exists(bookDir.ToString())) bookDir.Delete(true);
            if (Directory.Exists(authorDir.ToString()) && authorDir.GetDirectories().Length == 0 && authorDir.GetFiles().Length == 0) authorDir.Delete(true);

            bookDoc.Save(filename);
        }

        public static void RemoveFromXmlFile(Film filmRemove, string filename)
        {
            XDocument filmDoc = LoadXmlFile(filename);

            DirectoryInfo filmDir = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory + @"Pics\Films\" + filmRemove.filmProducer + @"\" + filmRemove.filmTitle);
            DirectoryInfo producerDir = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory + @"Pics\Films\" + filmRemove.filmProducer);

            filmDoc.Descendants("Film").Where(f => f.Attribute("ID").Value == filmRemove.filmID.ToString()).Remove();

            if (Directory.Exists(filmDir.ToString())) filmDir.Delete(true);
            if (Directory.Exists(producerDir.ToString()) && producerDir.GetDirectories().Length == 0 && producerDir.GetFiles().Length == 0) producerDir.Delete(true);

            filmDoc.Save(filename);
        }

        public static List<Book> ParseBookXmlToList (string filename)
        {
            XDocument bookDoc = LoadXmlFile(filename);
            List<Book> bookList = bookDoc.Descendants("Book").Select(b => new Book {
                                                bookID = int.Parse(b.Attribute("ID").Value),
                                                bookMajorSeries = b.Element("MajorSeries").Value,
                                                bookAuthor = b.Element("Author").Value,
                                                bookTitle = b.Element("Title").Value,
                                                bookSeries = b.Element("Series").Value,
                                                bookNumberInSeries = int.Parse(b.Element("NumberInSeries").Value),
                                                bookGenre = b.Element("Genre").Value,
                                                bookPagesCount = int.Parse(b.Element("PagesCount").Value),
                                                bookPublisher = b.Element("Publisher").Value,
                                                bookPrintYear = int.Parse(b.Element("PrintYear").Value),
                                                bookPrintCity = b.Element("PrintCity").Value,
                                                bookISBN = long.Parse(b.Element("ISBN").Value),
                                                bookTranslator = b.Element("Translator").Value,
                                                bookArtist = b.Element("Artist").Value,
                                                bookNotes = b.Element("Notes").Value,
                                                picturesPath = b.Element("picPath").Value.Split(new[] { "@" }, StringSplitOptions.RemoveEmptyEntries).ToList(),
                                            }).ToList();

            return bookList;
        }

        public static List<Film> ParseFilmXmlToList(string filename)
        {
            XDocument filmDoc = LoadXmlFile(filename);
            List<Film> filmList = filmDoc.Descendants("Film").Select(f => new Film {
                                                filmID = int.Parse(f.Attribute("ID").Value),
                                                filmTitle = f.Element("Title").Value,
                                                filmGenre = f.Element("Genre").Value,
                                                filmProducer = f.Element("Producer").Value,
                                                filmActors = f.Element("Actors").Value,
                                                filmLengthInMinutes = int.Parse(f.Element("Length").Value),
                                                filmCountry = f.Element("Country").Value,
                                                filmPremiere = DateTime.Parse(f.Element("Premiere").Value).Date,
                                                filmMPAARating = f.Element("MPAARating").Value,
                                                filmCriticsRating = f.Element("CriticsRating").Value,
                                                filmGrosses = int.Parse(f.Element("Grosses").Value),
                                                filmNotes = f.Element("Notes").Value,
                                                picturesPath = f.Element("picPath").Value.Split(new[] { "@" }, StringSplitOptions.RemoveEmptyEntries).ToList(),
                                            }).ToList();
            return filmList;
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
                                                new XElement("picPath", b.picturesPath.Select(s => s = "@" + s))
                                                ));

            return bookDoc;
        }

        public static XElement ParseListToXml(List<Film> films)
        {
            XElement filmDoc = new XElement("Filmography",
                from f in films
                select new XElement("Film", new XAttribute("ID", f.filmID),
                                                new XElement("Title", f.filmTitle),
                                                new XElement("Genre", f.filmGenre),
                                                new XElement("Producer", f.filmProducer),
                                                new XElement("Actors", f.filmActors),
                                                new XElement("Length", f.filmLengthInMinutes),
                                                new XElement("Country", f.filmCountry),
                                                new XElement("Premiere", f.filmPremiere),
                                                new XElement("MPAARating", f.filmMPAARating),
                                                new XElement("CriticsRating", f.filmCriticsRating),
                                                new XElement("Grosses", f.filmGrosses),
                                                new XElement("Notes", f.filmNotes),
                                                new XElement("picPath", f.picturesPath.Select(s => s = "@" + s))
                                                ));

            return filmDoc;
        }

        public static XElement ParseToXml (Book book)
        {
            XElement newElement = new XElement("Book", new XAttribute("ID", book.bookID),
                                                            new XElement("MajorSeries", book.bookMajorSeries),
                                                            new XElement("Author", book.bookAuthor),
                                                            new XElement("Title", book.bookTitle),
                                                            new XElement("Series", book.bookSeries),
                                                            new XElement("NumberInSeries", book.bookNumberInSeries),
                                                            new XElement("Genre", book.bookGenre),
                                                            new XElement("PagesCount", book.bookPagesCount),
                                                            new XElement("Publisher", book.bookPublisher),
                                                            new XElement("PrintYear", book.bookPrintYear),
                                                            new XElement("PrintCity", book.bookPrintCity),
                                                            new XElement("ISBN", book.bookISBN),
                                                            new XElement("Translator", book.bookTranslator),
                                                            new XElement("Artist", book.bookArtist),
                                                            new XElement("Notes", book.bookNotes),
                                                            new XElement("picPath", book.picturesPath.Select(s => s = "@" + s)
                                                            ));
            return newElement;
        }

        public static XElement ParseToXml(Film film)
        {
            XElement newElement = new XElement("Film", new XAttribute("ID", film.filmID),
                                                            new XElement("Title", film.filmTitle),
                                                            new XElement("Genre", film.filmGenre),
                                                            new XElement("Producer", film.filmProducer),
                                                            new XElement("Actors", film.filmActors),
                                                            new XElement("Length", film.filmLengthInMinutes),
                                                            new XElement("Country", film.filmCountry),
                                                            new XElement("Premiere", film.filmPremiere),
                                                            new XElement("MPAARating", film.filmMPAARating),
                                                            new XElement("CriticsRating", film.filmCriticsRating),
                                                            new XElement("Grosses", film.filmGrosses),
                                                            new XElement("Notes", film.filmNotes),
                                                            new XElement("picPath", film.picturesPath.Select(s => s = "@" + s)
                                                            ));
            return newElement;
        }

        public static void SetBookLastID()
        {
            List<Book> book = ParseBookXmlToList(form_Catalog.bookFileName);

            form_Catalog.lastbookID = book.Max(b => b.bookID);
        }

        public static void SetFilmLastID()
        {
            List<Film> film = ParseFilmXmlToList(form_Catalog.filmFileName);

            form_Catalog.lastfilmID = film.Max(f => f.filmID);
        }

        public static void SetFileName()
        {
            if (!Directory.Exists(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Data")))
                Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory.ToString() + "Data");

            if (!File.Exists(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Data\Bookshelf.xml")))
                File.Create(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Data\Bookshelf.xml"));

            form_Catalog.bookFileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Data\Bookshelf.xml");

            if (!File.Exists(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Data\Filmography.xml")))
                File.Create(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Data\Filmography.xml"));

            form_Catalog.filmFileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Data\Filmography.xml");
        }
    }
}