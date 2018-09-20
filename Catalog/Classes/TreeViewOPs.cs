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
        public static void CreateBookTree(TreeView tree)
        {
            XDocument xDoc = FileOPs.LoadXmlFile(form_Catalog.bookFileName);
            tree.Nodes.Clear();
            tree.Nodes.Add(new TreeNode(xDoc.Root.Name.ToString()));

            List<Book> parse = FileOPs.ParseBookXmlToList(form_Catalog.bookFileName);
            List<Book> noDupesAuthor = parse.GroupBy(a => a.bookAuthor).Select(grp => grp.FirstOrDefault()).OrderBy(a => a.bookAuthor).ToList();

            foreach (Book nDA in noDupesAuthor)
            {
                tree.Nodes[0].Nodes.Add(nDA.bookAuthor);
                List<Book> bookSeries = parse.FindAll(x => x.bookAuthor.Equals(nDA.bookAuthor)).GroupBy(s => s.bookSeries).Select(grp => grp.FirstOrDefault()).OrderBy(s => s.bookSeries).ToList();

                foreach (var bs in bookSeries)
                {
                    tree.Nodes[0].Nodes[noDupesAuthor.IndexOf(nDA)].Nodes.Add(bs.bookSeries);
                    List<Book> bookTitle = parse.FindAll(x => x.bookAuthor.Equals(nDA.bookAuthor) && x.bookSeries.Equals(bs.bookSeries));

                    foreach (var bn in bookTitle)
                    {
                        tree.Nodes[0].Nodes[noDupesAuthor.IndexOf(nDA)].Nodes[bookSeries.IndexOf(bs)].Nodes.Add(bn.bookTitle);
                    }
                }
            }
            
            tree.ExpandAll();

            FileOPs.SetBookLastID();
        }

        public static void CreateFilmTree(TreeView tree)
        {
            XDocument xDoc = FileOPs.LoadXmlFile(form_Catalog.filmFileName);
            tree.Nodes.Clear();
            tree.Nodes.Add(new TreeNode(xDoc.Root.Name.ToString()));

            List<Film> parse = FileOPs.ParseFilmXmlToList(form_Catalog.filmFileName);
            List<Film> noDupesProducer = parse.GroupBy(a => a.filmProducer).Select(grp => grp.FirstOrDefault()).OrderBy(a => a.filmProducer).ToList();

            //foreach (Film nDP in noDupesProducer)
            //{
            //    tree.Nodes[0].Nodes.Add(nDP.filmProducer);
            //    List<Book> bookSeries = parse.FindAll(x => x.filmProducer.Equals(nDP.filmProducer)).GroupBy(s => s.bookSeries).Select(grp => grp.FirstOrDefault()).OrderBy(s => s.bookSeries).ToList();

            //    foreach (var bs in bookSeries)
            //    {
            //        tree.Nodes[0].Nodes[noDupesProducer.IndexOf(nDP)].Nodes.Add(bs.bookSeries);
            //        List<Book> bookTitle = parse.FindAll(x => x.filmProducer.Equals(nDP.filmProducer) && x.bookSeries.Equals(bs.bookSeries));

            //        foreach (var bn in bookTitle)
            //        {
            //            tree.Nodes[0].Nodes[noDupesProducer.IndexOf(nDP)].Nodes[bookSeries.IndexOf(bs)].Nodes.Add(bn.bookTitle);
            //        }
            //    }
            //}

            tree.ExpandAll();

            FileOPs.SetBookLastID();
        }

        public static void LoadBookNextImage(TreeNode node, ref PictureBox picBox)
        {
            List<Book> parse = FileOPs.ParseBookXmlToList(form_Catalog.bookFileName);

            var item = parse.Find(a => a.bookTitle.Equals(node.Text));

            if (form_Catalog.imageNumber == item.picturesPath.Count)
            {
                form_Catalog.imageNumber = 0;
            }

            picBox.ImageLocation = item.picturesPath[form_Catalog.imageNumber].ToString();
            form_Catalog.imageNumber++;
        }

        public static void LoadFilmNextImage(TreeNode node, ref PictureBox picBox)
        {
            List<Film> parse = FileOPs.ParseFilmXmlToList(form_Catalog.filmFileName);

            var item = parse.Find(a => a.filmTitle.Equals(node.Text));

            if (form_Catalog.imageNumber == item.picturesPath.Count)
            {
                form_Catalog.imageNumber = 0;
            }

            picBox.ImageLocation = item.picturesPath[form_Catalog.imageNumber].ToString();
            form_Catalog.imageNumber++;
        }

        public static int GetDeepestChildNodeLevel(TreeNode node)
        {
            var subLevel = node.Nodes.Cast<TreeNode>().Select(subNode => GetDeepestChildNodeLevel(subNode));
            return subLevel.Count() == 0 ? 1 : subLevel.Max() + 1;
        }

        public static void CopyBookTreeNode (TreeView tree)
        {
            if ((tree.SelectedNode != null) && (GetDeepestChildNodeLevel(tree.SelectedNode) == 1))
            {
                try
                {
                    List<Book> parse = FileOPs.ParseBookXmlToList(form_Catalog.bookFileName);
                    Book cloneBook = parse.Find(b => b.bookTitle == tree.SelectedNode.Text && b.bookSeries == tree.SelectedNode.Parent.Text && b.bookAuthor == tree.SelectedNode.Parent.Parent.Text);

                    //MessageBox.Show(string.Format("Cloning book:\nAuthor: {0}\nSeries: {1}\nBook: {2}", cloneBook.bookAuthor, cloneBook.bookSeries, cloneBook.bookTitle));

                    form_CreateBook form = new form_CreateBook();
                    form.txtbox_ID.Text = form_Catalog.lastID++.ToString();
                    form.txtbox_MajorSeries.Text = cloneBook.bookMajorSeries;
                    form.txtbox_Author.Text = cloneBook.bookAuthor;
                    form.txtbox_Title.Text = cloneBook.bookTitle;
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

                    tree.SelectedNode = new TreeNode(cloneBook.bookTitle);

                    form.Show();
                }
                catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            }
            else MessageBox.Show("Select 'Book' node");
        }

        public static void CopyFilmTreeNode(TreeView tree)
        {
            if ((tree.SelectedNode != null) && (GetDeepestChildNodeLevel(tree.SelectedNode) == 1))
            {
                try
                {
                    List<Book> parse = FileOPs.ParseBookXmlToList(form_Catalog.bookFileName);
                    Book cloneBook = parse.Find(b => b.bookTitle == tree.SelectedNode.Text && b.bookSeries == tree.SelectedNode.Parent.Text && b.bookAuthor == tree.SelectedNode.Parent.Parent.Text);

                    //MessageBox.Show(string.Format("Cloning book:\nAuthor: {0}\nSeries: {1}\nBook: {2}", cloneBook.bookAuthor, cloneBook.bookSeries, cloneBook.bookTitle));

                    form_CreateBook form = new form_CreateBook();
                    form.txtbox_ID.Text = form_Catalog.lastID++.ToString();
                    form.txtbox_MajorSeries.Text = cloneBook.bookMajorSeries;
                    form.txtbox_Author.Text = cloneBook.bookAuthor;
                    form.txtbox_Title.Text = cloneBook.bookTitle;
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

                    tree.SelectedNode = new TreeNode(cloneBook.bookTitle);

                    form.Show();
                }
                catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            }
            else MessageBox.Show("Select 'Book' node");
        }
    }
}
