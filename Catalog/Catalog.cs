using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace Catalog
{
    public partial class Catalog : Form
    {
        public static string fileName = @".\Bookshelf.xml";
        form_Debug fd = null;
        private int imageNumber = 1;

        public Catalog()
        {
            InitializeComponent();
            watch();
        }

        private void watch()
        {
            FileSystemWatcher watcher = new FileSystemWatcher();
            watcher.Path = Path.GetDirectoryName(Catalog.fileName);
            watcher.Filter = Path.GetFileName(Catalog.fileName);
            watcher.NotifyFilter = NotifyFilters.LastWrite;
            watcher.Changed += new FileSystemEventHandler(OnChanged);
            watcher.EnableRaisingEvents = true;
        }

        private void OnChanged(object source, FileSystemEventArgs e)
        {
            Thread.Sleep(10);
            Invoke((MethodInvoker)delegate
            {
                TreeViewCreate();
            });
        }

        private void Catalog_Load(object sender, EventArgs e)
        {
            TreeViewCreate();
        }

        private void LoadNextImage()
        {
            if (imageNumber == 4)
            {
                imageNumber = 1;
            }

            picBox_BookPreview.ImageLocation = string.Format(@".\Pics\TI_0{0}.jpg", imageNumber);
            imageNumber++;
        }

        private void timer_BookPreview_Tick(object sender, EventArgs e)
        {
            LoadNextImage();
        }

        private void TreeViewCreate()
        {
            XDocument xDoc = XDocument.Load(fileName);
            tw_Book.Nodes.Clear();
            tw_Book.Nodes.Add(new TreeNode(xDoc.Root.Name.ToString()));
            /*TreeNode rootNode = new TreeNode();
            rootNode = tw_Book.Nodes[0];*/

            List<Book> parse = FileOPs.ParseXml(fileName);
            List<Book> noDupesAuthor = parse.GroupBy(a => a.Author).Select(grp => grp.FirstOrDefault()).OrderBy(a => a.Author).ToList();

            foreach (Book nDA in noDupesAuthor)
            {
                tw_Book.Nodes[0].Nodes.Add(nDA.Author);
                List<Book> bookSeries = noDupesAuthor.FindAll(x => x.Author.Contains(nDA.Author));

                foreach (Book bs in bookSeries)
                {
                    tw_Book.Nodes[0].Nodes[noDupesAuthor.IndexOf(nDA)].Nodes.Add(bs.Series);
                    List<Book> bookName = parse.FindAll(x => x.Author.Equals(nDA.Author));

                    foreach (Book bn in bookName)
                    {
                        tw_Book.Nodes[0].Nodes[noDupesAuthor.IndexOf(nDA)].Nodes[bookSeries.IndexOf(bs)].Nodes.Add(bn.Name);
                    }
                }
                
            }

            tw_Book.ExpandAll();
        }
        
        private void LoadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TreeViewCreate();
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Book> book = new List<Book>() { new Book(1, "AsD", "Pehov", "Veter", "Veter Polyni"),
                                                 new Book(2, "sDf", "Rice", "Pugalo", "Strazh") };

            FileOPs.SaveXml(book, fileName);
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CreateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formCreate = new form_CreateBook();
            formCreate.Show();            
        }

        private void debugToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fd == null || fd.Text == "")
            {
                fd = new form_Debug();
                //fd.MdiParent = this;
                fd.Dock = DockStyle.Fill;
                fd.Show();
            }

            else if (CheckOpened(fd.Text))
            {
                fd.WindowState = FormWindowState.Normal;
                fd.Dock = DockStyle.Fill;
                fd.Show();
                fd.Focus();
            }
            
        }

        private bool CheckOpened (string name)
        {
            FormCollection fc = Application.OpenForms;

            foreach (Form frm in fc)
            {
                if (frm.Text == name) return true;
            }

            return false;
        }

        private void tw_Book_AfterSelect(object sender, TreeViewEventArgs e)
        {
            List<Book> bk = FileOPs.ParseXml(fileName);

            if (e.Node.IsExpanded) e.Node.Collapse();
            else e.Node.Expand();
            
            try
            {
                txtbox_ID.Text = bk.Find(b => b.Author == e.Node.Parent.Parent.Text && b.Name == e.Node.Text).ID.ToString();
                txtbox_MajorSeries.Text = bk.Find(b => b.Author == e.Node.Parent.Parent.Text && b.Name == e.Node.Text).MajorSeries;
                txtbox_Author.Text = e.Node.Parent.Parent.Text;
                txtbox_Name.Text = e.Node.Text;
                txtbox_Series.Text = bk.Find(b => b.Author == e.Node.Parent.Parent.Text && b.Name == e.Node.Text).Series;
            }
            catch (Exception) { }
        }
    }
}
