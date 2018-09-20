using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Catalog
{
    public class Book
    {
        public int bookID;
        public string bookMajorSeries;
        public string bookAuthor;
        public string bookTitle;
        public string bookSeries;
        public int bookNumberInSeries;
        public string bookGenre;
        public int bookPagesCount;
        public string bookPublisher;
        public int bookPrintYear;
        public string bookPrintCity;
        public int bookISBN;
        public string bookTranslator;
        public string bookArtist;
        public string bookNotes;
        public List<string> picturesPath;

        public Book(int id, string majorseries, string author, string title, string series,
                    int numberinseries, string genre, int pagescount, string publisher,
                    int printyear, string printcity, int isbn, string translator,
                    string artist, string notes, List<string> picpath)
        {
            bookID = id;
            bookMajorSeries = majorseries;
            bookAuthor = author;
            bookTitle = title;
            bookSeries = series;
            bookNumberInSeries = numberinseries;
            bookGenre = genre;
            bookPagesCount = pagescount;
            bookPublisher = publisher;
            bookPrintYear = printyear;
            bookPrintCity = printcity;
            bookISBN = isbn;
            bookTranslator = translator;
            bookArtist = artist;
            bookNotes = notes;
            picturesPath = picpath;
        }

        public Book() { }
    }    
}
