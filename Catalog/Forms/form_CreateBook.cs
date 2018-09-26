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

        public form_CreateBook()
        {
            InitializeComponent();
            flp_FileSelector.BorderStyle = BorderStyle.FixedSingle;
            
            txtbox_ID.Text = (++form_Catalog.lastbookID).ToString();
        }

        private void btn_SaveBook_Click(object sender, EventArgs e)
        {
            List<Book> parse = FileOPs.ParseBookXmlToList(form_Catalog.bookFileName);

            Book book = parse.Find(b => b.bookAuthor == txtbox_Author.Text && b.bookTitle == txtbox_Title.Text && b.bookTitle == txtbox_PrintYear.Text);

            if (book == null)
            {
                List<string> filePath = new List<string>();

                int count = 1;

                if (fileNames.Count == 0) fileNames.Add(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Pics\no-image.jpg"));

                foreach (string file in fileNames)
                {
                    try
                    {
                        Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + @"Pics\Books\" + txtbox_Author.Text + @"\" + txtbox_Title.Text);
                        string extension = Path.GetExtension(file);
                        string path = string.Format(@".\Pics\Books\" + txtbox_Author.Text + @"\" + txtbox_Title.Text + @"\");
                        string tempFileName = string.Format("{0}-{1}", txtbox_Title.Text, count++);

                        string fullPath = Path.Combine(path, tempFileName + extension);
                        File.Copy(file, fullPath);
                        filePath.Add(fullPath);
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message); }
                }

                Book bookAppend = new Book(int.Parse(txtbox_ID.Text), txtbox_MajorSeries.Text, txtbox_Author.Text,
                                           txtbox_Title.Text, txtbox_Series.Text, int.Parse(txtbox_NumberInSeries.Text),
                                           txtbox_Genre.Text, int.Parse(txtbox_PagesCount.Text), txtbox_Publisher.Text,
                                           int.Parse(txtbox_PrintYear.Text), txtbox_PrintCity.Text,
                                           long.Parse(txtbox_ISBN.Text), txtbox_Translator.Text, txtbox_Artist.Text,
                                           txtbox_Notes.Text, filePath);

                try
                {
                    FileOPs.AppendToXmlFile(bookAppend, form_Catalog.bookFileName);

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

                    tssl_StatusBookCreate.Text = "Книга успешно добавлена!";

                    form_Catalog.lastbookID++;
                    txtbox_ID.Text = form_Catalog.lastbookID.ToString();
                }

                catch (FileNotFoundException ex)
                {
                    MessageBox.Show(ex.Message);
                    tssl_StatusBookCreate.Text = "Ошибка!";
                }
            }
            else
            {
                MessageBox.Show(string.Format("Книга {0} автора '{1}' уже существует, необходимо исправить информацию", txtbox_Title.Text, txtbox_Author.Text));
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

                        tssl_StatusBookCreate.Text = "Файл добавлен!";
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
            fileNames.RemoveAt((flp_FileSelector.Controls.IndexOf((Control)sender) - 1)/2);
            flp_FileSelector.Controls.RemoveAt(flp_FileSelector.Controls.IndexOf((Control)sender) - 1);
            flp_FileSelector.Controls.RemoveAt(flp_FileSelector.Controls.IndexOf((Control)sender));
        }
    }
}
