using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Catalog
{
    public partial class form_CreateBook : Form
    {
        List<string> fileNames = new List<string>();
        List<TextBox> txtBoxes = new List<TextBox>();

        //For clone action
        //public string txt_Author
        //{
        //    get { return txtbox_Author.Text; }
        //    set { txtbox_Author.Text = value; }
        //}

        public form_CreateBook()
        {
            InitializeComponent();
            //InitializeOpenFileDialog();
            flp_FileSelector.BorderStyle = BorderStyle.FixedSingle;

            txtbox_ID.Text = form_Catalog.lastID++.ToString();
        }

        private void btn_SaveBook_Click(object sender, EventArgs e)
        {
            List<Book> parse = FileOPs.ParseXmlToList(form_Catalog.fileName);

            Book book = parse.Find(b => b.bookAuthor == txtbox_Author.Text && b.bookName == txtbox_Name.Text);

            if (book == null)
            {
                List<string> filePath = new List<string>();

                int count = 1;

                foreach (string file in fileNames)
                {
                    try
                    {
                        Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + @"Pics\" + txtbox_Author.Text + @"\" + txtbox_Name.Text);
                        string extension = Path.GetExtension(file);
                        string path = string.Format(@".\Pics\" + txtbox_Author.Text + @"\" + txtbox_Name.Text + @"\");
                        string tempFileName = string.Format("{0}-{1}", txtbox_Name.Text, count++);

                        string fullPath = Path.Combine(path, tempFileName + extension);
                        File.Copy(file, fullPath);
                        filePath.Add(fullPath);
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message); }
                }

                Book bookAppend = new Book(int.Parse(txtbox_ID.Text), txtbox_MajorSeries.Text, txtbox_Author.Text, txtbox_Name.Text, txtbox_Series.Text, int.Parse(txtbox_NumberInSeries.Text), txtbox_Genre.Text, int.Parse(txtbox_PagesCount.Text), txtbox_Publisher.Text, int.Parse(txtbox_PrintYear.Text), txtbox_PrintCity.Text, long.Parse(txtbox_ISBN.Text), txtbox_Translator.Text, txtbox_Artist.Text, txtbox_Notes.Text, filePath);

                try
                {
                    FileOPs.AppendToXmlFile(bookAppend, form_Catalog.fileName);

                    txtbox_ID.Clear();
                    txtbox_MajorSeries.Clear();
                    txtbox_Author.Clear();
                    txtbox_Name.Clear();
                    txtbox_Series.Clear();
                    txtbox_NumberInSeries.Clear();
                    txtbox_Genre.Clear();
                    txtbox_PagesCount.Clear();
                    txtbox_Publisher.Clear();
                    txtbox_PrintYear.Clear();
                    txtbox_PrintCity.Clear();
                    txtbox_ISBN.Clear();
                    txtbox_Translator.Clear();
                    txtbox_Artist.Clear();
                    txtbox_Notes.Clear();
                    foreach (var tb in txtBoxes) tb.Dispose();

                    tssl_StatusBookCreate.Text = "Success!";

                    form_Catalog.lastID++;
                    txtbox_ID.Text = form_Catalog.lastID.ToString();
                }

                catch (FileNotFoundException ex)
                {
                    MessageBox.Show(ex.Message);
                    tssl_StatusBookCreate.Text = "Error!";
                }
            }
            else
            {
                MessageBox.Show(string.Format("Authors {0} book '{1}' already exist, please edit bookinfo", txtbox_Author.Text, txtbox_Name.Text));
                //txtbox_Name.SelectionStart = 0;
                //txtbox_Name.SelectionLength = txtbox_Name.Text.Length;
                //txtbox_Author.SelectionStart = 0;
                //txtbox_Author.SelectionLength=txtbox_Author.Text.Length;
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_AddFiles_Click(object sender, EventArgs e)
        {
            ofd_FileSelector.Filter = "Images (*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|" + "All files (*.*)|*.*";
            ofd_FileSelector.Multiselect = true;
            ofd_FileSelector.Title = "My Image Browser";

            if (ofd_FileSelector.ShowDialog() == DialogResult.OK)
            {
                foreach (string file in ofd_FileSelector.FileNames)
                {
                    try
                    {
                        TextBox tb = new TextBox();
                        tb.Width = flp_FileSelector.Width;
                        tb.Text = file;
                        txtBoxes.Add(tb);
                        fileNames.Add(file);
                        flp_FileSelector.Controls.Add(tb);
                        tssl_StatusBookCreate.Text = "File Added!";
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
                        MessageBox.Show("Cannot display the image: " + file.Substring(file.LastIndexOf('\\'))
                            + ". You may not have permission to read the file, or " +
                            "it may be corrupt.\n\nReported error: " + ex.Message);
                    }
                }
            }
        }
    }
}
