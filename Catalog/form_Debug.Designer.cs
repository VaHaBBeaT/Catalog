namespace Catalog
{
    partial class form_Debug
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
        private void InitializeComponent()
        {
            this.rtbBookInfo = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtbBookInfo
            // 
            this.rtbBookInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbBookInfo.Location = new System.Drawing.Point(0, 0);
            this.rtbBookInfo.Margin = new System.Windows.Forms.Padding(5);
            this.rtbBookInfo.Name = "rtbBookInfo";
            this.rtbBookInfo.Size = new System.Drawing.Size(365, 333);
            this.rtbBookInfo.TabIndex = 1;
            this.rtbBookInfo.Text = "";
            this.rtbBookInfo.TextChanged += new System.EventHandler(this.rtbBookInfo_TextChanged);
            // 
            // form_Debug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 333);
            this.Controls.Add(this.rtbBookInfo);
            this.Name = "form_Debug";
            this.Text = "Debug";
            this.Load += new System.EventHandler(this.form_Debug_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbBookInfo;
    }
}