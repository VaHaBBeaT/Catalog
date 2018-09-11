﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace Catalog
{
    public partial class form_Catalog : Form
    {
        public static string fileName = "";

        public static void SetFileName()
        {
            if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + @"\Bookshelf.xml")) fileName = AppDomain.CurrentDomain.BaseDirectory + @"\Bookshelf.xml";
            else
            {
                File.Create(AppDomain.CurrentDomain.BaseDirectory + @"\Bookshelf.xml");
                fileName = AppDomain.CurrentDomain.BaseDirectory + @"\Bookshelf.xml";
            }
        }        
        
        form_Debug fd = null;
        static int imageNumber = 0;
        
        public form_Catalog()
        {
            SetFileName();
            InitializeComponent();
            watch();
        }

        private void watch()
        {
            FileSystemWatcher watcher = new FileSystemWatcher();
            watcher.Path = Path.GetDirectoryName(fileName);
            watcher.Filter = Path.GetFileName(fileName);
            watcher.NotifyFilter = NotifyFilters.LastWrite;
            watcher.Changed += new FileSystemEventHandler(OnChanged);
            watcher.EnableRaisingEvents = true;
        }

        private void OnChanged(object source, FileSystemEventArgs e)
        {
            Thread.Sleep(10);
            Invoke((MethodInvoker)delegate
            {
                TreeViewOPs.CreateTree(ref tw_Book);
            });
        }

        private void Catalog_Load(object sender, EventArgs e)
        {
            grpbox_BookInfo.Hide();
            timer_BookPreview.Stop();
            TreeViewOPs.CreateTree(ref tw_Book);
        }

        private void timer_BookPreview_Tick(object sender, EventArgs e)
        {
            TreeViewOPs.LoadNextImage(tw_Book.SelectedNode, ref picBox_BookPreview, ref imageNumber);
        }

        private void LoadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ofd_LoadXmlFile.InitialDirectory = Path.GetDirectoryName(fileName);
            this.ofd_LoadXmlFile.Filter = "XML (*.Xml)|*.Xml|" + "All files (*.*)|*.*";
            this.ofd_LoadXmlFile.Multiselect = false;
            this.ofd_LoadXmlFile.Title = "My Data file Browser";

            if (this.ofd_LoadXmlFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    FileOPs.SaveXml(FileOPs.ParseXmlToList(fileName), fileName);
                }
                catch (SecurityException ex)
                {
                    // The user lacks appropriate permissions to read files, discover paths, etc.
                    MessageBox.Show("Security error. Please contact your administrator for details.\n\n" +
                        "Error message: " + ex.Message + "\n\n" +
                        "Details (send to Support):\n\n" + ex.StackTrace
                    );
                }
                catch (Exception ex)
                {
                    // Could not load the image - probably related to Windows file system permissions.
                    MessageBox.Show("Cannot open file: " + ofd_LoadXmlFile.FileName.Substring(ofd_LoadXmlFile.FileName.LastIndexOf('\\'))
                        + ". You may not have permission to read the file, or " +
                        "it may be corrupt.\n\nReported error: " + ex.Message);
                }
            }

            TreeViewOPs.CreateTree(ref tw_Book);
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sfd_SaveXmlFile.InitialDirectory = Path.GetDirectoryName(fileName);
            sfd_SaveXmlFile.CreatePrompt = true;
            sfd_SaveXmlFile.OverwritePrompt = true;
            sfd_SaveXmlFile.RestoreDirectory = true;
            sfd_SaveXmlFile.Filter = "XML (*.Xml)|*.Xml|" + "All files (*.*)|*.*";
            sfd_SaveXmlFile.SupportMultiDottedExtensions = true;
            sfd_SaveXmlFile.Title = "My Data file Browser";

            List<Book> parse = FileOPs.ParseXmlToList(fileName);

            if (sfd_SaveXmlFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    fileName = sfd_SaveXmlFile.FileName;
                    FileOPs.SaveXml(parse, fileName);
                }
                catch (SecurityException ex)
                {
                    // The user lacks appropriate permissions to read files, discover paths, etc.
                    MessageBox.Show("Security error. Please contact your administrator for details.\n\n" +
                        "Error message: " + ex.Message + "\n\n" +
                        "Details (send to Support):\n\n" + ex.StackTrace
                    );
                }
                catch (Exception ex)
                {
                    // Could not load the image - probably related to Windows file system permissions.
                    MessageBox.Show("Cannot open file: " + sfd_SaveXmlFile.FileName.Substring(sfd_SaveXmlFile.FileName.LastIndexOf('\\'))
                        + ". You may not have permission to read the file, or " +
                        "it may be corrupt.\n\nReported error: " + ex.Message);
                }
            }
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
        
        public static int GetDeepestChildNodeLevel (TreeNode node)
        {
            var subLevel = node.Nodes.Cast<TreeNode>().Select(subNode => GetDeepestChildNodeLevel(subNode));
            return subLevel.Count() == 0 ? 1 : subLevel.Max() + 1;
        }

        private void tw_Book_BeforeSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void tw_Book_AfterSelect(object sender, TreeViewEventArgs e)
        {
            List<Book> parse = FileOPs.ParseXmlToList(fileName);

            if (GetDeepestChildNodeLevel(e.Node.TreeView.SelectedNode) == 1)
            {
                try
                {
                    imageNumber = 1;
                    grpbox_BookInfo.Show();
                    txtbox_ID.Text = parse.Find(b => b.bookAuthor == e.Node.Parent.Parent.Text && b.bookName == e.Node.Text).bookID.ToString();
                    txtbox_MajorSeries.Text = parse.Find(b => b.bookAuthor == e.Node.Parent.Parent.Text && b.bookName == e.Node.Text).bookMajorSeries;
                    txtbox_Author.Text = e.Node.Parent.Parent.Text;
                    txtbox_Name.Text = e.Node.Text;
                    txtbox_Series.Text = parse.Find(b => b.bookAuthor == e.Node.Parent.Parent.Text && b.bookName == e.Node.Text).bookSeries;
                    txtbox_NumberInSeries.Text = parse.Find(b => b.bookAuthor == e.Node.Parent.Parent.Text && b.bookName == e.Node.Text).bookNumberInSeries.ToString();
                    txtbox_Genre.Text = parse.Find(b => b.bookAuthor == e.Node.Parent.Parent.Text && b.bookName == e.Node.Text).bookGenre;
                    txtbox_PagesCount.Text = parse.Find(b => b.bookAuthor == e.Node.Parent.Parent.Text && b.bookName == e.Node.Text).bookPagesCount.ToString();
                    txtbox_Publisher.Text = parse.Find(b => b.bookAuthor == e.Node.Parent.Parent.Text && b.bookName == e.Node.Text).bookPublisher;
                    txtbox_PrintYear.Text = parse.Find(b => b.bookAuthor == e.Node.Parent.Parent.Text && b.bookName == e.Node.Text).bookPrintYear.ToString();
                    txtbox_PrintCity.Text = parse.Find(b => b.bookAuthor == e.Node.Parent.Parent.Text && b.bookName == e.Node.Text).bookPrintCity;
                    //txtbox_ISBN.Text = parse.Find(b => b.bookAuthor == e.Node.Parent.Parent.Text && b.bookName == e.Node.Text).bookISBN.ToString();
                    if (parse.Find(b => b.bookAuthor == e.Node.Parent.Parent.Text && b.bookName == e.Node.Text).bookISBN.ToString().Length == 10) msktxtbox_ISBN.Mask = "000000000-0";
                    else if (parse.Find(b => b.bookAuthor == e.Node.Parent.Parent.Text && b.bookName == e.Node.Text).bookISBN.ToString().Length == 13) msktxtbox_ISBN.Mask = "000-0-00-000000-0";
                    msktxtbox_ISBN.Text = parse.Find(b => b.bookAuthor == e.Node.Parent.Parent.Text && b.bookName == e.Node.Text).bookISBN.ToString();
                    txtbox_Translator.Text = parse.Find(b => b.bookAuthor == e.Node.Parent.Parent.Text && b.bookName == e.Node.Text).bookTranslator;
                    txtbox_Artist.Text = parse.Find(b => b.bookAuthor == e.Node.Parent.Parent.Text && b.bookName == e.Node.Text).bookArtist;
                    txtbox_Notes.Text = parse.Find(b => b.bookAuthor == e.Node.Parent.Parent.Text && b.bookName == e.Node.Text).bookNotes;
                    picBox_BookPreview.ImageLocation = parse.Find(b => b.bookAuthor == e.Node.Parent.Parent.Text && b.bookName == e.Node.Text).picPath[0].ToString();
                    label1.Text= parse.Find(b => b.bookAuthor == e.Node.Parent.Parent.Text && b.bookName == e.Node.Text).picPath[0];
                    label2.Text = parse.Find(b => b.bookAuthor == e.Node.Parent.Parent.Text && b.bookName == e.Node.Text).picPath[1];
                    label3.Text = parse.Find(b => b.bookAuthor == e.Node.Parent.Parent.Text && b.bookName == e.Node.Text).picPath[2];
                    timer_BookPreview.Start();
                }
                catch (Exception) { }
            }
            else
            {
                grpbox_BookInfo.Hide();
                timer_BookPreview.Stop();
                picBox_BookPreview.Image = null;
                if (e.Node.IsExpanded) e.Node.Collapse();
                else e.Node.Expand();
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formAbout = new form_About();
            formAbout.Show();
        }
    }
}