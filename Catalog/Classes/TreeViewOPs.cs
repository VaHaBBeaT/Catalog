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
            XDocument xDoc = FileOPs.LoadXmlFile(form_Catalog.fileName);
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

            FileOPs.SetLastID();
        }

        public static void LoadNextImage(TreeNode node, ref PictureBox picBox)
        {
            List<Book> parse = FileOPs.ParseXmlToList(form_Catalog.fileName);

            var item = parse.Find(a => a.bookName.Equals(node.Text));

            if (form_Catalog.imageNumber == item.picPath.Count)
            {
                form_Catalog.imageNumber = 0;
            }

            picBox.ImageLocation = item.picPath[form_Catalog.imageNumber].ToString();
            form_Catalog.imageNumber++;
        }

        public static int GetDeepestChildNodeLevel(TreeNode node)
        {
            var subLevel = node.Nodes.Cast<TreeNode>().Select(subNode => GetDeepestChildNodeLevel(subNode));
            return subLevel.Count() == 0 ? 1 : subLevel.Max() + 1;
        }

        public static void CopyTreeNode (TreeView tree)
        {
            if ((tree.SelectedNode != null) && (GetDeepestChildNodeLevel(tree.SelectedNode) == 1))
            {
                try
                {
                    List<Book> parse = FileOPs.ParseXmlToList(form_Catalog.fileName);
                    Book cloneBook = parse.Find(b => b.bookName == tree.SelectedNode.Text && b.bookSeries == tree.SelectedNode.Parent.Text && b.bookAuthor == tree.SelectedNode.Parent.Parent.Text);

                    //MessageBox.Show(string.Format("Cloning book:\nAuthor: {0}\nSeries: {1}\nBook: {2}", cloneBook.bookAuthor, cloneBook.bookSeries, cloneBook.bookName));

                    form_CreateBook form = new form_CreateBook();
                    form.txtbox_ID.Text = form_Catalog.lastID++.ToString();
                    form.txtbox_MajorSeries.Text = cloneBook.bookMajorSeries;
                    form.txtbox_Author.Text = cloneBook.bookAuthor;
                    form.txtbox_Name.Text = cloneBook.bookName;
                    form.txtbox_Series.Text = cloneBook.bookSeries;
                    form.txtbox_NumberInSeries.Text = cloneBook.bookNumberInSeries.ToString();
                    form.txtbox_Genre.Text = cloneBook.bookGenre;
                    form.txtbox_PagesCount.Text = cloneBook.bookPagesCount.ToString();
                    form.txtbox_Publisher.Text = cloneBook.bookPublisher;
                    form.txtbox_PrintYear.Text = cloneBook.bookPrintYear.ToString();
                    form.txtbox_PrintCity.Text = cloneBook.bookPrintCity;
                    form.txtbox_ISBN.Text = cloneBook.bookISBN.ToString();
                    form.txtbox_Translator.Text = cloneBook.bookTranslator;
                    form.txtbox_Artist.Text = cloneBook.bookArtist;
                    form.txtbox_Notes.Text = cloneBook.bookNotes;

                    form_Catalog.imageNumber = 0;

                    tree.SelectedNode = new TreeNode(cloneBook.bookName);

                    form.Show();
                }
                catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            }
            else MessageBox.Show("Select 'Book' node");
        }
    }
}
