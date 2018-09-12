namespace Catalog
{
    partial class form_Catalog
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_Catalog));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LoadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.SaveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.PrintToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.правкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CancelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отменадействияToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.RemoveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CopyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.выделитьвсеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сервисToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.параметрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.содержаниеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.индексToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.debugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tc_Info = new System.Windows.Forms.TabControl();
            this.tabPage_Book = new System.Windows.Forms.TabPage();
            this.grpbox_BookInfo = new System.Windows.Forms.GroupBox();
            this.msktxtbox_ISBN = new System.Windows.Forms.MaskedTextBox();
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
            this.txtbox_PrintCity = new System.Windows.Forms.TextBox();
            this.txtbox_PrintYear = new System.Windows.Forms.TextBox();
            this.txtbox_Publisher = new System.Windows.Forms.TextBox();
            this.txtbox_PagesCount = new System.Windows.Forms.TextBox();
            this.txtbox_Genre = new System.Windows.Forms.TextBox();
            this.txtbox_NumberInSeries = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.picBox_BookPreview = new System.Windows.Forms.PictureBox();
            this.lbl_Series = new System.Windows.Forms.Label();
            this.txtbox_Series = new System.Windows.Forms.TextBox();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_Author = new System.Windows.Forms.Label();
            this.lbl_MajorSeries = new System.Windows.Forms.Label();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.txtbox_Name = new System.Windows.Forms.TextBox();
            this.txtbox_Author = new System.Windows.Forms.TextBox();
            this.txtbox_MajorSeries = new System.Windows.Forms.TextBox();
            this.txtbox_ID = new System.Windows.Forms.TextBox();
            this.tw_Book = new System.Windows.Forms.TreeView();
            this.tabPage_Film = new System.Windows.Forms.TabPage();
            this.FilmInfo = new System.Windows.Forms.GroupBox();
            this.tw_Film = new System.Windows.Forms.TreeView();
            this.imgLst_BookPreview = new System.Windows.Forms.ImageList(this.components);
            this.timer_BookPreview = new System.Windows.Forms.Timer(this.components);
            this.ofd_LoadXmlFile = new System.Windows.Forms.OpenFileDialog();
            this.sfd_SaveXmlFile = new System.Windows.Forms.SaveFileDialog();
            this.print_Doc = new System.Drawing.Printing.PrintDocument();
            this.print_Dialog = new System.Windows.Forms.PrintDialog();
            this.print_PreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.menuStrip1.SuspendLayout();
            this.tc_Info.SuspendLayout();
            this.tabPage_Book.SuspendLayout();
            this.grpbox_BookInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_BookPreview)).BeginInit();
            this.tabPage_Film.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.правкаToolStripMenuItem,
            this.сервисToolStripMenuItem,
            this.справкаToolStripMenuItem,
            this.debugToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(865, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateToolStripMenuItem,
            this.LoadToolStripMenuItem,
            this.toolStripSeparator,
            this.SaveAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.PrintToolStripMenuItem,
            this.PreviewToolStripMenuItem,
            this.toolStripSeparator2,
            this.ExitToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.FileToolStripMenuItem.Text = "&Файл";
            // 
            // CreateToolStripMenuItem
            // 
            this.CreateToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("CreateToolStripMenuItem.Image")));
            this.CreateToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CreateToolStripMenuItem.Name = "CreateToolStripMenuItem";
            this.CreateToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.CreateToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.CreateToolStripMenuItem.Text = "&Создать";
            this.CreateToolStripMenuItem.Click += new System.EventHandler(this.CreateToolStripMenuItem_Click);
            // 
            // LoadToolStripMenuItem
            // 
            this.LoadToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("LoadToolStripMenuItem.Image")));
            this.LoadToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.LoadToolStripMenuItem.Name = "LoadToolStripMenuItem";
            this.LoadToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.LoadToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.LoadToolStripMenuItem.Text = "&Открыть";
            this.LoadToolStripMenuItem.Click += new System.EventHandler(this.LoadToolStripMenuItem_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(230, 6);
            // 
            // SaveAsToolStripMenuItem
            // 
            this.SaveAsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("SaveAsToolStripMenuItem.Image")));
            this.SaveAsToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem";
            this.SaveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.SaveAsToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.SaveAsToolStripMenuItem.Text = "&Сохранить как";
            this.SaveAsToolStripMenuItem.Click += new System.EventHandler(this.SaveAsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(230, 6);
            // 
            // PrintToolStripMenuItem
            // 
            this.PrintToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("PrintToolStripMenuItem.Image")));
            this.PrintToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem";
            this.PrintToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.PrintToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.PrintToolStripMenuItem.Text = "&Печать";
            this.PrintToolStripMenuItem.Click += new System.EventHandler(this.PrintToolStripMenuItem_Click);
            // 
            // PreviewToolStripMenuItem
            // 
            this.PreviewToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("PreviewToolStripMenuItem.Image")));
            this.PreviewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PreviewToolStripMenuItem.Name = "PreviewToolStripMenuItem";
            this.PreviewToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.PreviewToolStripMenuItem.Text = "Предварительный про&смотр";
            this.PreviewToolStripMenuItem.Click += new System.EventHandler(this.PreviewToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(230, 6);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.ExitToolStripMenuItem.Text = "Вы&ход";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // правкаToolStripMenuItem
            // 
            this.правкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CancelToolStripMenuItem,
            this.отменадействияToolStripMenuItem1,
            this.toolStripSeparator3,
            this.RemoveToolStripMenuItem,
            this.CopyToolStripMenuItem,
            this.PasteToolStripMenuItem,
            this.toolStripSeparator4,
            this.выделитьвсеToolStripMenuItem});
            this.правкаToolStripMenuItem.Name = "правкаToolStripMenuItem";
            this.правкаToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.правкаToolStripMenuItem.Text = "&Правка";
            // 
            // CancelToolStripMenuItem
            // 
            this.CancelToolStripMenuItem.Name = "CancelToolStripMenuItem";
            this.CancelToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.CancelToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.CancelToolStripMenuItem.Text = "&Отмена действия";
            // 
            // отменадействияToolStripMenuItem1
            // 
            this.отменадействияToolStripMenuItem1.Name = "отменадействияToolStripMenuItem1";
            this.отменадействияToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.отменадействияToolStripMenuItem1.Size = new System.Drawing.Size(209, 22);
            this.отменадействияToolStripMenuItem1.Text = "&Отмена действия";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(206, 6);
            // 
            // RemoveToolStripMenuItem
            // 
            this.RemoveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("RemoveToolStripMenuItem.Image")));
            this.RemoveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RemoveToolStripMenuItem.Name = "RemoveToolStripMenuItem";
            this.RemoveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.RemoveToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.RemoveToolStripMenuItem.Text = "Удалить";
            this.RemoveToolStripMenuItem.Click += new System.EventHandler(this.RemoveToolStripMenuItem_Click);
            // 
            // CopyToolStripMenuItem
            // 
            this.CopyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("CopyToolStripMenuItem.Image")));
            this.CopyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem";
            this.CopyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.CopyToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.CopyToolStripMenuItem.Text = "&Копировать";
            // 
            // PasteToolStripMenuItem
            // 
            this.PasteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("PasteToolStripMenuItem.Image")));
            this.PasteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem";
            this.PasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.PasteToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.PasteToolStripMenuItem.Text = "Вст&авка";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(206, 6);
            // 
            // выделитьвсеToolStripMenuItem
            // 
            this.выделитьвсеToolStripMenuItem.Name = "выделитьвсеToolStripMenuItem";
            this.выделитьвсеToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.выделитьвсеToolStripMenuItem.Text = "Выделить &все";
            // 
            // сервисToolStripMenuItem
            // 
            this.сервисToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.настройкиToolStripMenuItem,
            this.параметрыToolStripMenuItem});
            this.сервисToolStripMenuItem.Name = "сервисToolStripMenuItem";
            this.сервисToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.сервисToolStripMenuItem.Text = "&Сервис";
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.настройкиToolStripMenuItem.Text = "&Настройки";
            // 
            // параметрыToolStripMenuItem
            // 
            this.параметрыToolStripMenuItem.Name = "параметрыToolStripMenuItem";
            this.параметрыToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.параметрыToolStripMenuItem.Text = "&Параметры";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.содержаниеToolStripMenuItem,
            this.индексToolStripMenuItem,
            this.поискToolStripMenuItem,
            this.toolStripSeparator5,
            this.aboutToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Спра&вка";
            // 
            // содержаниеToolStripMenuItem
            // 
            this.содержаниеToolStripMenuItem.Name = "содержаниеToolStripMenuItem";
            this.содержаниеToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.содержаниеToolStripMenuItem.Text = "&Содержание";
            // 
            // индексToolStripMenuItem
            // 
            this.индексToolStripMenuItem.Name = "индексToolStripMenuItem";
            this.индексToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.индексToolStripMenuItem.Text = "&Индекс";
            // 
            // поискToolStripMenuItem
            // 
            this.поискToolStripMenuItem.Name = "поискToolStripMenuItem";
            this.поискToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.поискToolStripMenuItem.Text = "&Поиск";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(155, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.aboutToolStripMenuItem.Text = "&О программе...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // debugToolStripMenuItem
            // 
            this.debugToolStripMenuItem.Name = "debugToolStripMenuItem";
            this.debugToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.debugToolStripMenuItem.Text = "Debug";
            this.debugToolStripMenuItem.Click += new System.EventHandler(this.debugToolStripMenuItem_Click);
            // 
            // tc_Info
            // 
            this.tc_Info.Controls.Add(this.tabPage_Book);
            this.tc_Info.Controls.Add(this.tabPage_Film);
            this.tc_Info.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tc_Info.Location = new System.Drawing.Point(0, 24);
            this.tc_Info.Name = "tc_Info";
            this.tc_Info.SelectedIndex = 0;
            this.tc_Info.Size = new System.Drawing.Size(865, 467);
            this.tc_Info.TabIndex = 1;
            // 
            // tabPage_Book
            // 
            this.tabPage_Book.Controls.Add(this.grpbox_BookInfo);
            this.tabPage_Book.Controls.Add(this.tw_Book);
            this.tabPage_Book.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Book.Name = "tabPage_Book";
            this.tabPage_Book.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Book.Size = new System.Drawing.Size(857, 441);
            this.tabPage_Book.TabIndex = 0;
            this.tabPage_Book.Text = "Книги";
            this.tabPage_Book.UseVisualStyleBackColor = true;
            // 
            // grpbox_BookInfo
            // 
            this.grpbox_BookInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpbox_BookInfo.Controls.Add(this.msktxtbox_ISBN);
            this.grpbox_BookInfo.Controls.Add(this.lbl_Notes);
            this.grpbox_BookInfo.Controls.Add(this.lbl_Artist);
            this.grpbox_BookInfo.Controls.Add(this.lbl_Translator);
            this.grpbox_BookInfo.Controls.Add(this.lbl_ISBN);
            this.grpbox_BookInfo.Controls.Add(this.lbl_PrintCity);
            this.grpbox_BookInfo.Controls.Add(this.lbl_PrintYear);
            this.grpbox_BookInfo.Controls.Add(this.lbl_Publisher);
            this.grpbox_BookInfo.Controls.Add(this.lbl_PagesCount);
            this.grpbox_BookInfo.Controls.Add(this.lbl_Genre);
            this.grpbox_BookInfo.Controls.Add(this.lbl_NumberInSeries);
            this.grpbox_BookInfo.Controls.Add(this.txtbox_Notes);
            this.grpbox_BookInfo.Controls.Add(this.txtbox_Artist);
            this.grpbox_BookInfo.Controls.Add(this.txtbox_Translator);
            this.grpbox_BookInfo.Controls.Add(this.txtbox_PrintCity);
            this.grpbox_BookInfo.Controls.Add(this.txtbox_PrintYear);
            this.grpbox_BookInfo.Controls.Add(this.txtbox_Publisher);
            this.grpbox_BookInfo.Controls.Add(this.txtbox_PagesCount);
            this.grpbox_BookInfo.Controls.Add(this.txtbox_Genre);
            this.grpbox_BookInfo.Controls.Add(this.txtbox_NumberInSeries);
            this.grpbox_BookInfo.Controls.Add(this.label3);
            this.grpbox_BookInfo.Controls.Add(this.label2);
            this.grpbox_BookInfo.Controls.Add(this.label1);
            this.grpbox_BookInfo.Controls.Add(this.picBox_BookPreview);
            this.grpbox_BookInfo.Controls.Add(this.lbl_Series);
            this.grpbox_BookInfo.Controls.Add(this.txtbox_Series);
            this.grpbox_BookInfo.Controls.Add(this.lbl_Name);
            this.grpbox_BookInfo.Controls.Add(this.lbl_Author);
            this.grpbox_BookInfo.Controls.Add(this.lbl_MajorSeries);
            this.grpbox_BookInfo.Controls.Add(this.lbl_ID);
            this.grpbox_BookInfo.Controls.Add(this.txtbox_Name);
            this.grpbox_BookInfo.Controls.Add(this.txtbox_Author);
            this.grpbox_BookInfo.Controls.Add(this.txtbox_MajorSeries);
            this.grpbox_BookInfo.Controls.Add(this.txtbox_ID);
            this.grpbox_BookInfo.Location = new System.Drawing.Point(210, 1);
            this.grpbox_BookInfo.Name = "grpbox_BookInfo";
            this.grpbox_BookInfo.Size = new System.Drawing.Size(644, 441);
            this.grpbox_BookInfo.TabIndex = 1;
            this.grpbox_BookInfo.TabStop = false;
            this.grpbox_BookInfo.Text = "Информация о книге";
            // 
            // msktxtbox_ISBN
            // 
            this.msktxtbox_ISBN.Location = new System.Drawing.Point(268, 321);
            this.msktxtbox_ISBN.Name = "msktxtbox_ISBN";
            this.msktxtbox_ISBN.PromptChar = 'x';
            this.msktxtbox_ISBN.ReadOnly = true;
            this.msktxtbox_ISBN.Size = new System.Drawing.Size(100, 20);
            this.msktxtbox_ISBN.TabIndex = 115;
            // 
            // lbl_Notes
            // 
            this.lbl_Notes.AutoSize = true;
            this.lbl_Notes.Location = new System.Drawing.Point(374, 27);
            this.lbl_Notes.Name = "lbl_Notes";
            this.lbl_Notes.Size = new System.Drawing.Size(35, 13);
            this.lbl_Notes.TabIndex = 114;
            this.lbl_Notes.Text = "Notes";
            // 
            // lbl_Artist
            // 
            this.lbl_Artist.AutoSize = true;
            this.lbl_Artist.Location = new System.Drawing.Point(227, 381);
            this.lbl_Artist.Name = "lbl_Artist";
            this.lbl_Artist.Size = new System.Drawing.Size(30, 13);
            this.lbl_Artist.TabIndex = 113;
            this.lbl_Artist.Text = "Artist";
            // 
            // lbl_Translator
            // 
            this.lbl_Translator.AutoSize = true;
            this.lbl_Translator.Location = new System.Drawing.Point(208, 351);
            this.lbl_Translator.Name = "lbl_Translator";
            this.lbl_Translator.Size = new System.Drawing.Size(54, 13);
            this.lbl_Translator.TabIndex = 112;
            this.lbl_Translator.Text = "Translator";
            // 
            // lbl_ISBN
            // 
            this.lbl_ISBN.AutoSize = true;
            this.lbl_ISBN.Location = new System.Drawing.Point(230, 324);
            this.lbl_ISBN.Name = "lbl_ISBN";
            this.lbl_ISBN.Size = new System.Drawing.Size(32, 13);
            this.lbl_ISBN.TabIndex = 111;
            this.lbl_ISBN.Text = "ISBN";
            // 
            // lbl_PrintCity
            // 
            this.lbl_PrintCity.AutoSize = true;
            this.lbl_PrintCity.Location = new System.Drawing.Point(217, 297);
            this.lbl_PrintCity.Name = "lbl_PrintCity";
            this.lbl_PrintCity.Size = new System.Drawing.Size(45, 13);
            this.lbl_PrintCity.TabIndex = 110;
            this.lbl_PrintCity.Text = "PrintCity";
            // 
            // lbl_PrintYear
            // 
            this.lbl_PrintYear.AutoSize = true;
            this.lbl_PrintYear.Location = new System.Drawing.Point(212, 270);
            this.lbl_PrintYear.Name = "lbl_PrintYear";
            this.lbl_PrintYear.Size = new System.Drawing.Size(50, 13);
            this.lbl_PrintYear.TabIndex = 109;
            this.lbl_PrintYear.Text = "PrintYear";
            // 
            // lbl_Publisher
            // 
            this.lbl_Publisher.AutoSize = true;
            this.lbl_Publisher.Location = new System.Drawing.Point(212, 243);
            this.lbl_Publisher.Name = "lbl_Publisher";
            this.lbl_Publisher.Size = new System.Drawing.Size(50, 13);
            this.lbl_Publisher.TabIndex = 108;
            this.lbl_Publisher.Text = "Publisher";
            // 
            // lbl_PagesCount
            // 
            this.lbl_PagesCount.AutoSize = true;
            this.lbl_PagesCount.Location = new System.Drawing.Point(197, 216);
            this.lbl_PagesCount.Name = "lbl_PagesCount";
            this.lbl_PagesCount.Size = new System.Drawing.Size(65, 13);
            this.lbl_PagesCount.TabIndex = 107;
            this.lbl_PagesCount.Text = "PagesCount";
            // 
            // lbl_Genre
            // 
            this.lbl_Genre.AutoSize = true;
            this.lbl_Genre.Location = new System.Drawing.Point(226, 189);
            this.lbl_Genre.Name = "lbl_Genre";
            this.lbl_Genre.Size = new System.Drawing.Size(36, 13);
            this.lbl_Genre.TabIndex = 106;
            this.lbl_Genre.Text = "Genre";
            // 
            // lbl_NumberInSeries
            // 
            this.lbl_NumberInSeries.AutoSize = true;
            this.lbl_NumberInSeries.Location = new System.Drawing.Point(180, 162);
            this.lbl_NumberInSeries.Name = "lbl_NumberInSeries";
            this.lbl_NumberInSeries.Size = new System.Drawing.Size(82, 13);
            this.lbl_NumberInSeries.TabIndex = 105;
            this.lbl_NumberInSeries.Text = "NumberInSeries";
            // 
            // txtbox_Notes
            // 
            this.txtbox_Notes.Location = new System.Drawing.Point(415, 24);
            this.txtbox_Notes.Multiline = true;
            this.txtbox_Notes.Name = "txtbox_Notes";
            this.txtbox_Notes.ReadOnly = true;
            this.txtbox_Notes.Size = new System.Drawing.Size(223, 128);
            this.txtbox_Notes.TabIndex = 14;
            // 
            // txtbox_Artist
            // 
            this.txtbox_Artist.Location = new System.Drawing.Point(268, 375);
            this.txtbox_Artist.Name = "txtbox_Artist";
            this.txtbox_Artist.ReadOnly = true;
            this.txtbox_Artist.Size = new System.Drawing.Size(100, 20);
            this.txtbox_Artist.TabIndex = 13;
            // 
            // txtbox_Translator
            // 
            this.txtbox_Translator.Location = new System.Drawing.Point(268, 348);
            this.txtbox_Translator.Name = "txtbox_Translator";
            this.txtbox_Translator.ReadOnly = true;
            this.txtbox_Translator.Size = new System.Drawing.Size(100, 20);
            this.txtbox_Translator.TabIndex = 12;
            // 
            // txtbox_PrintCity
            // 
            this.txtbox_PrintCity.Location = new System.Drawing.Point(268, 294);
            this.txtbox_PrintCity.Name = "txtbox_PrintCity";
            this.txtbox_PrintCity.ReadOnly = true;
            this.txtbox_PrintCity.Size = new System.Drawing.Size(100, 20);
            this.txtbox_PrintCity.TabIndex = 10;
            // 
            // txtbox_PrintYear
            // 
            this.txtbox_PrintYear.Location = new System.Drawing.Point(268, 267);
            this.txtbox_PrintYear.Name = "txtbox_PrintYear";
            this.txtbox_PrintYear.ReadOnly = true;
            this.txtbox_PrintYear.Size = new System.Drawing.Size(100, 20);
            this.txtbox_PrintYear.TabIndex = 9;
            // 
            // txtbox_Publisher
            // 
            this.txtbox_Publisher.Location = new System.Drawing.Point(268, 240);
            this.txtbox_Publisher.Name = "txtbox_Publisher";
            this.txtbox_Publisher.ReadOnly = true;
            this.txtbox_Publisher.Size = new System.Drawing.Size(100, 20);
            this.txtbox_Publisher.TabIndex = 8;
            // 
            // txtbox_PagesCount
            // 
            this.txtbox_PagesCount.Location = new System.Drawing.Point(268, 213);
            this.txtbox_PagesCount.Name = "txtbox_PagesCount";
            this.txtbox_PagesCount.ReadOnly = true;
            this.txtbox_PagesCount.Size = new System.Drawing.Size(100, 20);
            this.txtbox_PagesCount.TabIndex = 7;
            // 
            // txtbox_Genre
            // 
            this.txtbox_Genre.Location = new System.Drawing.Point(268, 186);
            this.txtbox_Genre.Name = "txtbox_Genre";
            this.txtbox_Genre.ReadOnly = true;
            this.txtbox_Genre.Size = new System.Drawing.Size(100, 20);
            this.txtbox_Genre.TabIndex = 6;
            // 
            // txtbox_NumberInSeries
            // 
            this.txtbox_NumberInSeries.Location = new System.Drawing.Point(268, 159);
            this.txtbox_NumberInSeries.Name = "txtbox_NumberInSeries";
            this.txtbox_NumberInSeries.ReadOnly = true;
            this.txtbox_NumberInSeries.Size = new System.Drawing.Size(100, 20);
            this.txtbox_NumberInSeries.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "label1";
            // 
            // picBox_BookPreview
            // 
            this.picBox_BookPreview.Location = new System.Drawing.Point(6, 22);
            this.picBox_BookPreview.Name = "picBox_BookPreview";
            this.picBox_BookPreview.Size = new System.Drawing.Size(150, 200);
            this.picBox_BookPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox_BookPreview.TabIndex = 15;
            this.picBox_BookPreview.TabStop = false;
            // 
            // lbl_Series
            // 
            this.lbl_Series.AutoSize = true;
            this.lbl_Series.Location = new System.Drawing.Point(226, 135);
            this.lbl_Series.Name = "lbl_Series";
            this.lbl_Series.Size = new System.Drawing.Size(36, 13);
            this.lbl_Series.TabIndex = 104;
            this.lbl_Series.Text = "Series";
            // 
            // txtbox_Series
            // 
            this.txtbox_Series.Location = new System.Drawing.Point(268, 132);
            this.txtbox_Series.Name = "txtbox_Series";
            this.txtbox_Series.ReadOnly = true;
            this.txtbox_Series.Size = new System.Drawing.Size(100, 20);
            this.txtbox_Series.TabIndex = 4;
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Location = new System.Drawing.Point(227, 108);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(35, 13);
            this.lbl_Name.TabIndex = 103;
            this.lbl_Name.Text = "Name";
            // 
            // lbl_Author
            // 
            this.lbl_Author.AutoSize = true;
            this.lbl_Author.Location = new System.Drawing.Point(224, 81);
            this.lbl_Author.Name = "lbl_Author";
            this.lbl_Author.Size = new System.Drawing.Size(38, 13);
            this.lbl_Author.TabIndex = 102;
            this.lbl_Author.Text = "Author";
            // 
            // lbl_MajorSeries
            // 
            this.lbl_MajorSeries.AutoSize = true;
            this.lbl_MajorSeries.Location = new System.Drawing.Point(200, 54);
            this.lbl_MajorSeries.Name = "lbl_MajorSeries";
            this.lbl_MajorSeries.Size = new System.Drawing.Size(62, 13);
            this.lbl_MajorSeries.TabIndex = 101;
            this.lbl_MajorSeries.Text = "MajorSeries";
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Location = new System.Drawing.Point(244, 27);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(18, 13);
            this.lbl_ID.TabIndex = 100;
            this.lbl_ID.Text = "ID";
            // 
            // txtbox_Name
            // 
            this.txtbox_Name.Location = new System.Drawing.Point(268, 105);
            this.txtbox_Name.Name = "txtbox_Name";
            this.txtbox_Name.ReadOnly = true;
            this.txtbox_Name.Size = new System.Drawing.Size(100, 20);
            this.txtbox_Name.TabIndex = 3;
            // 
            // txtbox_Author
            // 
            this.txtbox_Author.Location = new System.Drawing.Point(268, 78);
            this.txtbox_Author.Name = "txtbox_Author";
            this.txtbox_Author.ReadOnly = true;
            this.txtbox_Author.Size = new System.Drawing.Size(100, 20);
            this.txtbox_Author.TabIndex = 2;
            // 
            // txtbox_MajorSeries
            // 
            this.txtbox_MajorSeries.Location = new System.Drawing.Point(268, 51);
            this.txtbox_MajorSeries.Name = "txtbox_MajorSeries";
            this.txtbox_MajorSeries.ReadOnly = true;
            this.txtbox_MajorSeries.Size = new System.Drawing.Size(100, 20);
            this.txtbox_MajorSeries.TabIndex = 1;
            // 
            // txtbox_ID
            // 
            this.txtbox_ID.Location = new System.Drawing.Point(268, 24);
            this.txtbox_ID.Name = "txtbox_ID";
            this.txtbox_ID.ReadOnly = true;
            this.txtbox_ID.Size = new System.Drawing.Size(100, 20);
            this.txtbox_ID.TabIndex = 0;
            // 
            // tw_Book
            // 
            this.tw_Book.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tw_Book.Location = new System.Drawing.Point(4, 7);
            this.tw_Book.Name = "tw_Book";
            this.tw_Book.Size = new System.Drawing.Size(200, 434);
            this.tw_Book.TabIndex = 0;
            this.tw_Book.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tw_Book_AfterSelect);
            // 
            // tabPage_Film
            // 
            this.tabPage_Film.Controls.Add(this.FilmInfo);
            this.tabPage_Film.Controls.Add(this.tw_Film);
            this.tabPage_Film.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Film.Name = "tabPage_Film";
            this.tabPage_Film.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Film.Size = new System.Drawing.Size(857, 441);
            this.tabPage_Film.TabIndex = 1;
            this.tabPage_Film.Text = "Фильмы";
            this.tabPage_Film.UseVisualStyleBackColor = true;
            // 
            // FilmInfo
            // 
            this.FilmInfo.Location = new System.Drawing.Point(211, 6);
            this.FilmInfo.Name = "FilmInfo";
            this.FilmInfo.Size = new System.Drawing.Size(378, 360);
            this.FilmInfo.TabIndex = 3;
            this.FilmInfo.TabStop = false;
            this.FilmInfo.Text = "Информация о фильме";
            // 
            // tw_Film
            // 
            this.tw_Film.Location = new System.Drawing.Point(5, 6);
            this.tw_Film.Name = "tw_Film";
            this.tw_Film.Size = new System.Drawing.Size(200, 360);
            this.tw_Film.TabIndex = 2;
            // 
            // imgLst_BookPreview
            // 
            this.imgLst_BookPreview.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imgLst_BookPreview.ImageSize = new System.Drawing.Size(16, 16);
            this.imgLst_BookPreview.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // timer_BookPreview
            // 
            this.timer_BookPreview.Enabled = true;
            this.timer_BookPreview.Interval = 2000;
            this.timer_BookPreview.Tick += new System.EventHandler(this.timer_BookPreview_Tick);
            // 
            // print_Doc
            // 
            this.print_Doc.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.print_Doc_PrintPage);
            // 
            // print_Dialog
            // 
            this.print_Dialog.UseEXDialog = true;
            // 
            // print_PreviewDialog
            // 
            this.print_PreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.print_PreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.print_PreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.print_PreviewDialog.Enabled = true;
            this.print_PreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("print_PreviewDialog.Icon")));
            this.print_PreviewDialog.Name = "print_PreviewDialog";
            this.print_PreviewDialog.Visible = false;
            // 
            // form_Catalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 491);
            this.Controls.Add(this.tc_Info);
            this.Controls.Add(this.menuStrip1);
            this.Name = "form_Catalog";
            this.Text = "Каталогизатор";
            this.Load += new System.EventHandler(this.Catalog_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tc_Info.ResumeLayout(false);
            this.tabPage_Book.ResumeLayout(false);
            this.grpbox_BookInfo.ResumeLayout(false);
            this.grpbox_BookInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_BookPreview)).EndInit();
            this.tabPage_Film.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CreateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LoadToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem SaveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem PrintToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PreviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem правкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CancelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отменадействияToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem RemoveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CopyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem выделитьвсеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сервисToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem параметрыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem содержаниеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem индексToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поискToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TabControl tc_Info;
        private System.Windows.Forms.TabPage tabPage_Book;
        private System.Windows.Forms.GroupBox grpbox_BookInfo;
        private System.Windows.Forms.TabPage tabPage_Film;
        private System.Windows.Forms.GroupBox FilmInfo;
        private System.Windows.Forms.TreeView tw_Film;
        private System.Windows.Forms.ToolStripMenuItem debugToolStripMenuItem;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_Author;
        private System.Windows.Forms.Label lbl_MajorSeries;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.TextBox txtbox_Name;
        private System.Windows.Forms.TextBox txtbox_Author;
        private System.Windows.Forms.TextBox txtbox_MajorSeries;
        private System.Windows.Forms.TextBox txtbox_ID;
        private System.Windows.Forms.TextBox txtbox_Series;
        private System.Windows.Forms.Label lbl_Series;
        private System.Windows.Forms.ImageList imgLst_BookPreview;
        private System.Windows.Forms.Timer timer_BookPreview;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.TextBox txtbox_Notes;
        private System.Windows.Forms.TextBox txtbox_Artist;
        private System.Windows.Forms.TextBox txtbox_Translator;
        private System.Windows.Forms.TextBox txtbox_PrintCity;
        private System.Windows.Forms.TextBox txtbox_PrintYear;
        private System.Windows.Forms.TextBox txtbox_Publisher;
        private System.Windows.Forms.TextBox txtbox_PagesCount;
        private System.Windows.Forms.TextBox txtbox_Genre;
        private System.Windows.Forms.TextBox txtbox_NumberInSeries;
        private System.Windows.Forms.MaskedTextBox msktxtbox_ISBN;
        private System.Windows.Forms.OpenFileDialog ofd_LoadXmlFile;
        private System.Windows.Forms.TreeView tw_Book;
        private System.Windows.Forms.PictureBox picBox_BookPreview;
        private System.Windows.Forms.SaveFileDialog sfd_SaveXmlFile;
        private System.Drawing.Printing.PrintDocument print_Doc;
        private System.Windows.Forms.PrintDialog print_Dialog;
        private System.Windows.Forms.PrintPreviewDialog print_PreviewDialog;
    }
}

