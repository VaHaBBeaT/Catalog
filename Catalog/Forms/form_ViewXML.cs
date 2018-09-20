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

namespace Catalog
{
    public partial class form_ViewXML : Form
    {
        public form_ViewXML()
        {
            InitializeComponent();
            watch();
        }

        private void watch()
        {
            FileSystemWatcher watcher = new FileSystemWatcher();
            watcher.Path = Path.GetDirectoryName(form_Catalog.fileName);
            watcher.Filter = Path.GetFileName(form_Catalog.fileName);
            watcher.NotifyFilter = NotifyFilters.LastWrite;
            watcher.Changed += new FileSystemEventHandler(OnChanged);
            watcher.EnableRaisingEvents = true;
        }

        private void OnChanged(object source, FileSystemEventArgs e)
        {
            Thread.Sleep(10);
            Invoke((MethodInvoker)delegate
            {
                rtbBookInfo.LoadFile(form_Catalog.fileName, RichTextBoxStreamType.PlainText);
            });
        }

        private void rtbBookInfo_TextChanged(object sender, EventArgs e)
        {

        }

        private void form_Debug_Load(object sender, EventArgs e)
        {
            rtbBookInfo.Text = FileOPs.LoadXmlFile(form_Catalog.fileName).ToString();
        }
    }
}
