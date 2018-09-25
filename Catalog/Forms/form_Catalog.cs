using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Globalization;
using System.Threading;
using System.Resources;

namespace Catalog
{
    public partial class form_Catalog : Form
    {
        public static string bookFileName = "";
        public static string filmFileName = "";
        public static int imageNumber = 0;
        public static int lastbookID = 0;
        public static int lastfilmID = 0;

        form_ViewXML fd = null;

        public form_Catalog()
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("ru-RU");
            FileOPs.SetFileName();
            InitializeComponent();
            tc_Info.SelectedIndexChanged += new EventHandler(tc_Info_Selected);
            watch();
        }

        private void tc_Info_Selected(object sender, EventArgs e)
        {
            if (tc_Info.SelectedTab == tabPage_Book)
            {
                timer_Preview.Stop();
                grpbox_BookInfo.Hide();
                TreeViewOPs.CreateBookTree(tw_Book);
            }
            if (tc_Info.SelectedTab == tabPage_Film)
            {
                timer_Preview.Stop();
                grpbox_FilmInfo.Hide();
                TreeViewOPs.CreateFilmTree(tw_Film);
            }
        }

        private void watch()
        {
            //TBD for Film
            string filenme = "";

            if (tc_Info.SelectedTab == tabPage_Book) filenme = bookFileName;
            if (tc_Info.SelectedTab == tabPage_Film) filenme = filmFileName;

            FileSystemWatcher watcher = new FileSystemWatcher();
            watcher.Path = Path.GetDirectoryName(filenme);
            watcher.Filter = Path.GetFileName(filenme);
            watcher.NotifyFilter = NotifyFilters.LastWrite;
            watcher.Changed += new FileSystemEventHandler(OnChanged);
            watcher.EnableRaisingEvents = true;
        }

        private void OnChanged(object source, FileSystemEventArgs e)
        {
            Thread.Sleep(10);
            Invoke((MethodInvoker)delegate
            {
                if (tc_Info.SelectedTab == tabPage_Book) TreeViewOPs.CreateBookTree(tw_Book);
                if (tc_Info.SelectedTab == tabPage_Film) TreeViewOPs.CreateBookTree(tw_Film);
            });

            FileOPs.SetBookLastID();
            FileOPs.SetFilmLastID();
        }

        private void Catalog_Load(object sender, EventArgs e)
        {
            timer_Preview.Stop();
            FileOPs.SetBookLastID();
            FileOPs.SetFilmLastID();

            if (tc_Info.SelectedTab == tabPage_Book)
            {
                grpbox_BookInfo.Hide();
                TreeViewOPs.CreateBookTree(tw_Book);
            }
            if (tc_Info.SelectedTab == tabPage_Film)
            {
                grpbox_FilmInfo.Hide();
                TreeViewOPs.CreateFilmTree(tw_Film);
            }
        }

        private void timer_Preview_Tick(object sender, EventArgs e)
        {
            if (tc_Info.SelectedTab == tabPage_Book) TreeViewOPs.LoadBookNextImage(tw_Book.SelectedNode, ref picBox_BookPreview);
            if (tc_Info.SelectedTab == tabPage_Film) TreeViewOPs.LoadFilmNextImage(tw_Film.SelectedNode, ref picBox_FilmPreview);
        }

        private void LoadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ofd_LoadXmlFile.InitialDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Data");
            ofd_LoadXmlFile.Filter = "XML (*.Xml)|*.Xml|" + "All files (*.*)|*.*";
            ofd_LoadXmlFile.Multiselect = false;
            ofd_LoadXmlFile.Title = "My Data file Browser";

