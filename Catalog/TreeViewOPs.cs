using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace Catalog
{
    class TreeViewOPs
    {
        public static void LookUpAuthor(string author)
        {
            // Загрузить текущий документ.
            XDocument inventoryDoc = XDocument.Load(Catalog.fileName);
            // Найти цвета заданного изготовителя.
            var bookInfo = from book in inventoryDoc.Descendants("Book") where (string)book.Element("Author") == author select book.Element("ID").Value;
            // Построить строку, представляющую каждый цвет.
            string data = string.Empty;
            foreach (var item in bookInfo.Distinct())
            {
                data += string.Format("- {0}\n", item);
            }
            // Показать цвета.
            MessageBox.Show(data, string.Format("{0} colors:", author));
        }
    }
}
