namespace Catalog
{
    partial class form_CreateBook
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
            this.txtbox_ID = new System.Windows.Forms.TextBox();
            this.txtbox_MajorSeries = new System.Windows.Forms.TextBox();
            this.txtbox_Author = new System.Windows.Forms.TextBox();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.lbl_MajorSeries = new System.Windows.Forms.Label();
            this.lbl_Author = new System.Windows.Forms.Label();
            this.btn_SaveBook = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tssl_StatusBookCreate = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.txtbox_Name = new System.Windows.Forms.TextBox();
            this.txtbox_Series = new System.Windows.Forms.TextBox();
            this.lbl_Series = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtbox_ID
            // 
            this.txtbox_ID.Location = new System.Drawing.Point(72, 12);
            this.txtbox_ID.Name = "txtbox_ID";
            this.txtbox_ID.Size = new System.Drawing.Size(198, 20);
            this.txtbox_ID.TabIndex = 0;
            // 
            // txtbox_MajorSeries
            // 
            this.txtbox_MajorSeries.Location = new System.Drawing.Point(72, 39);
            this.txtbox_MajorSeries.Name = "txtbox_MajorSeries";
            this.txtbox_MajorSeries.Size = new System.Drawing.Size(198, 20);
            this.txtbox_MajorSeries.TabIndex = 1;
            // 
            // txtbox_Author
            // 
            this.txtbox_Author.Location = new System.Drawing.Point(72, 66);
            this.txtbox_Author.Name = "txtbox_Author";
            this.txtbox_Author.Size = new System.Drawing.Size(198, 20);
            this.txtbox_Author.TabIndex = 2;
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Location = new System.Drawing.Point(48, 15);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(18, 13);
            this.lbl_ID.TabIndex = 4;
            this.lbl_ID.Text = "ID";
            // 
            // lbl_MajorSeries
            // 
            this.lbl_MajorSeries.AutoSize = true;
            this.lbl_MajorSeries.Location = new System.Drawing.Point(7, 42);
            this.lbl_MajorSeries.Name = "lbl_MajorSeries";
            this.lbl_MajorSeries.Size = new System.Drawing.Size(62, 13);
            this.lbl_MajorSeries.TabIndex = 5;
            this.lbl_MajorSeries.Text = "MajorSeries";
            // 
            // lbl_Author
            // 
            this.lbl_Author.AutoSize = true;
            this.lbl_Author.Location = new System.Drawing.Point(31, 69);
            this.lbl_Author.Name = "lbl_Author";
            this.lbl_Author.Size = new System.Drawing.Size(38, 13);
            this.lbl_Author.TabIndex = 6;
            this.lbl_Author.Text = "Author";
            // 
            // btn_SaveBook
            // 
            this.btn_SaveBook.Location = new System.Drawing.Point(111, 170);
            this.btn_SaveBook.Name = "btn_SaveBook";
            this.btn_SaveBook.Size = new System.Drawing.Size(75, 23);
            this.btn_SaveBook.TabIndex = 8;
            this.btn_SaveBook.Text = "Сохранить";
            this.btn_SaveBook.UseVisualStyleBackColor = true;
            this.btn_SaveBook.Click += new System.EventHandler(this.btn_SaveBook_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(192, 170);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(75, 23);
            this.btn_Close.TabIndex = 9;
            this.btn_Close.Text = "Выход";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssl_StatusBookCreate});
            this.statusStrip1.Location = new System.Drawing.Point(0, 196);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(279, 22);
            this.statusStrip1.TabIndex = 99;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tssl_StatusBookCreate
            // 
            this.tssl_StatusBookCreate.Name = "tssl_StatusBookCreate";
            this.tssl_StatusBookCreate.Size = new System.Drawing.Size(43, 17);
            this.tssl_StatusBookCreate.Text = "Статус";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Location = new System.Drawing.Point(34, 96);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(35, 13);
            this.lbl_Name.TabIndex = 7;
            this.lbl_Name.Text = "Name";
            // 
            // txtbox_Name
            // 
            this.txtbox_Name.Location = new System.Drawing.Point(72, 93);
            this.txtbox_Name.Name = "txtbox_Name";
            this.txtbox_Name.Size = new System.Drawing.Size(198, 20);
            this.txtbox_Name.TabIndex = 3;
            // 
            // txtbox_Series
            // 
            this.txtbox_Series.Location = new System.Drawing.Point(72, 120);
            this.txtbox_Series.Name = "txtbox_Series";
            this.txtbox_Series.Size = new System.Drawing.Size(198, 20);
            this.txtbox_Series.TabIndex = 4;
            // 
            // lbl_Series
            // 
            this.lbl_Series.AutoSize = true;
            this.lbl_Series.Location = new System.Drawing.Point(30, 123);
            this.lbl_Series.Name = "lbl_Series";
            this.lbl_Series.Size = new System.Drawing.Size(36, 13);
            this.lbl_Series.TabIndex = 101;
            this.lbl_Series.Text = "Series";
            // 
            // form_CreateBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 218);
            this.Controls.Add(this.lbl_Series);
            this.Controls.Add(this.txtbox_Series);
            this.Controls.Add(this.txtbox_Name);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_SaveBook);
            this.Controls.Add(this.lbl_Author);
            this.Controls.Add(this.lbl_MajorSeries);
            this.Controls.Add(this.lbl_ID);
            this.Controls.Add(this.txtbox_Author);
            this.Controls.Add(this.txtbox_MajorSeries);
            this.Controls.Add(this.txtbox_ID);
            this.Name = "form_CreateBook";
            this.Text = "Создать книгу";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.Label lbl_MajorSeries;
        private System.Windows.Forms.Label lbl_Author;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_SaveBook;
        private System.Windows.Forms.TextBox txtbox_MajorSeries;
        private System.Windows.Forms.TextBox txtbox_Author;
        private System.Windows.Forms.TextBox txtbox_ID;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tssl_StatusBookCreate;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.TextBox txtbox_Name;
        private System.Windows.Forms.TextBox txtbox_Series;
        private System.Windows.Forms.Label lbl_Series;
    }
}