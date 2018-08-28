using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Catalog
{
    public partial class form_CreateBook : Form
    {
        public form_CreateBook()
        {
            InitializeComponent();
        }

        private void btn_SaveBook_Click(object sender, EventArgs e)
        {
            Book bookAppend = new Book(int.Parse(txtbox_ID.Text), txtbox_MajorSeries.Text, txtbox_Author.Text, txtbox_Name.Text);

            try
            {
                FileOPs.AppendXml(bookAppend, Catalog.fileName);
            
                txtbox_ID.Clear();
                txtbox_MajorSeries.Clear();
                txtbox_Author.Clear();
                txtbox_Name.Clear();
                tssl_StatusBookCreate.Text = "Success!";
            }

            catch (System.IO.FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message);
                tssl_StatusBookCreate.Text = "Error!";
            }
}

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
