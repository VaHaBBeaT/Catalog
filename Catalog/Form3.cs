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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //проверка заполнения полей
            if ((textBox2.Text.Equals("")) || (textBox3.Text.Equals("")) || (textBox4.Text.Equals("")) || (maskedTextBox1.Text.Equals("")) || (richTextBox1.Text.Equals("")))
            {
                if (MessageBox.Show("Не все поля заполнены, продолжить?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    //не все поля заполнены - все равно сохранить закрыть форму
                    Close();
                }
            }
            //сохранение в базу
            else
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string filename;
            OpenFileDialog openFileDialog1 = new OpenFileDialog() { Filter = "Картинки(*.jpg)|*.jpg" };
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filename = openFileDialog1.FileName;
                //fullfilename = FullName.FileName;
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            this.button1.Click += new System.EventHandler(this.button1_Click);
        }
    }
}
