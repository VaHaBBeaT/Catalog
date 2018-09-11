namespace Catalog
{
    partial class form_About
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
            this.txtbox_About = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtbox_About
            // 
            this.txtbox_About.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtbox_About.Location = new System.Drawing.Point(0, 0);
            this.txtbox_About.Multiline = true;
            this.txtbox_About.Name = "txtbox_About";
            this.txtbox_About.ReadOnly = true;
            this.txtbox_About.Size = new System.Drawing.Size(359, 92);
            this.txtbox_About.TabIndex = 0;
            this.txtbox_About.TabStop = false;
            this.txtbox_About.Text = "Каталогизатор V1\r\n\r\nПрограмма предназначена для ведения каталога книг/фильмов.\r\nД" +
    "анные хранятся в формате XML.\r\n\r\n©Яничкин Антон Евгеньевич, 2018";
            // 
            // form_About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 92);
            this.Controls.Add(this.txtbox_About);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "form_About";
            this.Text = "О программе";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbox_About;
    }
}