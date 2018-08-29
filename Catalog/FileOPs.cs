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
            XElement bookDoc = new XElement("Bookshelf",
                from b in books
                select new XElement("Book", new XAttribute ("ID", b.ID),
                                                new XElement("MajorSeries", b.MajorSeries),
                                                new XElement("Author", b.Author),
                                                new XElement("Name", b.Name),
                                                new XElement("Series", b.Series)));

            //SaveFileDialog saveFileDialog = new SaveFileDialog();
            //saveFileDialog.Filter = "Xml files(*.xml)|*.xml|All files(*.*)|*.*";

            //if (saveFileDialog.ShowDialog() == DialogResult.Cancel) return;
            //string fileName = saveFileDialog.FileName;

            bookDoc.Save(filename);
        }

        public static XDocument LoadXml(string filename)
        {
            try
            {
                //OpenFileDialog openFileDialog = new OpenFileDialog();
                //openFileDialog.Filter = "Xml files(*.xml)|*.xml|All files(*.*)|*.*";

                //if (openFileDialog.ShowDialog() == DialogResult.Cancel) return null;
                //string fileName = openFileDialog.FileName;

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
            //OpenFileDialog openFileDialog = new OpenFileDialog();
            //openFileDialog.Filter = "Xml files(*.xml)|*.xml|All files(*.*)|*.*";

            //if (openFileDialog.ShowDialog() == DialogResult.Cancel) return;
            //string fileName = openFileDialog.FileName;

            XDocument bookDoc = XDocument.Load(filename);
            XElement newElement = new XElement("Book", new XAttribute("ID", bookAppend.ID),
                                                            new XElement("MajorSeries", bookAppend.MajorSeries),
                                                            new XElement("Author", bookAppend.Author),
                                                            new XElement("Name", bookAppend.Name),
                                                            new XElement("Series", bookAppend.Series));
            // Добавить к объекту XDocument в памяти.
            bookDoc.Descendants("Bookshelf").First().Add(newElement);

            //SaveFileDialog saveFileDialog = new SaveFileDialog();
            //saveFileDialog.Filter = "Xml files(*.xml)|*.xml|All files(*.*)|*.*";

            //if (saveFileDialog.ShowDialog() == DialogResult.Cancel) return;
            //string fileName = saveFileDialog.FileName;

            // Сохранить изменения на диске.
            bookDoc.Save(filename);
        }

        public static List<Book> ParseXml (string filename)
        {
            XDocument bookDoc = XDocument.Load(filename);
            List<Book> bookList = bookDoc.Descendants("Book").Select(b => new Book {
                ID = int.Parse(b.Attribute("ID").Value),
                MajorSeries = b.Element("MajorSeries").Value.ToString(),
                Author = b.Element("Author").Value.ToString(),
                Name = b.Element("Name").Value.ToString(),
                Series = b.Element("Series").Value.ToString()
            }).ToList();
            

            /*string data = string.Empty;

            foreach (var item in bookList)
            {
                data += string.Format("- {0} {1} {2}\n", item.ID, item.MajorSeries, item. Author);
            }
            // Показать цвета.
            MessageBox.Show(data);*/

            return bookList;
        }
    }
}
