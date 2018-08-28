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
            Form formDebug = new form_Debug();
            formDebug.Show();

            TreeViewCreate();
        }

        private void TreeViewCreate()
        {
            XDocument xDoc = XDocument.Load(fileName);
            tw_Book.Nodes.Clear();
            tw_Book.Nodes.Add(new TreeNode(xDoc.Root.Name.ToString()));
            TreeNode rootNode = new TreeNode();
            rootNode = tw_Book.Nodes[0];
            //AddNode(xmlDoc.DocumentElement, rootNode);
            List<Book> parse = FileOPs.ParseXml(fileName);

            List<Book> noDupesAuthor = parse.GroupBy(a => a.Author).Select(grp => grp.FirstOrDefault()).OrderBy(a => a.Author).ToList();

            foreach (Book nDA in noDupesAuthor)
            {
                tw_Book.Nodes[0].Nodes.Add(nDA.Author);
                List<Book> bookName = parse.FindAll(x => x.Author.Equals(nDA.Author));
                foreach (Book bn in bookName)
                {
                    tw_Book.Nodes[0].Nodes[noDupesAuthor.IndexOf(nDA)].Nodes.Add(bn.Name);
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
            List<Book> book = new List<Book>() { new Book(1, "AsD", "Pehov", "Veter"), new Book(2, "sDf", "Rice", "Pugalo") };

            FileOPs.SaveXml(book, fileName);
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void rtbBookInfo_TextChanged(object sender, EventArgs e)
        {

        }

        private void CreateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formCreate = new form_CreateBook();
            formCreate.Show();
            tw_Book.Refresh();
            //rtbBookInfo.Text = FileOPs.LoadXml(fileName).ToString();
        }

        private void debugToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*Form formDebug = new form_Debug();
            formDebug.Show();*/
        }

        private void tw_Book_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
    }
}
