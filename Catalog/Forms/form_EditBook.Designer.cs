namespace Catalog
{
    partial class form_EditBook
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
            this.ofd_FileSelector = new System.Windows.Forms.OpenFileDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbl_Notes = new System.Windows.Forms.Label();
            this.lbl_Artist = new System.Windows.Forms.Label();
            this.lbl_Translator = new System.Windows.Forms.Label();
            this.lbl_ISBN = new System.Windows.Forms.Label();
            this.lbl_PrintCity = new System.Windows.Forms.Label();
            this.lbl_PrintYear = new System.Windows.Forms.Label();
            this.lbl_Publisher = new System.Windows.Forms.Label();
            this.lbl_PagesCount = new System.Windows.Forms.Label();
            this.lbl_Genre = new System.Windows.Forms.Label();
            this.lbl_NumberInSeries = new System.Windows.Forms.Label();
            this.txtbox_Notes = new System.Windows.Forms.TextBox();
            this.txtbox_Artist = new System.Windows.Forms.TextBox();
            this.txtbox_Translator = new System.Windows.Forms.TextBox();
            this.txtbox_ISBN = new System.Windows.Forms.TextBox();
            this.txtbox_PrintCity = new System.Windows.Forms.TextBox();
            this.txtbox_PrintYear = new System.Windows.Forms.TextBox();
            this.txtbox_Publisher = new System.Windows.Forms.TextBox();
            this.txtbox_PagesCount = new System.Windows.Forms.TextBox();
            this.txtbox_Genre = new System.Windows.Forms.TextBox();
            this.txtbox_NumberInSeries = new System.Windows.Forms.TextBox();
            this.flp_FileSelector = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_AddFiles = new System.Windows.Forms.Button();
            this.lbl_Series = new System.Windows.Forms.Label();
            this.txtbox_Series = new System.Windows.Forms.TextBox();
            this.txtbox_Title = new System.Windows.Forms.TextBox();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tssl_StatusBookEdit = new System.Windows.Forms.ToolStripStatusLabel();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_SaveBook = new System.Windows.Forms.Button();
            this.lbl_Author = new System.Windows.Forms.Label();
            this.lbl_MajorSeries = new System.Windows.Forms.Label();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.txtbox_Author = new System.Windows.Forms.TextBox();
            this.txtbox_MajorSeries = new System.Windows.Forms.TextBox();
            this.txtbox_ID = new System.Windows.Forms.TextBox();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(325, 9);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(316, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "Список изображений";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_Notes
            // 
            this.lbl_Notes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Notes.AutoSize = true;
            this.lbl_Notes.Location = new System.Drawing.Point(64, 389);
            this.lbl_Notes.Name = "lbl_Notes";
            this.lbl_Notes.Size = new System.Drawing.Size(51, 13);
            this.lbl_Notes.TabIndex = 159;
            this.lbl_Notes.Text = "Заметки";
            // 
            // lbl_Artist
            // 
            this.lbl_Artist.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Artist.AutoSize = true;
            this.lbl_Artist.Location = new System.Drawing.Point(58, 362);
            this.lbl_Artist.Name = "lbl_Artist";
            this.lbl_Artist.Size = new System.Drawing.Size(57, 13);
            this.lbl_Artist.TabIndex = 158;
            this.lbl_Artist.Text = "Художник";
            // 
            // lbl_Translator
            // 
            this.lbl_Translator.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Translator.AutoSize = true;
            this.lbl_Translator.Location = new System.Drawing.Point(47, 336);
            this.lbl_Translator.Name = "lbl_Translator";
            this.lbl_Translator.Size = new System.Drawing.Size(68, 13);
            this.lbl_Translator.TabIndex = 157;
            this.lbl_Translator.Text = "Переводчик";
            // 
            // lbl_ISBN
            // 
            this.lbl_ISBN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_ISBN.AutoSize = true;
            this.lbl_ISBN.Location = new System.Drawing.Point(83, 309);
            this.lbl_ISBN.Name = "lbl_ISBN";
            this.lbl_ISBN.Size = new System.Drawing.Size(32, 13);
            this.lbl_ISBN.TabIndex = 156;
            this.lbl_ISBN.Text = "ISBN";
            // 
            // lbl_PrintCity
            // 
            this.lbl_PrintCity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_PrintCity.AutoSize = true;
            this.lbl_PrintCity.Location = new System.Drawing.Point(41, 282);
            this.lbl_PrintCity.Name = "lbl_PrintCity";
            this.lbl_PrintCity.Size = new System.Drawing.Size(74, 13);
            this.lbl_PrintCity.TabIndex = 155;
            this.lbl_PrintCity.Text = "Город печати";
            // 
            // lbl_PrintYear
            // 
            this.lbl_PrintYear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_PrintYear.AutoSize = true;
            this.lbl_PrintYear.Location = new System.Drawing.Point(44, 255);
            this.lbl_PrintYear.Name = "lbl_PrintYear";
            this.lbl_PrintYear.Size = new System.Drawing.Size(71, 13);
            this.lbl_PrintYear.TabIndex = 154;
            this.lbl_PrintYear.Text = "Год выпуска";
            // 
            // lbl_Publisher
            // 
            this.lbl_Publisher.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Publisher.AutoSize = true;
            this.lbl_Publisher.Location = new System.Drawing.Point(59, 228);
            this.lbl_Publisher.Name = "lbl_Publisher";
            this.lbl_Publisher.Size = new System.Drawing.Size(56, 13);
            this.lbl_Publisher.TabIndex = 153;
            this.lbl_Publisher.Text = "Издатель";
            // 
            // lbl_PagesCount
            // 
            this.lbl_PagesCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_PagesCount.AutoSize = true;
            this.lbl_PagesCount.Location = new System.Drawing.Point(30, 201);
            this.lbl_PagesCount.Name = "lbl_PagesCount";
            this.lbl_PagesCount.Size = new System.Drawing.Size(85, 13);
            this.lbl_PagesCount.TabIndex = 152;
            this.lbl_PagesCount.Text = "Кол-во страниц";
            // 
            // lbl_Genre
            // 
            this.lbl_Genre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Genre.AutoSize = true;
            this.lbl_Genre.Location = new System.Drawing.Point(79, 174);
            this.lbl_Genre.Name = "lbl_Genre";
            this.lbl_Genre.Size = new System.Drawing.Size(36, 13);
            this.lbl_Genre.TabIndex = 151;
            this.lbl_Genre.Text = "Жанр";
            // 
            // lbl_NumberInSeries
            // 
            this.lbl_NumberInSeries.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_NumberInSeries.AutoSize = true;
            this.lbl_NumberInSeries.Location = new System.Drawing.Point(32, 147);
            this.lbl_NumberInSeries.Name = "lbl_NumberInSeries";
            this.lbl_NumberInSeries.Size = new System.Drawing.Size(83, 13);
            this.lbl_NumberInSeries.TabIndex = 150;
            this.lbl_NumberInSeries.Text = "Номер в серии";
            // 
            // txtbox_Notes
            // 
            this.txtbox_Notes.Location = new System.Drawing.Point(121, 386);
            this.txtbox_Notes.Multiline = true;
            this.txtbox_Notes.Name = "txtbox_Notes";
            this.txtbox_Notes.Size = new System.Drawing.Size(198, 82);
            this.txtbox_Notes.TabIndex = 143;
            // 
            // txtbox_Artist
            // 
            this.txtbox_Artist.Location = new System.Drawing.Point(121, 359);
            this.txtbox_Artist.Name = "txtbox_Artist";
            this.txtbox_Artist.Size = new System.Drawing.Size(198, 20);
            this.txtbox_Artist.TabIndex = 142;
            // 
            // txtbox_Translator
            // 
            this.txtbox_Translator.Location = new System.Drawing.Point(121, 333);
            this.txtbox_Translator.Name = "txtbox_Translator";
            this.txtbox_Translator.Size = new System.Drawing.Size(198, 20);
            this.txtbox_Translator.TabIndex = 141;
            // 
            // txtbox_ISBN
            // 
            this.txtbox_ISBN.Location = new System.Drawing.Point(121, 306);
            this.txtbox_ISBN.Name = "txtbox_ISBN";
            this.txtbox_ISBN.Size = new System.Drawing.Size(198, 20);
            this.txtbox_ISBN.TabIndex = 140;
            // 
            // txtbox_PrintCity
            // 
            this.txtbox_PrintCity.Location = new System.Drawing.Point(121, 279);
            this.txtbox_PrintCity.Name = "txtbox_PrintCity";
            this.txtbox_PrintCity.Size = new System.Drawing.Size(198, 20);
            this.txtbox_PrintCity.TabIndex = 139;
            // 
            // txtbox_PrintYear
            // 
            this.txtbox_PrintYear.Location = new System.Drawing.Point(121, 252);
            this.txtbox_PrintYear.Name = "txtbox_PrintYear";
            this.txtbox_PrintYear.Size = new System.Drawing.Size(198, 20);
            this.txtbox_PrintYear.TabIndex = 138;
            // 
            // txtbox_Publisher
            // 
            this.txtbox_Publisher.Location = new System.Drawing.Point(121, 225);
            this.txtbox_Publisher.Name = "txtbox_Publisher";
            this.txtbox_Publisher.Size = new System.Drawing.Size(198, 20);
            this.txtbox_Publisher.TabIndex = 137;
            // 
            // txtbox_PagesCount
            // 
            this.txtbox_PagesCount.Location = new System.Drawing.Point(121, 198);
            this.txtbox_PagesCount.Name = "txtbox_PagesCount";
            this.txtbox_PagesCount.Size = new System.Drawing.Size(198, 20);
            this.txtbox_PagesCount.TabIndex = 135;
            // 
            // txtbox_Genre
            // 
            this.txtbox_Genre.Location = new System.Drawing.Point(121, 171);
            this.txtbox_Genre.Name = "txtbox_Genre";
            this.txtbox_Genre.Size = new System.Drawing.Size(198, 20);
            this.txtbox_Genre.TabIndex = 134;
            // 
            // txtbox_NumberInSeries
            // 
            this.txtbox_NumberInSeries.Location = new System.Drawing.Point(121, 144);
            this.txtbox_NumberInSeries.Name = "txtbox_NumberInSeries";
            this.txtbox_NumberInSeries.Size = new System.Drawing.Size(198, 20);
            this.txtbox_NumberInSeries.TabIndex = 132;
            // 
            // flp_FileSelector
            // 
            this.flp_FileSelector.Location = new System.Drawing.Point(325, 36);
            this.flp_FileSelector.Name = "flp_FileSelector";
            this.flp_FileSelector.Size = new System.Drawing.Size(316, 336);
            this.flp_FileSelector.TabIndex = 144;
            // 
            // btn_AddFiles
            // 
            this.btn_AddFiles.Location = new System.Drawing.Point(485, 378);
            this.btn_AddFiles.Name = "btn_AddFiles";
            this.btn_AddFiles.Size = new System.Drawing.Size(151, 23);
            this.btn_AddFiles.TabIndex = 145;
            this.btn_AddFiles.Text = "Добавить файлы";
            this.btn_AddFiles.UseVisualStyleBackColor = true;
            this.btn_AddFiles.Click += new System.EventHandler(this.btn_AddFiles_Click);
            // 
            // lbl_Series
            // 
            this.lbl_Series.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Series.AutoSize = true;
            this.lbl_Series.Location = new System.Drawing.Point(77, 120);
            this.lbl_Series.Name = "lbl_Series";
            this.lbl_Series.Size = new System.Drawing.Size(38, 13);
            this.lbl_Series.TabIndex = 149;
            this.lbl_Series.Text = "Серия";
            // 
            // txtbox_Series
            // 
            this.txtbox_Series.Location = new System.Drawing.Point(121, 117);
            this.txtbox_Series.Name = "txtbox_Series";
            this.txtbox_Series.Size = new System.Drawing.Size(198, 20);
            this.txtbox_Series.TabIndex = 130;
            // 
            // txtbox_Title
            // 
            this.txtbox_Title.Location = new System.Drawing.Point(121, 90);
            this.txtbox_Title.Name = "txtbox_Title";
            this.txtbox_Title.Size = new System.Drawing.Size(198, 20);
            this.txtbox_Title.TabIndex = 128;
            // 
            // lbl_Name
            // 
            this.lbl_Name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Location = new System.Drawing.Point(26, 93);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(89, 13);
            this.lbl_Name.TabIndex = 136;
            this.lbl_Name.Text = "Название книги";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssl_StatusBookEdit});
            this.statusStrip1.Location = new System.Drawing.Point(0, 490);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(649, 22);
            this.statusStrip1.TabIndex = 148;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tssl_StatusBookEdit
            // 
            this.tssl_StatusBookEdit.Name = "tssl_StatusBookEdit";
            this.tssl_StatusBookEdit.Size = new System.Drawing.Size(43, 17);
            this.tssl_StatusBookEdit.Text = "Статус";
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(566, 458);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(75, 23);
            this.btn_Close.TabIndex = 147;
            this.btn_Close.Text = "Выход";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_SaveBook
            // 
            this.btn_SaveBook.Location = new System.Drawing.Point(485, 458);
            this.btn_SaveBook.Name = "btn_SaveBook";
            this.btn_SaveBook.Size = new System.Drawing.Size(75, 23);
            this.btn_SaveBook.TabIndex = 146;
            this.btn_SaveBook.Text = "Сохранить";
            this.btn_SaveBook.UseVisualStyleBackColor = true;
            this.btn_SaveBook.Click += new System.EventHandler(this.btn_SaveBook_Click);
            // 
            // lbl_Author
            // 
            this.lbl_Author.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Author.AutoSize = true;
            this.lbl_Author.Location = new System.Drawing.Point(78, 66);
            this.lbl_Author.Name = "lbl_Author";
            this.lbl_Author.Size = new System.Drawing.Size(37, 13);
            this.lbl_Author.TabIndex = 133;
            this.lbl_Author.Text = "Автор";
            // 
            // lbl_MajorSeries
            // 
            this.lbl_MajorSeries.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_MajorSeries.AutoSize = true;
            this.lbl_MajorSeries.Location = new System.Drawing.Point(4, 39);
            this.lbl_MajorSeries.Name = "lbl_MajorSeries";
            this.lbl_MajorSeries.Size = new System.Drawing.Size(111, 13);
            this.lbl_MajorSeries.TabIndex = 131;
            this.lbl_MajorSeries.Text = "Серия издательства";
            // 
            // lbl_ID
            // 
            this.lbl_ID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Location = new System.Drawing.Point(97, 12);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(18, 13);
            this.lbl_ID.TabIndex = 129;
            this.lbl_ID.Text = "ID";
            // 
            // txtbox_Author
            // 
            this.txtbox_Author.Location = new System.Drawing.Point(121, 63);
            this.txtbox_Author.Name = "txtbox_Author";
            this.txtbox_Author.Size = new System.Drawing.Size(198, 20);
            this.txtbox_Author.TabIndex = 127;
            // 
            // txtbox_MajorSeries
            // 
            this.txtbox_MajorSeries.Location = new System.Drawing.Point(121, 36);
            this.txtbox_MajorSeries.Name = "txtbox_MajorSeries";
            this.txtbox_MajorSeries.Size = new System.Drawing.Size(198, 20);
            this.txtbox_MajorSeries.TabIndex = 126;
            // 
            // txtbox_ID
            // 
            this.txtbox_ID.Location = new System.Drawing.Point(121, 9);
            this.txtbox_ID.Name = "txtbox_ID";
            this.txtbox_ID.ReadOnly = true;
            this.txtbox_ID.Size = new System.Drawing.Size(198, 20);
            this.txtbox_ID.TabIndex = 125;
            this.txtbox_ID.TabStop = false;
            // 
            // form_EditBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 512);
            this.Controls.Add(this.textBox1);
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
            this.Controls.Add(this.txtbox_Title);
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
            this.MaximumSize = new System.Drawing.Size(665, 550);
            this.MinimumSize = new System.Drawing.Size(665, 550);
            this.Name = "form_EditBook";
            this.Text = "form_EditBook";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog ofd_FileSelector;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbl_Notes;
        private System.Windows.Forms.Label lbl_Artist;
        private System.Windows.Forms.Label lbl_Translator;
        private System.Windows.Forms.Label lbl_ISBN;
        private System.Windows.Forms.Label lbl_PrintCity;
        private System.Windows.Forms.Label lbl_PrintYear;
        private System.Windows.Forms.Label lbl_Publisher;
        private System.Windows.Forms.Label lbl_PagesCount;
        private System.Windows.Forms.Label lbl_Genre;
        private System.Windows.Forms.Label lbl_NumberInSeries;
        public System.Windows.Forms.TextBox txtbox_Notes;
        public System.Windows.Forms.TextBox txtbox_Artist;
        public System.Windows.Forms.TextBox txtbox_Translator;
        public System.Windows.Forms.TextBox txtbox_ISBN;
        public System.Windows.Forms.TextBox txtbox_PrintCity;
        public System.Windows.Forms.TextBox txtbox_PrintYear;
        public System.Windows.Forms.TextBox txtbox_Publisher;
        public System.Windows.Forms.TextBox txtbox_PagesCount;
        public System.Windows.Forms.TextBox txtbox_Genre;
        public System.Windows.Forms.TextBox txtbox_NumberInSeries;
        public System.Windows.Forms.FlowLayoutPanel flp_FileSelector;
        public System.Windows.Forms.Button btn_AddFiles;
        private System.Windows.Forms.Label lbl_Series;
        public System.Windows.Forms.TextBox txtbox_Series;
        public System.Windows.Forms.TextBox txtbox_Title;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tssl_StatusBookEdit;
        public System.Windows.Forms.Button btn_Close;
        public System.Windows.Forms.Button btn_SaveBook;
        private System.Windows.Forms.Label lbl_Author;
        private System.Windows.Forms.Label lbl_MajorSeries;
        private System.Windows.Forms.Label lbl_ID;
        public System.Windows.Forms.TextBox txtbox_Author;
        public System.Windows.Forms.TextBox txtbox_MajorSeries;
        public System.Windows.Forms.TextBox txtbox_ID;
    }
}