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
            this.ofd_FileSelector = new System.Windows.Forms.OpenFileDialog();
            this.btn_AddFiles = new System.Windows.Forms.Button();
            this.flp_FileSelector = new System.Windows.Forms.FlowLayoutPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtbox_NumberInSeries = new System.Windows.Forms.TextBox();
            this.txtbox_Genre = new System.Windows.Forms.TextBox();
            this.txtbox_PagesCount = new System.Windows.Forms.TextBox();
            this.txtbox_Publisher = new System.Windows.Forms.TextBox();
            this.txtbox_PrintYear = new System.Windows.Forms.TextBox();
            this.txtbox_PrintCity = new System.Windows.Forms.TextBox();
            this.txtbox_ISBN = new System.Windows.Forms.TextBox();
            this.txtbox_Translator = new System.Windows.Forms.TextBox();
            this.txtbox_Artist = new System.Windows.Forms.TextBox();
            this.txtbox_Notes = new System.Windows.Forms.TextBox();
            this.lbl_NumberInSeries = new System.Windows.Forms.Label();
            this.lbl_Genre = new System.Windows.Forms.Label();
            this.lbl_PagesCount = new System.Windows.Forms.Label();
            this.lbl_Publisher = new System.Windows.Forms.Label();
            this.lbl_PrintYear = new System.Windows.Forms.Label();
            this.lbl_PrintCity = new System.Windows.Forms.Label();
            this.lbl_ISBN = new System.Windows.Forms.Label();
            this.lbl_Translator = new System.Windows.Forms.Label();
            this.lbl_Artist = new System.Windows.Forms.Label();
            this.lbl_Notes = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.flp_FileSelector.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtbox_ID
            // 
            this.txtbox_ID.Location = new System.Drawing.Point(103, 12);
            this.txtbox_ID.Name = "txtbox_ID";
            this.txtbox_ID.ReadOnly = true;
            this.txtbox_ID.Size = new System.Drawing.Size(198, 20);
            this.txtbox_ID.TabIndex = 0;
            this.txtbox_ID.TabStop = false;
            // 
            // txtbox_MajorSeries
            // 
            this.txtbox_MajorSeries.Location = new System.Drawing.Point(103, 39);
            this.txtbox_MajorSeries.Name = "txtbox_MajorSeries";
            this.txtbox_MajorSeries.Size = new System.Drawing.Size(198, 20);
            this.txtbox_MajorSeries.TabIndex = 1;
            // 
            // txtbox_Author
            // 
            this.txtbox_Author.Location = new System.Drawing.Point(103, 66);
            this.txtbox_Author.Name = "txtbox_Author";
            this.txtbox_Author.Size = new System.Drawing.Size(198, 20);
            this.txtbox_Author.TabIndex = 2;
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Location = new System.Drawing.Point(79, 15);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(18, 13);
            this.lbl_ID.TabIndex = 4;
            this.lbl_ID.Text = "ID";
            // 
            // lbl_MajorSeries
            // 
            this.lbl_MajorSeries.AutoSize = true;
            this.lbl_MajorSeries.Location = new System.Drawing.Point(38, 42);
            this.lbl_MajorSeries.Name = "lbl_MajorSeries";
            this.lbl_MajorSeries.Size = new System.Drawing.Size(62, 13);
            this.lbl_MajorSeries.TabIndex = 5;
            this.lbl_MajorSeries.Text = "MajorSeries";
            // 
            // lbl_Author
            // 
            this.lbl_Author.AutoSize = true;
            this.lbl_Author.Location = new System.Drawing.Point(62, 69);
            this.lbl_Author.Name = "lbl_Author";
            this.lbl_Author.Size = new System.Drawing.Size(38, 13);
            this.lbl_Author.TabIndex = 6;
            this.lbl_Author.Text = "Author";
            // 
            // btn_SaveBook
            // 
            this.btn_SaveBook.Location = new System.Drawing.Point(467, 464);
            this.btn_SaveBook.Name = "btn_SaveBook";
            this.btn_SaveBook.Size = new System.Drawing.Size(75, 23);
            this.btn_SaveBook.TabIndex = 58;
            this.btn_SaveBook.Text = "Сохранить";
            this.btn_SaveBook.UseVisualStyleBackColor = true;
            this.btn_SaveBook.Click += new System.EventHandler(this.btn_SaveBook_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(548, 464);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(75, 23);
            this.btn_Close.TabIndex = 59;
            this.btn_Close.Text = "Выход";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssl_StatusBookCreate});
            this.statusStrip1.Location = new System.Drawing.Point(0, 490);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(630, 22);
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
            this.lbl_Name.Location = new System.Drawing.Point(65, 96);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(35, 13);
            this.lbl_Name.TabIndex = 7;
            this.lbl_Name.Text = "Name";
            // 
            // txtbox_Name
            // 
            this.txtbox_Name.Location = new System.Drawing.Point(103, 93);
            this.txtbox_Name.Name = "txtbox_Name";
            this.txtbox_Name.Size = new System.Drawing.Size(198, 20);
            this.txtbox_Name.TabIndex = 3;
            // 
            // txtbox_Series
            // 
            this.txtbox_Series.Location = new System.Drawing.Point(103, 120);
            this.txtbox_Series.Name = "txtbox_Series";
            this.txtbox_Series.Size = new System.Drawing.Size(198, 20);
            this.txtbox_Series.TabIndex = 4;
            // 
            // lbl_Series
            // 
            this.lbl_Series.AutoSize = true;
            this.lbl_Series.Location = new System.Drawing.Point(61, 123);
            this.lbl_Series.Name = "lbl_Series";
            this.lbl_Series.Size = new System.Drawing.Size(36, 13);
            this.lbl_Series.TabIndex = 101;
            this.lbl_Series.Text = "Series";
            // 
            // btn_AddFiles
            // 
            this.btn_AddFiles.Location = new System.Drawing.Point(543, 387);
            this.btn_AddFiles.Name = "btn_AddFiles";
            this.btn_AddFiles.Size = new System.Drawing.Size(75, 23);
            this.btn_AddFiles.TabIndex = 57;
            this.btn_AddFiles.Text = "Add Files";
            this.btn_AddFiles.UseVisualStyleBackColor = true;
            this.btn_AddFiles.Click += new System.EventHandler(this.btn_AddFiles_Click);
            // 
            // flp_FileSelector
            // 
            this.flp_FileSelector.Controls.Add(this.textBox1);
            this.flp_FileSelector.Location = new System.Drawing.Point(307, 15);
            this.flp_FileSelector.Name = "flp_FileSelector";
            this.flp_FileSelector.Size = new System.Drawing.Size(316, 366);
            this.flp_FileSelector.TabIndex = 50;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(308, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Add preview files here";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtbox_NumberInSeries
            // 
            this.txtbox_NumberInSeries.Location = new System.Drawing.Point(103, 147);
            this.txtbox_NumberInSeries.Name = "txtbox_NumberInSeries";
            this.txtbox_NumberInSeries.Size = new System.Drawing.Size(198, 20);
            this.txtbox_NumberInSeries.TabIndex = 5;
            // 
            // txtbox_Genre
            // 
            this.txtbox_Genre.Location = new System.Drawing.Point(103, 174);
            this.txtbox_Genre.Name = "txtbox_Genre";
            this.txtbox_Genre.Size = new System.Drawing.Size(198, 20);
            this.txtbox_Genre.TabIndex = 6;
            // 
            // txtbox_PagesCount
            // 
            this.txtbox_PagesCount.Location = new System.Drawing.Point(103, 201);
            this.txtbox_PagesCount.Name = "txtbox_PagesCount";
            this.txtbox_PagesCount.Size = new System.Drawing.Size(198, 20);
            this.txtbox_PagesCount.TabIndex = 7;
            // 
            // txtbox_Publisher
            // 
            this.txtbox_Publisher.Location = new System.Drawing.Point(103, 228);
            this.txtbox_Publisher.Name = "txtbox_Publisher";
            this.txtbox_Publisher.Size = new System.Drawing.Size(198, 20);
            this.txtbox_Publisher.TabIndex = 8;
            // 
            // txtbox_PrintYear
            // 
            this.txtbox_PrintYear.Location = new System.Drawing.Point(103, 255);
            this.txtbox_PrintYear.Name = "txtbox_PrintYear";
            this.txtbox_PrintYear.Size = new System.Drawing.Size(198, 20);
            this.txtbox_PrintYear.TabIndex = 9;
            // 
            // txtbox_PrintCity
            // 
            this.txtbox_PrintCity.Location = new System.Drawing.Point(103, 282);
            this.txtbox_PrintCity.Name = "txtbox_PrintCity";
            this.txtbox_PrintCity.Size = new System.Drawing.Size(198, 20);
            this.txtbox_PrintCity.TabIndex = 10;
            // 
            // txtbox_ISBN
            // 
            this.txtbox_ISBN.Location = new System.Drawing.Point(103, 309);
            this.txtbox_ISBN.Name = "txtbox_ISBN";
            this.txtbox_ISBN.Size = new System.Drawing.Size(198, 20);
            this.txtbox_ISBN.TabIndex = 11;
            // 
            // txtbox_Translator
            // 
            this.txtbox_Translator.Location = new System.Drawing.Point(103, 336);
            this.txtbox_Translator.Name = "txtbox_Translator";
            this.txtbox_Translator.Size = new System.Drawing.Size(198, 20);
            this.txtbox_Translator.TabIndex = 12;
            // 
            // txtbox_Artist
            // 
            this.txtbox_Artist.Location = new System.Drawing.Point(103, 362);
            this.txtbox_Artist.Name = "txtbox_Artist";
            this.txtbox_Artist.Size = new System.Drawing.Size(198, 20);
            this.txtbox_Artist.TabIndex = 13;
            // 
            // txtbox_Notes
            // 
            this.txtbox_Notes.Location = new System.Drawing.Point(103, 389);
            this.txtbox_Notes.Multiline = true;
            this.txtbox_Notes.Name = "txtbox_Notes";
            this.txtbox_Notes.Size = new System.Drawing.Size(198, 82);
            this.txtbox_Notes.TabIndex = 14;
            // 
            // lbl_NumberInSeries
            // 
            this.lbl_NumberInSeries.AutoSize = true;
            this.lbl_NumberInSeries.Location = new System.Drawing.Point(18, 150);
            this.lbl_NumberInSeries.Name = "lbl_NumberInSeries";
            this.lbl_NumberInSeries.Size = new System.Drawing.Size(82, 13);
            this.lbl_NumberInSeries.TabIndex = 115;
            this.lbl_NumberInSeries.Text = "NumberInSeries";
            // 
            // lbl_Genre
            // 
            this.lbl_Genre.AutoSize = true;
            this.lbl_Genre.Location = new System.Drawing.Point(61, 177);
            this.lbl_Genre.Name = "lbl_Genre";
            this.lbl_Genre.Size = new System.Drawing.Size(36, 13);
            this.lbl_Genre.TabIndex = 116;
            this.lbl_Genre.Text = "Genre";
            // 
            // lbl_PagesCount
            // 
            this.lbl_PagesCount.AutoSize = true;
            this.lbl_PagesCount.Location = new System.Drawing.Point(32, 204);
            this.lbl_PagesCount.Name = "lbl_PagesCount";
            this.lbl_PagesCount.Size = new System.Drawing.Size(65, 13);
            this.lbl_PagesCount.TabIndex = 117;
            this.lbl_PagesCount.Text = "PagesCount";
            // 
            // lbl_Publisher
            // 
            this.lbl_Publisher.AutoSize = true;
            this.lbl_Publisher.Location = new System.Drawing.Point(47, 231);
            this.lbl_Publisher.Name = "lbl_Publisher";
            this.lbl_Publisher.Size = new System.Drawing.Size(50, 13);
            this.lbl_Publisher.TabIndex = 118;
            this.lbl_Publisher.Text = "Publisher";
            // 
            // lbl_PrintYear
            // 
            this.lbl_PrintYear.AutoSize = true;
            this.lbl_PrintYear.Location = new System.Drawing.Point(47, 258);
            this.lbl_PrintYear.Name = "lbl_PrintYear";
            this.lbl_PrintYear.Size = new System.Drawing.Size(50, 13);
            this.lbl_PrintYear.TabIndex = 119;
            this.lbl_PrintYear.Text = "PrintYear";
            // 
            // lbl_PrintCity
            // 
            this.lbl_PrintCity.AutoSize = true;
            this.lbl_PrintCity.Location = new System.Drawing.Point(52, 285);
            this.lbl_PrintCity.Name = "lbl_PrintCity";
            this.lbl_PrintCity.Size = new System.Drawing.Size(45, 13);
            this.lbl_PrintCity.TabIndex = 120;
            this.lbl_PrintCity.Text = "PrintCity";
            // 
            // lbl_ISBN
            // 
            this.lbl_ISBN.AutoSize = true;
            this.lbl_ISBN.Location = new System.Drawing.Point(65, 312);
            this.lbl_ISBN.Name = "lbl_ISBN";
            this.lbl_ISBN.Size = new System.Drawing.Size(32, 13);
            this.lbl_ISBN.TabIndex = 121;
            this.lbl_ISBN.Text = "ISBN";
            // 
            // lbl_Translator
            // 
            this.lbl_Translator.AutoSize = true;
            this.lbl_Translator.Location = new System.Drawing.Point(43, 339);
            this.lbl_Translator.Name = "lbl_Translator";
            this.lbl_Translator.Size = new System.Drawing.Size(54, 13);
            this.lbl_Translator.TabIndex = 122;
            this.lbl_Translator.Text = "Translator";
            // 
            // lbl_Artist
            // 
            this.lbl_Artist.AutoSize = true;
            this.lbl_Artist.Location = new System.Drawing.Point(67, 365);
            this.lbl_Artist.Name = "lbl_Artist";
            this.lbl_Artist.Size = new System.Drawing.Size(30, 13);
            this.lbl_Artist.TabIndex = 123;
            this.lbl_Artist.Text = "Artist";
            // 
            // lbl_Notes
            // 
            this.lbl_Notes.AutoSize = true;
            this.lbl_Notes.Location = new System.Drawing.Point(62, 392);
            this.lbl_Notes.Name = "lbl_Notes";
            this.lbl_Notes.Size = new System.Drawing.Size(35, 13);
            this.lbl_Notes.TabIndex = 124;
            this.lbl_Notes.Text = "Notes";
            // 
            // form_CreateBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 512);
            this.Controls.Add(this.lbl_Notes);
            this.Controls.Add(this.lbl_Artist);
            this.Controls.Add(this.lbl_Translator);
            this.Controls.Add(this.lbl_ISBN);
            this.Controls.Add(this.lbl_PrintCity);
            this.Controls.Add(this.lbl_PrintYear);
            this.Controls.Add(this.lbl_Publisher);
            this.Controls.Add(this.lbl_PagesCount);
            this.Controls.Add(this.lbl_Genre);
            this.Controls.Add(this.lbl_NumberInSeries);
            this.Controls.Add(this.txtbox_Notes);
            this.Controls.Add(this.txtbox_Artist);
            this.Controls.Add(this.txtbox_Translator);
            this.Controls.Add(this.txtbox_ISBN);
            this.Controls.Add(this.txtbox_PrintCity);
            this.Controls.Add(this.txtbox_PrintYear);
            this.Controls.Add(this.txtbox_Publisher);
            this.Controls.Add(this.txtbox_PagesCount);
            this.Controls.Add(this.txtbox_Genre);
            this.Controls.Add(this.txtbox_NumberInSeries);
            this.Controls.Add(this.flp_FileSelector);
            this.Controls.Add(this.btn_AddFiles);
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
            this.flp_FileSelector.ResumeLayout(false);
            this.flp_FileSelector.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.Label lbl_MajorSeries;
        private System.Windows.Forms.Label lbl_Author;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tssl_StatusBookCreate;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_Series;
        private System.Windows.Forms.OpenFileDialog ofd_FileSelector;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbl_NumberInSeries;
        private System.Windows.Forms.Label lbl_Genre;
        private System.Windows.Forms.Label lbl_PagesCount;
        private System.Windows.Forms.Label lbl_Publisher;
        private System.Windows.Forms.Label lbl_PrintYear;
        private System.Windows.Forms.Label lbl_PrintCity;
        private System.Windows.Forms.Label lbl_ISBN;
        private System.Windows.Forms.Label lbl_Translator;
        private System.Windows.Forms.Label lbl_Artist;
        private System.Windows.Forms.Label lbl_Notes;
        public System.Windows.Forms.Button btn_Close;
        public System.Windows.Forms.Button btn_SaveBook;
        public System.Windows.Forms.TextBox txtbox_Author;
        public System.Windows.Forms.TextBox txtbox_ID;
        public System.Windows.Forms.TextBox txtbox_Name;
        public System.Windows.Forms.TextBox txtbox_Series;
        public System.Windows.Forms.Button btn_AddFiles;
        public System.Windows.Forms.FlowLayoutPanel flp_FileSelector;
        public System.Windows.Forms.TextBox txtbox_NumberInSeries;
        public System.Windows.Forms.TextBox txtbox_Genre;
        public System.Windows.Forms.TextBox txtbox_PagesCount;
        public System.Windows.Forms.TextBox txtbox_Publisher;
        public System.Windows.Forms.TextBox txtbox_PrintYear;
        public System.Windows.Forms.TextBox txtbox_PrintCity;
        public System.Windows.Forms.TextBox txtbox_ISBN;
        public System.Windows.Forms.TextBox txtbox_Translator;
        public System.Windows.Forms.TextBox txtbox_Artist;
        public System.Windows.Forms.TextBox txtbox_Notes;
        public System.Windows.Forms.TextBox txtbox_MajorSeries;
    }
}