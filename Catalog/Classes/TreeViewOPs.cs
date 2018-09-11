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
        public static void CreateTree(ref TreeView tree)
        {
            XDocument xDoc = FileOPs.LoadXml(form_Catalog.fileName);
            tree.Nodes.Clear();
            tree.Nodes.Add(new TreeNode(xDoc.Root.Name.ToString()));

            List<Book> parse = FileOPs.ParseXmlToList(form_Catalog.fileName);
            List<Book> noDupesAuthor = parse.GroupBy(a => a.bookAuthor).Select(grp => grp.FirstOrDefault()).OrderBy(a => a.bookAuthor).ToList();

            foreach (Book nDA in noDupesAuthor)
            {
                tree.Nodes[0].Nodes.Add(nDA.bookAuthor);
                List<Book> bookSeries = parse.FindAll(x => x.bookAuthor.Equals(nDA.bookAuthor)).GroupBy(s => s.bookSeries).Select(grp => grp.FirstOrDefault()).OrderBy(s => s.bookSeries).ToList();

                foreach (var bs in bookSeries)
                {
                    tree.Nodes[0].Nodes[noDupesAuthor.IndexOf(nDA)].Nodes.Add(bs.bookSeries);
                    List<Book> bookName = parse.FindAll(x => x.bookAuthor.Equals(nDA.bookAuthor) && x.bookSeries.Equals(bs.bookSeries));

                    foreach (var bn in bookName)
                    {
                        tree.Nodes[0].Nodes[noDupesAuthor.IndexOf(nDA)].Nodes[bookSeries.IndexOf(bs)].Nodes.Add(bn.bookName);
                    }
                }
            }

            tree.ExpandAll();
        }

        public static void LoadNextImage(TreeNode node, ref PictureBox picBox, ref int imgNum)
        {
            List<Book> parse = FileOPs.ParseXmlToList(form_Catalog.fileName);

            var item = parse.Find(a => a.bookName.Equals(node.Text));

            if (imgNum == item.picPath.Count)
            {
                imgNum = 0;
            }

            picBox.ImageLocation = item.picPath[imgNum].ToString();
            imgNum++;
        }
    }
}