            //TBD refactor
            if (tc_Info.SelectedTab == tabPage_Book)
            {
                if (ofd_LoadXmlFile.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        FileOPs.SaveXmlFile(FileOPs.ParseBookXmlToList(bookFileName), bookFileName);
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

                TreeViewOPs.CreateBookTree(tw_Book);
            }

            if (tc_Info.SelectedTab == tabPage_Film)
            {
                if (ofd_LoadXmlFile.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        FileOPs.SaveXmlFile(FileOPs.ParseFilmXmlToList(filmFileName), filmFileName);
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

                TreeViewOPs.CreateBookTree(tw_Film);
            }
            
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sfd_SaveXmlFile.InitialDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Data");
            sfd_SaveXmlFile.CreatePrompt = true;
            sfd_SaveXmlFile.OverwritePrompt = true;
            sfd_SaveXmlFile.RestoreDirectory = true;
            sfd_SaveXmlFile.Filter = "XML (*.Xml)|*.Xml|" + "All files (*.*)|*.*";
            sfd_SaveXmlFile.SupportMultiDottedExtensions = true;
            sfd_SaveXmlFile.Title = "My Data file Browser";

            //TBD refactor
            if (tc_Info.SelectedTab == tabPage_Book)
            {
                List<Book> parse = FileOPs.ParseBookXmlToList(bookFileName);

                if (sfd_SaveXmlFile.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        bookFileName = sfd_SaveXmlFile.FileName;
                        FileOPs.SaveXmlFile(parse, bookFileName);
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

            if (tc_Info.SelectedTab == tabPage_Film)
            {
                List<Film> parse = FileOPs.ParseFilmXmlToList(filmFileName);

                if (sfd_SaveXmlFile.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        filmFileName = sfd_SaveXmlFile.FileName;
                        FileOPs.SaveXmlFile(parse, filmFileName);
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
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CreateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void tw_Book_BeforeSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void tw_Book_AfterSelect(object sender, TreeViewEventArgs e)
        {
            List<Book> parse = FileOPs.ParseBookXmlToList(bookFileName);

            if ((tw_Book.SelectedNode != null) && (TreeViewOPs.GetDeepestChildNodeLevel(e.Node.TreeView.SelectedNode) == 1))
            {
                try
                {
                    imageNumber = 0;
                    grpbox_BookInfo.Show();
                    txtbox_BookID.Text = parse.Find(b => b.bookAuthor == e.Node.Parent.Parent.Text && b.bookTitle == e.Node.Text).bookID.ToString();
                    txtbox_BookMajorSeries.Text = parse.Find(b => b.bookAuthor == e.Node.Parent.Parent.Text && b.bookTitle == e.Node.Text).bookMajorSeries;
                    txtbox_BookAuthor.Text = e.Node.Parent.Parent.Text;
                    txtbox_BookTitle.Text = e.Node.Text;
                    txtbox_BookSeries.Text = parse.Find(b => b.bookAuthor == e.Node.Parent.Parent.Text && b.bookTitle == e.Node.Text).bookSeries;
                    txtbox_BookNumberInSeries.Text = parse.Find(b => b.bookAuthor == e.Node.Parent.Parent.Text && b.bookTitle == e.Node.Text).bookNumberInSeries.ToString();
                    txtbox_BookGenre.Text = parse.Find(b => b.bookAuthor == e.Node.Parent.Parent.Text && b.bookTitle == e.Node.Text).bookGenre;
                    txtbox_BookPagesCount.Text = parse.Find(b => b.bookAuthor == e.Node.Parent.Parent.Text && b.bookTitle == e.Node.Text).bookPagesCount.ToString();
                    txtbox_BookPublisher.Text = parse.Find(b => b.bookAuthor == e.Node.Parent.Parent.Text && b.bookTitle == e.Node.Text).bookPublisher;
                    txtbox_BookPrintYear.Text = parse.Find(b => b.bookAuthor == e.Node.Parent.Parent.Text && b.bookTitle == e.Node.Text).bookPrintYear.ToString();
                    txtbox_BookPrintCity.Text = parse.Find(b => b.bookAuthor == e.Node.Parent.Parent.Text && b.bookTitle == e.Node.Text).bookPrintCity;
                    if (parse.Find(b => b.bookAuthor == e.Node.Parent.Parent.Text && b.bookTitle == e.Node.Text).bookISBN.ToString().Length == 10) msktxtbox_BookISBN.Mask = "000000000-0";
                    else if (parse.Find(b => b.bookAuthor == e.Node.Parent.Parent.Text && b.bookTitle == e.Node.Text).bookISBN.ToString().Length == 13) msktxtbox_BookISBN.Mask = "000-0-00-000000-0";
                    msktxtbox_BookISBN.Text = parse.Find(b => b.bookAuthor == e.Node.Parent.Parent.Text && b.bookTitle == e.Node.Text).bookISBN.ToString();
                    txtbox_BookTranslator.Text = parse.Find(b => b.bookAuthor == e.Node.Parent.Parent.Text && b.bookTitle == e.Node.Text).bookTranslator;
                    txtbox_BookArtist.Text = parse.Find(b => b.bookAuthor == e.Node.Parent.Parent.Text && b.bookTitle == e.Node.Text).bookArtist;
                    txtbox_BookNotes.Text = parse.Find(b => b.bookAuthor == e.Node.Parent.Parent.Text && b.bookTitle == e.Node.Text).bookNotes;
                    picBox_BookPreview.ImageLocation = parse.Find(b => b.bookAuthor == e.Node.Parent.Parent.Text && b.bookTitle == e.Node.Text).picturesPath[0].ToString();
                    label1.Text = parse.Find(b => b.bookAuthor == e.Node.Parent.Parent.Text && b.bookTitle == e.Node.Text).picturesPath[0];
                    label2.Text = parse.Find(b => b.bookAuthor == e.Node.Parent.Parent.Text && b.bookTitle == e.Node.Text).picturesPath[1];
                    label3.Text = parse.Find(b => b.bookAuthor == e.Node.Parent.Parent.Text && b.bookTitle == e.Node.Text).picturesPath[2];
                    timer_Preview.Start();
                }
                catch (Exception) { }
            }
            else
            {
                grpbox_BookInfo.Hide();
                timer_Preview.Stop();
                picBox_BookPreview.Image = null;
                if (e.Node.IsExpanded) e.Node.Collapse();
                else e.Node.Expand();
            }
        }

        private void tw_Film_AfterSelect (object sender, TreeViewEventArgs e)
        {
            List<Film> parse = FileOPs.ParseFilmXmlToList(filmFileName);

            if ((tw_Film.SelectedNode != null) && (TreeViewOPs.GetDeepestChildNodeLevel(e.Node.TreeView.SelectedNode) == 1))
            {
                try
                {
                    imageNumber = 0;
                    grpbox_FilmInfo.Show();
                    txtbox_FilmID.Text = parse.Find(f => f.filmProducer == e.Node.Parent.Text && f.filmTitle == e.Node.Text).filmID.ToString();
                    txtbox_FilmProducer.Text = e.Node.Parent.Text;
                    txtbox_FilmTitle.Text = e.Node.Text;
                    txtbox_FilmGenre.Text = parse.Find(f => f.filmProducer == e.Node.Parent.Text && f.filmTitle == e.Node.Text).filmGenre;
                    txtbox_FilmActors.Text = parse.Find(f => f.filmProducer == e.Node.Parent.Text && f.filmTitle == e.Node.Text).filmActors;
                    txtbox_FilmLength.Text = parse.Find(f => f.filmProducer == e.Node.Parent.Text && f.filmTitle == e.Node.Text).filmLengthInMinutes.ToString();
                    txtbox_FilmCountry.Text = parse.Find(f => f.filmProducer == e.Node.Parent.Text && f.filmTitle == e.Node.Text).filmCountry;
                    txtbox_FilmPremiere.Text = parse.Find(f => f.filmProducer == e.Node.Parent.Text && f.filmTitle == e.Node.Text).filmPremiere.ToString();
                    txtbox_FilmMPAA.Text = parse.Find(f => f.filmProducer == e.Node.Parent.Text && f.filmTitle == e.Node.Text).filmMPAARating;
                    txtbox_FilmCriticsRating.Text = parse.Find(f => f.filmProducer == e.Node.Parent.Text && f.filmTitle == e.Node.Text).filmCriticsRating;
                    txtbox_FilmGrosses.Text = parse.Find(f => f.filmProducer == e.Node.Parent.Text && f.filmTitle == e.Node.Text).filmGrosses.ToString();
                    txtbox_FilmNotes.Text = parse.Find(f => f.filmProducer == e.Node.Parent.Text && f.filmTitle == e.Node.Text).filmNotes;
                    picBox_FilmPreview.ImageLocation = parse.Find(f => f.filmProducer == e.Node.Parent.Text && f.filmTitle == e.Node.Text).picturesPath[0].ToString();
                    label11.Text = parse.Find(f => f.filmProducer == e.Node.Parent.Text && f.filmTitle == e.Node.Text).picturesPath[0];
                    label12.Text = parse.Find(f => f.filmProducer == e.Node.Parent.Text && f.filmTitle == e.Node.Text).picturesPath[1];
                    label13.Text = parse.Find(f => f.filmProducer == e.Node.Parent.Text && f.filmTitle == e.Node.Text).picturesPath[2];
                    timer_Preview.Start();
                }
                catch (Exception) { }
            }
            else
            {
                grpbox_FilmInfo.Hide();
                timer_Preview.Stop();
                picBox_FilmPreview.Image = null;
                if (e.Node.IsExpanded) e.Node.Collapse();
                else e.Node.Expand();
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formAbout = new form_About();
            formAbout.Show();
        }

        private void PrintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TreeView tree = null;

            if (tc_Info.SelectedTab == tabPage_Book) tree = tw_Book;
            if (tc_Info.SelectedTab == tabPage_Film) tree = tw_Film;

            if ((tree.SelectedNode != null) && (TreeViewOPs.GetDeepestChildNodeLevel(tree.SelectedNode) == 1))
            {
                print_Dialog.Document = print_Doc;

                if (print_Dialog.ShowDialog() == DialogResult.OK)
                {
                    print_Doc.Print();
                }
            }
        }

        private void print_Doc_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            if (tc_Info.SelectedTab == tabPage_Book)
            {
                List<Book> parse = FileOPs.ParseBookXmlToList(bookFileName);
                Image image = Image.FromFile(parse.Find(b => b.bookAuthor == tw_Book.SelectedNode.Parent.Parent.Text && b.bookTitle == tw_Book.SelectedNode.Text).picturesPath[0]);

                PrivateFontCollection fontColl = new PrivateFontCollection();
                fontColl.AddFontFile(AppDomain.CurrentDomain.BaseDirectory + @"\Fonts\Header.TTF");
                fontColl.AddFontFile(AppDomain.CurrentDomain.BaseDirectory + @"\Fonts\Text.TTF");
                Font myHeaderFont = new Font(fontColl.Families[0], 36f);
                Font myTextFont = new Font(fontColl.Families[1], 16f);

                StringFormat stringFormat = new StringFormat();
                stringFormat.Alignment = StringAlignment.Center;
                stringFormat.LineAlignment = StringAlignment.Center;

                e.Graphics.PageUnit = GraphicsUnit.Millimeter;

                e.Graphics.DrawString(txtbox_BookAuthor.Text, myHeaderFont, Brushes.Black, new Rectangle(0, 10, 205, 15), stringFormat);
                e.Graphics.DrawString(txtbox_BookTitle.Text, myHeaderFont, Brushes.Black, new Rectangle(0, 25, 205, 15), stringFormat);

                e.Graphics.DrawImage(image, 20, 40, 70, 100);

                e.Graphics.DrawString("Серия: " + txtbox_BookSeries.Text + " - " + txtbox_BookNumberInSeries.Text, myTextFont, Brushes.Black, 100, 50);
                e.Graphics.DrawString("Жанр: " + txtbox_BookGenre.Text, myTextFont, Brushes.Black, 100, 60);
                e.Graphics.DrawString("Кол-во страниц: " + txtbox_BookPagesCount.Text, myTextFont, Brushes.Black, 100, 70);
                e.Graphics.DrawString("Издание: " + txtbox_BookPublisher.Text + ", " + txtbox_BookPrintCity.Text + ", " + txtbox_BookPrintYear.Text, myTextFont, Brushes.Black, 100, 80);
                e.Graphics.DrawString("ISBN: " + msktxtbox_BookISBN.Text, myTextFont, Brushes.Black, 100, 90);
                e.Graphics.DrawString("Переводчик: " + txtbox_BookTranslator.Text, myTextFont, Brushes.Black, 100, 100);
                e.Graphics.DrawString("Художник: " + txtbox_BookArtist.Text, myTextFont, Brushes.Black, 100, 110);
                e.Graphics.DrawString("Заметки: " + txtbox_BookNotes.Text, myTextFont, Brushes.Black, 100, 120);
            }

            if (tc_Info.SelectedTab == tabPage_Film)
            {
                List<Film> parse = FileOPs.ParseFilmXmlToList(filmFileName);
                Image image = Image.FromFile(parse.Find(f => f.filmProducer == tw_Film.SelectedNode.Parent.Text && f.filmTitle == tw_Film.SelectedNode.Text).picturesPath[0]);

                PrivateFontCollection fontColl = new PrivateFontCollection();
                fontColl.AddFontFile(AppDomain.CurrentDomain.BaseDirectory + @"\Fonts\Header.TTF");
                fontColl.AddFontFile(AppDomain.CurrentDomain.BaseDirectory + @"\Fonts\Text.TTF");
                Font myHeaderFont = new Font(fontColl.Families[0], 36f);
                Font myTextFont = new Font(fontColl.Families[1], 16f);

                StringFormat stringFormat = new StringFormat();
                stringFormat.Alignment = StringAlignment.Center;
                stringFormat.LineAlignment = StringAlignment.Center;

                e.Graphics.PageUnit = GraphicsUnit.Millimeter;

                e.Graphics.DrawString(txtbox_FilmProducer.Text, myHeaderFont, Brushes.Black, new Rectangle(0, 10, 205, 15), stringFormat);
                e.Graphics.DrawString(txtbox_FilmTitle.Text, myHeaderFont, Brushes.Black, new Rectangle(0, 25, 205, 15), stringFormat);

                e.Graphics.DrawImage(image, 20, 40, 70, 100);

                e.Graphics.DrawString("Жанр: " + txtbox_FilmGenre.Text, myTextFont, Brushes.Black, 100, 50);
                e.Graphics.DrawString("Актеры: " + txtbox_FilmActors.Text, myTextFont, Brushes.Black, 100, 60);
                e.Graphics.DrawString("Продолжительность: " + txtbox_FilmLength.Text + ", " + txtbox_BookPrintCity.Text + ", " + txtbox_BookPrintYear.Text, myTextFont, Brushes.Black, 100, 70);
                e.Graphics.DrawString("Страна: " + txtbox_FilmCountry.Text, myTextFont, Brushes.Black, 100, 80);
                e.Graphics.DrawString("Премьера: " + txtbox_FilmPremiere.Text, myTextFont, Brushes.Black, 100, 90);
                e.Graphics.DrawString("Рейтинг MPAA: " + txtbox_FilmMPAA.Text, myTextFont, Brushes.Black, 100, 100);
                e.Graphics.DrawString("Рейтинг критиков: " + txtbox_FilmCriticsRating.Text, myTextFont, Brushes.Black, 100, 110);
                e.Graphics.DrawString("Сборы ($): " + txtbox_FilmGrosses.Text, myTextFont, Brushes.Black, 100, 120);
                e.Graphics.DrawString("Заметки: " + txtbox_FilmNotes.Text, myTextFont, Brushes.Black, 100, 130);
            }
        }

        private void PreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TreeView tree = null;

            if (tc_Info.SelectedTab == tabPage_Book) tree = tw_Book;
            if (tc_Info.SelectedTab == tabPage_Film) tree = tw_Film;

            if ((tree.SelectedNode != null) && (TreeViewOPs.GetDeepestChildNodeLevel(tree.SelectedNode) == 1))
            {
                try
                {
                    print_PreviewDialog.Document = print_Doc;
                    //print_PreviewDialog.Height = 700;
                    //print_PreviewDialog.Width = 500;
                    print_PreviewDialog.ShowDialog();
                }
                catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            }
        }

        private void RemoveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tc_Info.SelectedTab == tabPage_Book)
            {
                List<Book> parse = FileOPs.ParseBookXmlToList(bookFileName);

                if ((tw_Book.SelectedNode != null) && (TreeViewOPs.GetDeepestChildNodeLevel(tw_Book.SelectedNode) == 1))
                {
                    try
                    {
                        timer_Preview.Stop();
                        picBox_BookPreview.Image = null;
                        grpbox_BookInfo.Hide();

                        FileOPs.RemoveFromXmlFile(parse.Find(b => b.bookAuthor == tw_Book.SelectedNode.Parent.Parent.Text && b.bookTitle == tw_Book.SelectedNode.Text), bookFileName);

                        TreeViewOPs.CreateBookTree(tw_Book);
                    }
                    catch (Exception ex) { MessageBox.Show(ex.ToString()); }
                }
            }

            if (tc_Info.SelectedTab == tabPage_Film)
            {
                List<Film> parse = FileOPs.ParseFilmXmlToList(filmFileName);

                if ((tw_Film.SelectedNode != null) && (TreeViewOPs.GetDeepestChildNodeLevel(tw_Film.SelectedNode) == 1))
                {
                    try
                    {
                        timer_Preview.Stop();
                        picBox_FilmPreview.Image = null;
                        grpbox_FilmInfo.Hide();

                        FileOPs.RemoveFromXmlFile(parse.Find(f => f.filmProducer == tw_Film.SelectedNode.Parent.Text && f.filmTitle == tw_Film.SelectedNode.Text), filmFileName);

                        TreeViewOPs.CreateFilmTree(tw_Film);
                    }
                    catch (Exception ex) { MessageBox.Show(ex.ToString()); }
                }
            }
        }

        private void CloneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tc_Info.SelectedTab == tabPage_Book) TreeViewOPs.CopyBookTreeNode(tw_Book);
            if (tc_Info.SelectedTab == tabPage_Film) TreeViewOPs.CopyFilmTreeNode(tw_Film);
        }

