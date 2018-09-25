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
        public form_ViewXML(string filename)
        {
            InitializeComponent(filename);
            watch(filename);
        }

        private void watch(string filename)
        {
            FileSystemWatcher watcher = new FileSystemWatcher();
            watcher.Path = Path.GetDirectoryName(filename);
            watcher.Filter = Path.GetFileName(filename);
            watcher.NotifyFilter = NotifyFilters.LastWrite;
            watcher.Changed += new FileSystemEventHandler((sender, e) => OnChanged(sender, e, filename));
            watcher.EnableRaisingEvents = true;
        }

        private void OnChanged(object source, FileSystemEventArgs e, string file)
        {
            Thread.Sleep(10);
            Invoke((MethodInvoker)delegate
            {
                rtbXMLInfo.LoadFile(file, RichTextBoxStreamType.PlainText);
            });
        }

        private void rtbBookInfo_TextChanged(object sender, EventArgs e)
        {

        }

        private void form_ViewXML_Load(object sender, EventArgs e, string file)
        {
            rtbXMLInfo.Text = FileOPs.LoadXmlFile(file).ToString();
        }
    }
}
