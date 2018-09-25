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
    public partial class form_CreateFilm : Form
    {
        List<string> fileNames = new List<string>();

        public form_CreateFilm()
        {
            InitializeComponent();
            flp_FileSelector.BorderStyle = BorderStyle.FixedSingle;

            txtbox_ID.Text = form_Catalog.lastfilmID++.ToString();
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
                        tb.Width = flp_FileSelector.Width - 60;
                        tb.Text = file;
                        fileNames.Add(file);
                        flp_FileSelector.Controls.Add(tb);

                        Button button_Delete = new Button();
                        button_Delete.Name = "Delete";
                        button_Delete.Width = 40;
                        button_Delete.Height = tb.Height;
                        button_Delete.Image = new Bitmap(Image.FromFile(@".\Icons\Delete.png"), new Size(16, 16));
                        button_Delete.Click += new EventHandler(btn_Delete_Click);
                        flp_FileSelector.Controls.Add(button_Delete);

                        tssl_StatusFilmCreate.Text = "File Added!";
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
            fileNames.RemoveAt((flp_FileSelector.Controls.IndexOf((Control)sender) - 1) / 2);
            flp_FileSelector.Controls.RemoveAt(flp_FileSelector.Controls.IndexOf((Control)sender) - 1);
            flp_FileSelector.Controls.RemoveAt(flp_FileSelector.Controls.IndexOf((Control)sender));
        }

        private void btn_SaveBook_Click(object sender, EventArgs e)
        {

            List<Film> parse = FileOPs.ParseFilmXmlToList(form_Catalog.filmFileName);

            Film film = parse.Find(f => f.filmProducer == txtbox_Producer.Text && f.filmTitle == txtbox_Title.Text);

            if (film == null)
            {
                List<string> filePath = new List<string>();

                int count = 1;

                foreach (string file in fileNames)
                {
                    try
                    {
                        Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + @"Pics\Films" + txtbox_Producer.Text + @"\" + txtbox_Title.Text);
                        string extension = Path.GetExtension(file);
                        string path = string.Format(@".\Pics\Films\" + txtbox_Producer.Text + @"\" + txtbox_Title.Text + @"\");
                        string tempFileName = string.Format("{0}-{1}", txtbox_Title.Text, count++);

                        string fullPath = Path.Combine(path, tempFileName + extension);
                        File.Copy(file, fullPath);
                        filePath.Add(fullPath);
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message); }
                }

                Film filmAppend = new Film(int.Parse(txtbox_ID.Text), txtbox_Title.Text, txtbox_Genre.Text,
                                           txtbox_Producer.Text, txtbox_Actors.Text, int.Parse(txtbox_Length.Text),
                                           txtbox_Country.Text, DateTime.Parse(txtbox_Premiere.Text), cmbbox_MPAA.Text,
                                           txtbox_CriticsRating.Text, int.Parse(txtbox_Grosses.Text),
                                           txtbox_Notes.Text, filePath);

                try
                {
                    FileOPs.AppendToXmlFile(filmAppend, form_Catalog.filmFileName);

                    txtbox_ID.Clear();
                    txtbox_Title.Clear();
                    txtbox_Genre.Clear();
                    txtbox_Producer.Clear();
                    txtbox_Actors.Clear();
                    txtbox_Length.Clear();
                    txtbox_Country.Clear();
                    txtbox_Premiere.Clear();
                    cmbbox_MPAA.SelectedIndex = -1;
                    txtbox_CriticsRating.Clear();
                    txtbox_Grosses.Clear();
                    txtbox_Notes.Clear();

                    flp_FileSelector.Controls.Clear();

                    tssl_StatusFilmCreate.Text = "Success!";

                    form_Catalog.lastfilmID++;
                    txtbox_ID.Text = form_Catalog.lastfilmID.ToString();
                }

                catch (FileNotFoundException ex)
                {
                    MessageBox.Show(ex.Message);
                    tssl_StatusFilmCreate.Text = "Error!";
                }
            }
            else
            {
                MessageBox.Show(string.Format("Producers {0} film '{1}' already exist, please edit filminfo", txtbox_Producer.Text, txtbox_Title.Text));
            }
        }
    }
}
