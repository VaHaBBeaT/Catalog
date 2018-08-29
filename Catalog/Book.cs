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
        public int ID;
        public string MajorSeries;
        public string Author;
        public string Name;
        public string Series;
        /*public int NumberInSeries;
        public string Genre;
        public int NumOfPages;
        public string Publisher;
        public int PrintYear;
        public string PrintCity;
        public string ISBN;
        public string Translator;
        public string Artist;
        public string Notes;*/

        public Book(int id, string majorseries, string author, string name, string series)
        {
            ID = id;
            MajorSeries = majorseries;
            Author = author;
            Name = name;
            Series = series;
        }

        public Book() { }
    }    
}
