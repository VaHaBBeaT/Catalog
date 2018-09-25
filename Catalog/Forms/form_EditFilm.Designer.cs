namespace Catalog
{
    partial class form_EditFilm
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
            this.cmbbox_MPAA = new System.Windows.Forms.ComboBox();
            this.lbl_Premiere = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbl_Notes = new System.Windows.Forms.Label();
            this.lbl_Grosses = new System.Windows.Forms.Label();
            this.lbl_CriticsRating = new System.Windows.Forms.Label();
            this.lbl_MPAARating = new System.Windows.Forms.Label();
            this.lbl_Country = new System.Windows.Forms.Label();
            this.lbl_Length = new System.Windows.Forms.Label();
            this.lbl_Genre = new System.Windows.Forms.Label();
            this.txtbox_Notes = new System.Windows.Forms.TextBox();
            this.txtbox_Grosses = new System.Windows.Forms.TextBox();
            this.txtbox_CriticsRating = new System.Windows.Forms.TextBox();
            this.txtbox_Premiere = new System.Windows.Forms.TextBox();
            this.txtbox_Country = new System.Windows.Forms.TextBox();
            this.txtbox_Length = new System.Windows.Forms.TextBox();
            this.txtbox_Genre = new System.Windows.Forms.TextBox();
            this.flp_FileSelector = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_AddFiles = new System.Windows.Forms.Button();
            this.lbl_Actors = new System.Windows.Forms.Label();
            this.txtbox_Actors = new System.Windows.Forms.TextBox();
            this.txtbox_Title = new System.Windows.Forms.TextBox();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tssl_StatusFilmEdit = new System.Windows.Forms.ToolStripStatusLabel();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_SaveBook = new System.Windows.Forms.Button();
            this.lbl_Producer = new System.Windows.Forms.Label();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.txtbox_Producer = new System.Windows.Forms.TextBox();
            this.txtbox_ID = new System.Windows.Forms.TextBox();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbbox_MPAA
            // 
            this.cmbbox_MPAA.FormattingEnabled = true;
            this.cmbbox_MPAA.Items.AddRange(new object[] {
            "G - General Audiences",
            "PG - Parental Guidance",
            "PG-13 - Parents Strongly Cautioned",
            "R - Restricted",
            "NC-17 - Adults Only",
            "NR - Not Rated"});
            this.cmbbox_MPAA.Location = new System.Drawing.Point(94, 281);
            this.cmbbox_MPAA.Name = "cmbbox_MPAA";
            this.cmbbox_MPAA.Size = new System.Drawing.Size(198, 21);
            this.cmbbox_MPAA.TabIndex = 158;
            // 
            // lbl_Premiere
            // 
            this.lbl_Premiere.AutoSize = true;
            this.lbl_Premiere.Location = new System.Drawing.Point(29, 258);
            this.lbl_Premiere.Name = "lbl_Premiere";
            this.lbl_Premiere.Size = new System.Drawing.Size(59, 13);
            this.lbl_Premiere.TabIndex = 170;
            this.lbl_Premiere.Text = "Премьера";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(298, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(314, 20);
            this.textBox1.TabIndex = 162;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "Список изображений";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_Notes
            // 
            this.lbl_Notes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Notes.AutoSize = true;
            this.lbl_Notes.Location = new System.Drawing.Point(37, 364);
            this.lbl_Notes.Name = "lbl_Notes";
            this.lbl_Notes.Size = new System.Drawing.Size(51, 13);
            this.lbl_Notes.TabIndex = 174;
            this.lbl_Notes.Text = "Заметки";
            // 
            // lbl_Grosses
            // 
            this.lbl_Grosses.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Grosses.AutoSize = true;
            this.lbl_Grosses.Location = new System.Drawing.Point(33, 337);
            this.lbl_Grosses.Name = "lbl_Grosses";
            this.lbl_Grosses.Size = new System.Drawing.Size(55, 13);
            this.lbl_Grosses.TabIndex = 173;
            this.lbl_Grosses.Text = "Сборы ($)";
            // 
            // lbl_CriticsRating
            // 
            this.lbl_CriticsRating.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_CriticsRating.AutoSize = true;
            this.lbl_CriticsRating.Location = new System.Drawing.Point(11, 311);
            this.lbl_CriticsRating.Name = "lbl_CriticsRating";
            this.lbl_CriticsRating.Size = new System.Drawing.Size(77, 13);
            this.lbl_CriticsRating.TabIndex = 172;
            this.lbl_CriticsRating.Text = "Рейтинг крит.";
            // 
            // lbl_MPAARating
            // 
            this.lbl_MPAARating.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_MPAARating.AutoSize = true;
            this.lbl_MPAARating.Location = new System.Drawing.Point(7, 284);
            this.lbl_MPAARating.Name = "lbl_MPAARating";
            this.lbl_MPAARating.Size = new System.Drawing.Size(81, 13);
            this.lbl_MPAARating.TabIndex = 171;
            this.lbl_MPAARating.Text = "Рейтинг MPAA";
            // 
            // lbl_Country
            // 
            this.lbl_Country.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Country.AutoSize = true;
            this.lbl_Country.Location = new System.Drawing.Point(45, 231);
            this.lbl_Country.Name = "lbl_Country";
            this.lbl_Country.Size = new System.Drawing.Size(43, 13);
            this.lbl_Country.TabIndex = 169;
            this.lbl_Country.Text = "Страна";
            // 
            // lbl_Length
            // 
            this.lbl_Length.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Length.AutoSize = true;
            this.lbl_Length.Location = new System.Drawing.Point(8, 204);
            this.lbl_Length.Name = "lbl_Length";
            this.lbl_Length.Size = new System.Drawing.Size(80, 13);
            this.lbl_Length.TabIndex = 168;
            this.lbl_Length.Text = "Длительность";
            // 
            // lbl_Genre
            // 
            this.lbl_Genre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Genre.AutoSize = true;
            this.lbl_Genre.Location = new System.Drawing.Point(52, 67);
            this.lbl_Genre.Name = "lbl_Genre";
            this.lbl_Genre.Size = new System.Drawing.Size(36, 13);
            this.lbl_Genre.TabIndex = 165;
            this.lbl_Genre.Text = "Жанр";
            // 
            // txtbox_Notes
            // 
            this.txtbox_Notes.Location = new System.Drawing.Point(94, 361);
            this.txtbox_Notes.Multiline = true;
            this.txtbox_Notes.Name = "txtbox_Notes";
            this.txtbox_Notes.Size = new System.Drawing.Size(198, 82);
            this.txtbox_Notes.TabIndex = 161;
            // 
            // txtbox_Grosses
            // 
            this.txtbox_Grosses.Location = new System.Drawing.Point(94, 334);
            this.txtbox_Grosses.Name = "txtbox_Grosses";
            this.txtbox_Grosses.Size = new System.Drawing.Size(198, 20);
            this.txtbox_Grosses.TabIndex = 160;
            // 
            // txtbox_CriticsRating
            // 
            this.txtbox_CriticsRating.Location = new System.Drawing.Point(94, 308);
            this.txtbox_CriticsRating.Name = "txtbox_CriticsRating";
            this.txtbox_CriticsRating.Size = new System.Drawing.Size(198, 20);
            this.txtbox_CriticsRating.TabIndex = 159;
            // 
            // txtbox_Premiere
            // 
            this.txtbox_Premiere.Location = new System.Drawing.Point(94, 255);
            this.txtbox_Premiere.Name = "txtbox_Premiere";
            this.txtbox_Premiere.Size = new System.Drawing.Size(198, 20);
            this.txtbox_Premiere.TabIndex = 157;
            // 
            // txtbox_Country
            // 
            this.txtbox_Country.Location = new System.Drawing.Point(94, 229);
            this.txtbox_Country.Name = "txtbox_Country";
            this.txtbox_Country.Size = new System.Drawing.Size(198, 20);
            this.txtbox_Country.TabIndex = 156;
            // 
            // txtbox_Length
            // 
            this.txtbox_Length.Location = new System.Drawing.Point(94, 201);
            this.txtbox_Length.Name = "txtbox_Length";
            this.txtbox_Length.Size = new System.Drawing.Size(198, 20);
            this.txtbox_Length.TabIndex = 155;
            // 
            // txtbox_Genre
            // 
            this.txtbox_Genre.Location = new System.Drawing.Point(94, 64);
            this.txtbox_Genre.Name = "txtbox_Genre";
            this.txtbox_Genre.Size = new System.Drawing.Size(198, 20);
            this.txtbox_Genre.TabIndex = 152;
            // 
            // flp_FileSelector
            // 
            this.flp_FileSelector.Location = new System.Drawing.Point(298, 39);
            this.flp_FileSelector.Name = "flp_FileSelector";
            this.flp_FileSelector.Size = new System.Drawing.Size(314, 315);
            this.flp_FileSelector.TabIndex = 175;
            // 
            // btn_AddFiles
            // 
            this.btn_AddFiles.Location = new System.Drawing.Point(456, 360);
            this.btn_AddFiles.Name = "btn_AddFiles";
            this.btn_AddFiles.Size = new System.Drawing.Size(156, 23);
            this.btn_AddFiles.TabIndex = 176;
            this.btn_AddFiles.Text = "Добавить файлы";
            this.btn_AddFiles.UseVisualStyleBackColor = true;
            this.btn_AddFiles.Click += new System.EventHandler(this.btn_AddFiles_Click);
            // 
            // lbl_Actors
            // 
            this.lbl_Actors.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Actors.AutoSize = true;
            this.lbl_Actors.Location = new System.Drawing.Point(43, 119);
            this.lbl_Actors.Name = "lbl_Actors";
            this.lbl_Actors.Size = new System.Drawing.Size(45, 13);
            this.lbl_Actors.TabIndex = 167;
            this.lbl_Actors.Text = "Актеры";
            // 
            // txtbox_Actors
            // 
            this.txtbox_Actors.Location = new System.Drawing.Point(94, 116);
            this.txtbox_Actors.Multiline = true;
            this.txtbox_Actors.Name = "txtbox_Actors";
            this.txtbox_Actors.Size = new System.Drawing.Size(198, 79);
            this.txtbox_Actors.TabIndex = 154;
            // 
            // txtbox_Title
            // 
            this.txtbox_Title.Location = new System.Drawing.Point(94, 38);
            this.txtbox_Title.Name = "txtbox_Title";
            this.txtbox_Title.Size = new System.Drawing.Size(198, 20);
            this.txtbox_Title.TabIndex = 151;
            // 
            // lbl_Name
            // 
            this.lbl_Name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Location = new System.Drawing.Point(31, 41);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(57, 13);
            this.lbl_Name.TabIndex = 164;
            this.lbl_Name.Text = "Название";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssl_StatusFilmEdit});
            this.statusStrip1.Location = new System.Drawing.Point(0, 454);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(624, 22);
            this.statusStrip1.TabIndex = 179;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tssl_StatusFilmEdit
            // 
            this.tssl_StatusFilmEdit.Name = "tssl_StatusFilmEdit";
            this.tssl_StatusFilmEdit.Size = new System.Drawing.Size(43, 17);
            this.tssl_StatusFilmEdit.Text = "Статус";
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(537, 420);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(75, 23);
            this.btn_Close.TabIndex = 178;
            this.btn_Close.Text = "Выход";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_SaveBook
            // 
            this.btn_SaveBook.Location = new System.Drawing.Point(456, 420);
            this.btn_SaveBook.Name = "btn_SaveBook";
            this.btn_SaveBook.Size = new System.Drawing.Size(75, 23);
            this.btn_SaveBook.TabIndex = 177;
            this.btn_SaveBook.Text = "Сохранить";
            this.btn_SaveBook.UseVisualStyleBackColor = true;
            this.btn_SaveBook.Click += new System.EventHandler(this.btn_SaveBook_Click);
            // 
            // lbl_Producer
            // 
            this.lbl_Producer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Producer.AutoSize = true;
            this.lbl_Producer.Location = new System.Drawing.Point(29, 93);
            this.lbl_Producer.Name = "lbl_Producer";
            this.lbl_Producer.Size = new System.Drawing.Size(59, 13);
            this.lbl_Producer.TabIndex = 166;
            this.lbl_Producer.Text = "Продюсер";
            // 
            // lbl_ID
            // 
            this.lbl_ID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Location = new System.Drawing.Point(70, 15);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(18, 13);
            this.lbl_ID.TabIndex = 163;
            this.lbl_ID.Text = "ID";
            // 
            // txtbox_Producer
            // 
            this.txtbox_Producer.Location = new System.Drawing.Point(94, 90);
            this.txtbox_Producer.Name = "txtbox_Producer";
            this.txtbox_Producer.Size = new System.Drawing.Size(198, 20);
            this.txtbox_Producer.TabIndex = 153;
            // 
            // txtbox_ID
            // 
            this.txtbox_ID.Location = new System.Drawing.Point(94, 12);
            this.txtbox_ID.Name = "txtbox_ID";
            this.txtbox_ID.ReadOnly = true;
            this.txtbox_ID.Size = new System.Drawing.Size(198, 20);
            this.txtbox_ID.TabIndex = 150;
            this.txtbox_ID.TabStop = false;
            // 
            // form_EditFilm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 476);
            this.Controls.Add(this.cmbbox_MPAA);
            this.Controls.Add(this.lbl_Premiere);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbl_Notes);
            this.Controls.Add(this.lbl_Grosses);
            this.Controls.Add(this.lbl_CriticsRating);
            this.Controls.Add(this.lbl_MPAARating);
            this.Controls.Add(this.lbl_Country);
            this.Controls.Add(this.lbl_Length);
            this.Controls.Add(this.lbl_Genre);
            this.Controls.Add(this.txtbox_Notes);
            this.Controls.Add(this.txtbox_Grosses);
            this.Controls.Add(this.txtbox_CriticsRating);
            this.Controls.Add(this.txtbox_Premiere);
            this.Controls.Add(this.txtbox_Country);
            this.Controls.Add(this.txtbox_Length);
            this.Controls.Add(this.txtbox_Genre);
            this.Controls.Add(this.flp_FileSelector);
            this.Controls.Add(this.btn_AddFiles);
            this.Controls.Add(this.lbl_Actors);
            this.Controls.Add(this.txtbox_Actors);
            this.Controls.Add(this.txtbox_Title);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_SaveBook);
            this.Controls.Add(this.lbl_Producer);
            this.Controls.Add(this.lbl_ID);
            this.Controls.Add(this.txtbox_Producer);
            this.Controls.Add(this.txtbox_ID);
            this.MaximumSize = new System.Drawing.Size(640, 515);
            this.MinimumSize = new System.Drawing.Size(640, 515);
            this.Name = "form_EditFilm";
            this.Text = "form_EditFilm";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog ofd_FileSelector;
        private System.Windows.Forms.ComboBox cmbbox_MPAA;
        private System.Windows.Forms.Label lbl_Premiere;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbl_Notes;
        private System.Windows.Forms.Label lbl_Grosses;
        private System.Windows.Forms.Label lbl_CriticsRating;
        private System.Windows.Forms.Label lbl_MPAARating;
        private System.Windows.Forms.Label lbl_Country;
        private System.Windows.Forms.Label lbl_Length;
        private System.Windows.Forms.Label lbl_Genre;
        public System.Windows.Forms.TextBox txtbox_Notes;
        public System.Windows.Forms.TextBox txtbox_Grosses;
        public System.Windows.Forms.TextBox txtbox_CriticsRating;
        public System.Windows.Forms.TextBox txtbox_Premiere;
        public System.Windows.Forms.TextBox txtbox_Country;
        public System.Windows.Forms.TextBox txtbox_Length;
        public System.Windows.Forms.TextBox txtbox_Genre;
        public System.Windows.Forms.FlowLayoutPanel flp_FileSelector;
        public System.Windows.Forms.Button btn_AddFiles;
        private System.Windows.Forms.Label lbl_Actors;
        public System.Windows.Forms.TextBox txtbox_Actors;
        public System.Windows.Forms.TextBox txtbox_Title;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tssl_StatusFilmEdit;
        public System.Windows.Forms.Button btn_Close;
        public System.Windows.Forms.Button btn_SaveBook;
        private System.Windows.Forms.Label lbl_Producer;
        private System.Windows.Forms.Label lbl_ID;
        public System.Windows.Forms.TextBox txtbox_Producer;
        public System.Windows.Forms.TextBox txtbox_ID;
    }
}