        private void ExpandAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tc_Info.SelectedTab == tabPage_Book) tw_Book.ExpandAll();
            if (tc_Info.SelectedTab == tabPage_Film) tw_Film.ExpandAll();
        }

        private void CollapseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tc_Info.SelectedTab == tabPage_Book) tw_Book.CollapseAll();
            if (tc_Info.SelectedTab == tabPage_Film) tw_Film.CollapseAll();
        }

        private bool CheckOpened(string name)
        {
            FormCollection fc = Application.OpenForms;

            foreach (Form frm in fc)
            {
                if (frm.Text == name) return true;
            }

            return false;
        }

        private void ViewXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filenme = "";

            if (tc_Info.SelectedTab == tabPage_Book) filenme = bookFileName;
            if (tc_Info.SelectedTab == tabPage_Film) filenme = filmFileName;
            
            if (fd == null || fd.Text == "")
            {
                fd = new form_ViewXML(filenme);
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

        private void ChangeLanguageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Changing language in progress...");
            //Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tc_Info.SelectedTab == tabPage_Book)
            {
                if ((tw_Book.SelectedNode != null) && (TreeViewOPs.GetDeepestChildNodeLevel(tw_Book.SelectedNode) == 1))
                {
                    try
                    {
                        List<Book> parse = FileOPs.ParseBookXmlToList(bookFileName);

                        Book bookToEdit = parse.Find(b => b.bookTitle == tw_Book.SelectedNode.Text && b.bookSeries == tw_Book.SelectedNode.Parent.Text && b.bookAuthor == tw_Book.SelectedNode.Parent.Parent.Text);

                        timer_Preview.Stop();
                        picBox_BookPreview.Image = null;

                        form_EditBook formEdit = new form_EditBook(bookToEdit);
                        formEdit.Show();

                        TreeViewOPs.CreateBookTree(tw_Book);
                    }
                    catch (Exception ex) { MessageBox.Show(ex.ToString()); }
                }
                else MessageBox.Show("Необходимо выбрать 'Книгу'");
            }

            if (tc_Info.SelectedTab == tabPage_Film)
            {
                if ((tw_Film.SelectedNode != null) && (TreeViewOPs.GetDeepestChildNodeLevel(tw_Film.SelectedNode) == 1))
                {
                    try
                    {
                        List<Film> parse = FileOPs.ParseFilmXmlToList(filmFileName);

                        Film filmToEdit = parse.Find(f => f.filmTitle == tw_Film.SelectedNode.Text && f.filmProducer == tw_Film.SelectedNode.Parent.Text);

                        timer_Preview.Stop();
                        picBox_FilmPreview.Image = null;

                        form_EditFilm formEdit = new form_EditFilm(filmToEdit);
                        formEdit.Show();

                        TreeViewOPs.CreateFilmTree(tw_Film);
                    }
                    catch (Exception ex) { MessageBox.Show(ex.ToString()); }
                }
                else MessageBox.Show("Необходимо выбрать 'Фильм'");
            }
        }

        private void CreateBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tc_Info.SelectedTab = tabPage_Book;
            form_CreateBook formCreateBook = new form_CreateBook();
            formCreateBook.Show();
        }

        private void CreateFilmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tc_Info.SelectedTab = tabPage_Film;
            form_CreateFilm form = new form_CreateFilm();
            form.Show();
        }
    }
}
