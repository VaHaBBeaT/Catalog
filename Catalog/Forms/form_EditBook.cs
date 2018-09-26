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
    public partial class form_EditBook : Form
    {
        List<string> fileNames = new List<string>();

        public form_EditBook(Book book)
        {
            InitializeComponent();
            flp_FileSelector.BorderStyle = BorderStyle.FixedSingle;
            FillInfo(book);
        }

        private void FillInfo(Book book)
        {
            txtbox_ID.Text = book.bookID.ToString();
            txtbox_MajorSeries.Text = book.bookMajorSeries;
            txtbox_Author.Text = book.bookAuthor;
            txtbox_Title.Text = book.bookTitle;
            txtbox_Series.Text = book.bookSeries;
            txtbox_NumberInSeries.Text = book.bookNumberInSeries.ToString();
            txtbox_Genre.Text = book.bookGenre;
            txtbox_PagesCount.Text = book.bookPagesCount.ToString();
            txtbox_Publisher.Text = book.bookPublisher;
            txtbox_PrintYear.Text = book.bookPrintYear.ToString();
            txtbox_PrintCity.Text = book.bookPrintCity;
            txtbox_ISBN.Text = book.bookISBN.ToString();
            txtbox_Translator.Text = book.bookTranslator;
            txtbox_Artist.Text = book.bookArtist;
            txtbox_Notes.Text = book.bookNotes;

            foreach (var path in book.picturesPath)
            {
                TextBox tb = new TextBox();
                tb.Width = flp_FileSelector.Width - 60;
                tb.Text = path;
                fileNames.Add(path);
                flp_FileSelector.Controls.Add(tb);

                Button button_Delete = new Button();
                button_Delete.Name = "Delete";
                button_Delete.Width = 40;
                button_Delete.Height = tb.Height;
                button_Delete.Image = new Bitmap(Image.FromFile(@".\Icons\Delete.png"), new Size(16, 16));
                button_Delete.Click += new EventHandler(btn_Delete_Click);

                flp_FileSelector.Controls.Add(button_Delete);
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_AddFiles_Click(object sender, EventArgs e)
        {
            ofd_FileSelector.Filter = "Изображения (*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|" + "All files (*.*)|*.*";
            ofd_FileSelector.Multiselect = true;
            ofd_FileSelector.Title = "Поиск изображений";

            if (ofd_FileSelector.ShowDialog() == DialogResult.OK)
            {
                foreach (string file in ofd_FileSelector.FileNames)
                {
                    try
                    {
                        TextBox tb = new TextBox();
                        tb.Width = flp_FileSelector.Width-60;
                        tb.Text = file;
                        fileNames.Add(file);
                        flp_FileSelector.Controls.Add(tb);

                        Button button_Delete = new Button();
                        button_Delete.Name = "Удалить";
                        button_Delete.Width = 40;
                        button_Delete.Height = tb.Height;
                        button_Delete.Image = new Bitmap(Image.FromFile(@".\Icons\Delete.png"), new Size(16, 16));
                        button_Delete.Click += new EventHandler(btn_Delete_Click);
                        flp_FileSelector.Controls.Add(button_Delete);

                        tssl_StatusBookEdit.Text = "Файл добавлен!";
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

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            fileNames.RemoveAt((flp_FileSelector.Controls.IndexOf((Control)sender)-1)/2);
            flp_FileSelector.Controls.RemoveAt(flp_FileSelector.Controls.IndexOf((Control)sender) - 1);
            flp_FileSelector.Controls.RemoveAt(flp_FileSelector.Controls.IndexOf((Control)sender));
        }

        private void btn_SaveBook_Click(object sender, EventArgs e)
        {
            List<Book> parse = FileOPs.ParseBookXmlToList(form_Catalog.bookFileName);

            List<string> filePath = new List<string>();

            int count = 1;

            foreach (string file in fileNames)
            {
                try
                {
                    Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + @"Pics\Books\" + txtbox_Author.Text + @"\" + txtbox_Title.Text);
                    string extension = Path.GetExtension(file);
                    string path = string.Format(@".\Pics\Books\" + txtbox_Author.Text + @"\" + txtbox_Title.Text + @"\");
                    string tempFileName = string.Format("{0}-{1}", txtbox_Title.Text, count++);

                    string fullPath = Path.Combine(path, tempFileName + extension);
                    
                    filePath.Add(fullPath);
                    if (!File.Exists(fullPath)) File.Copy(file, fullPath, true);
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }

            Book bookToEdit = new Book(int.Parse(txtbox_ID.Text), txtbox_MajorSeries.Text, txtbox_Author.Text,
                                       txtbox_Title.Text, txtbox_Series.Text, int.Parse(txtbox_NumberInSeries.Text),
                                       txtbox_Genre.Text, int.Parse(txtbox_PagesCount.Text), txtbox_Publisher.Text,
                                       int.Parse(txtbox_PrintYear.Text), txtbox_PrintCity.Text,
                                       long.Parse(txtbox_ISBN.Text), txtbox_Translator.Text, txtbox_Artist.Text,
                                       txtbox_Notes.Text, filePath);

            try
            {
                FileOPs.EditXmlFile(bookToEdit, form_Catalog.bookFileName);

                txtbox_ID.Clear();
                txtbox_MajorSeries.Clear();
                txtbox_Author.Clear();
                txtbox_Title.Clear();
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

                flp_FileSelector.Controls.Clear();

                tssl_StatusBookEdit.Text = "Успешно!";

                Close();
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message);
                tssl_StatusBookEdit.Text = "Ошибка!";
            }
        }
    }
}
