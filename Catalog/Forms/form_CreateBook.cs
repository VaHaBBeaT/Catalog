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

        public form_CreateBook()
        {
            InitializeComponent();
            //InitializeOpenFileDialog();
            flp_FileSelector.BorderStyle = BorderStyle.FixedSingle;
        }

        private void btn_SaveBook_Click(object sender, EventArgs e)
        {
            List<string> filePath = new List<string>();

            foreach (string file in fileNames)
            {
                filePath.Add(@".\Pics\" + txtbox_Author.Text + @"\" + txtbox_Name.Text + @"\" + Path.GetFileName(file));
                try
                {
                    Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + @"Pics\" + txtbox_Author.Text + @"\" + txtbox_Name.Text);
                    File.Copy(file, AppDomain.CurrentDomain.BaseDirectory + @"Pics\" + txtbox_Author.Text + @"\" + txtbox_Name.Text + @"\" + Path.GetFileName(file));
                    //File.Create(file, filePath.ToString());
                }
                catch (Exception ex){ MessageBox.Show(ex.Message); }
            }

            /*foreach (string file in fileNames)
            {
                int count = 1;
                string fileNameOnly = Path.GetFileNameWithoutExtension(file);
                string extension = Path.GetExtension(file);
                string path = Path.GetDirectoryName(file);
                string newFullPath = file;

                while (File.Exists(newFullPath))
                {
                    string tempFileName = string.Format("{0}({1})", fileNameOnly, count++);
                    newFullPath = Path.Combine(path, tempFileName + extension);
                }
            }*/
            
            Book bookAppend = new Book(int.Parse(txtbox_ID.Text), txtbox_MajorSeries.Text, txtbox_Author.Text, txtbox_Name.Text, txtbox_Series.Text, int.Parse(txtbox_NumberInSeries.Text), txtbox_Genre.Text, int.Parse(txtbox_PagesCount.Text), txtbox_Publisher.Text, int.Parse(txtbox_PrintYear.Text), txtbox_PrintCity.Text, long.Parse(txtbox_ISBN.Text), txtbox_Translator.Text, txtbox_Artist.Text, txtbox_Notes.Text, filePath);
            
            try
            {
                FileOPs.AppendToXml(bookAppend, form_Catalog.fileName);

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
            }

            catch (FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message);
                tssl_StatusBookCreate.Text = "Error!";
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
                // Read the files
                foreach (string file in ofd_FileSelector.FileNames)
                {
                    try
                    {
                        TextBox tb = new TextBox();
                        tb.Width = flp_FileSelector.Width;
                        tb.Text = file;
                        txtBoxes.Add(tb);
                        //string path = @".\Pics" + Path.GetDirectoryName(file).ToString().Split(new[] { "Pics" }, StringSplitOptions.RemoveEmptyEntries)[1] + @"\" + Path.GetFileName(file).ToString();
                        fileNames.Add(file/*path*/);
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
