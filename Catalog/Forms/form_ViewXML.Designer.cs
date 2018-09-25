namespace Catalog
{
    partial class form_ViewXML
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent(string filename)
        {
            this.rtbXMLInfo = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtbXMLInfo
            // 
            this.rtbXMLInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbXMLInfo.Location = new System.Drawing.Point(0, 0);
            this.rtbXMLInfo.Margin = new System.Windows.Forms.Padding(5);
            this.rtbXMLInfo.Name = "rtbXMLInfo";
            this.rtbXMLInfo.ReadOnly = true;
            this.rtbXMLInfo.Size = new System.Drawing.Size(365, 333);
            this.rtbXMLInfo.TabIndex = 1;
            this.rtbXMLInfo.Text = "";
            this.rtbXMLInfo.TextChanged += new System.EventHandler(this.rtbBookInfo_TextChanged);
            // 
            // form_ViewXML
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 333);
            this.Controls.Add(this.rtbXMLInfo);
            this.Name = "form_ViewXML";
            this.Text = "View XML";
            this.Load += new System.EventHandler((sender, e) => this.form_ViewXML_Load(sender, e ,filename));
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbXMLInfo;
    }
}