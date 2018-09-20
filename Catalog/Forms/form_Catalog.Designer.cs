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
            this.LoadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.SaveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.PrintToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.правкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RemoveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CloneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.ExpandAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CollapseAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.ViewXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сервисToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.параметрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeLanguageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.содержаниеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.индексToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.txtbox_Title = new System.Windows.Forms.TextBox();
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
            this.справкаToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LoadToolStripMenuItem,
            this.toolStripSeparator,
            this.SaveAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.PrintToolStripMenuItem,
            this.PreviewToolStripMenuItem,
            this.toolStripSeparator2,
            this.ExitToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            resources.ApplyResources(this.FileToolStripMenuItem, "FileToolStripMenuItem");
            // 
            // LoadToolStripMenuItem
            // 
            resources.ApplyResources(this.LoadToolStripMenuItem, "LoadToolStripMenuItem");
            this.LoadToolStripMenuItem.Name = "LoadToolStripMenuItem";
            this.LoadToolStripMenuItem.Click += new System.EventHandler(this.LoadToolStripMenuItem_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            resources.ApplyResources(this.toolStripSeparator, "toolStripSeparator");
            // 
            // SaveAsToolStripMenuItem
            // 
            resources.ApplyResources(this.SaveAsToolStripMenuItem, "SaveAsToolStripMenuItem");
            this.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem";
            this.SaveAsToolStripMenuItem.Click += new System.EventHandler(this.SaveAsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // PrintToolStripMenuItem
            // 
            resources.ApplyResources(this.PrintToolStripMenuItem, "PrintToolStripMenuItem");
            this.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem";
            this.PrintToolStripMenuItem.Click += new System.EventHandler(this.PrintToolStripMenuItem_Click);
            // 
            // PreviewToolStripMenuItem
            // 
            resources.ApplyResources(this.PreviewToolStripMenuItem, "PreviewToolStripMenuItem");
            this.PreviewToolStripMenuItem.Name = "PreviewToolStripMenuItem";
            this.PreviewToolStripMenuItem.Click += new System.EventHandler(this.PreviewToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            resources.ApplyResources(this.ExitToolStripMenuItem, "ExitToolStripMenuItem");
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // правкаToolStripMenuItem
            // 
            this.правкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateToolStripMenuItem,
            this.RemoveToolStripMenuItem,
            this.CloneToolStripMenuItem,
            this.EditToolStripMenuItem,
            this.toolStripSeparator3,
            this.ExpandAllToolStripMenuItem,
            this.CollapseAllToolStripMenuItem,
            this.toolStripSeparator4,
            this.ViewXMLToolStripMenuItem});
            this.правкаToolStripMenuItem.Name = "правкаToolStripMenuItem";
            resources.ApplyResources(this.правкаToolStripMenuItem, "правкаToolStripMenuItem");
            // 
            // CreateToolStripMenuItem
            // 
            resources.ApplyResources(this.CreateToolStripMenuItem, "CreateToolStripMenuItem");
            this.CreateToolStripMenuItem.Name = "CreateToolStripMenuItem";
            this.CreateToolStripMenuItem.Click += new System.EventHandler(this.CreateToolStripMenuItem_Click);
            // 
            // RemoveToolStripMenuItem
            // 
            resources.ApplyResources(this.RemoveToolStripMenuItem, "RemoveToolStripMenuItem");
            this.RemoveToolStripMenuItem.Name = "RemoveToolStripMenuItem";
            this.RemoveToolStripMenuItem.Click += new System.EventHandler(this.RemoveToolStripMenuItem_Click);
            // 
            // CloneToolStripMenuItem
            // 
            resources.ApplyResources(this.CloneToolStripMenuItem, "CloneToolStripMenuItem");
            this.CloneToolStripMenuItem.Name = "CloneToolStripMenuItem";
            this.CloneToolStripMenuItem.Click += new System.EventHandler(this.CloneToolStripMenuItem_Click);
            // 
            // EditToolStripMenuItem
            // 
            this.EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            resources.ApplyResources(this.EditToolStripMenuItem, "EditToolStripMenuItem");
            this.EditToolStripMenuItem.Click += new System.EventHandler(this.EditToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            resources.ApplyResources(this.toolStripSeparator3, "toolStripSeparator3");
            // 
            // ExpandAllToolStripMenuItem
            // 
            this.ExpandAllToolStripMenuItem.Name = "ExpandAllToolStripMenuItem";
            resources.ApplyResources(this.ExpandAllToolStripMenuItem, "ExpandAllToolStripMenuItem");
            this.ExpandAllToolStripMenuItem.Click += new System.EventHandler(this.ExpandAllToolStripMenuItem_Click);
            // 
            // CollapseAllToolStripMenuItem
            // 
            this.CollapseAllToolStripMenuItem.Name = "CollapseAllToolStripMenuItem";
            resources.ApplyResources(this.CollapseAllToolStripMenuItem, "CollapseAllToolStripMenuItem");
            this.CollapseAllToolStripMenuItem.Click += new System.EventHandler(this.CollapseAllToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            resources.ApplyResources(this.toolStripSeparator4, "toolStripSeparator4");
            // 
            // ViewXMLToolStripMenuItem
            // 
            this.ViewXMLToolStripMenuItem.Name = "ViewXMLToolStripMenuItem";
            resources.ApplyResources(this.ViewXMLToolStripMenuItem, "ViewXMLToolStripMenuItem");
            this.ViewXMLToolStripMenuItem.Click += new System.EventHandler(this.ViewXMLToolStripMenuItem_Click);
            // 
            // сервисToolStripMenuItem
            // 
            this.сервисToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.настройкиToolStripMenuItem,
            this.параметрыToolStripMenuItem,
            this.ChangeLanguageToolStripMenuItem});
            this.сервисToolStripMenuItem.Name = "сервисToolStripMenuItem";
            resources.ApplyResources(this.сервисToolStripMenuItem, "сервисToolStripMenuItem");
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            resources.ApplyResources(this.настройкиToolStripMenuItem, "настройкиToolStripMenuItem");
            // 
            // параметрыToolStripMenuItem
            // 
            this.параметрыToolStripMenuItem.Name = "параметрыToolStripMenuItem";
            resources.ApplyResources(this.параметрыToolStripMenuItem, "параметрыToolStripMenuItem");
            // 
            // ChangeLanguageToolStripMenuItem
            // 
            this.ChangeLanguageToolStripMenuItem.Name = "ChangeLanguageToolStripMenuItem";
            resources.ApplyResources(this.ChangeLanguageToolStripMenuItem, "ChangeLanguageToolStripMenuItem");
            this.ChangeLanguageToolStripMenuItem.Click += new System.EventHandler(this.ChangeLanguageToolStripMenuItem_Click);
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
            resources.ApplyResources(this.справкаToolStripMenuItem, "справкаToolStripMenuItem");
            // 
            // содержаниеToolStripMenuItem
            // 
            this.содержаниеToolStripMenuItem.Name = "содержаниеToolStripMenuItem";
            resources.ApplyResources(this.содержаниеToolStripMenuItem, "содержаниеToolStripMenuItem");
            // 
            // индексToolStripMenuItem
            // 
            this.индексToolStripMenuItem.Name = "индексToolStripMenuItem";
            resources.ApplyResources(this.индексToolStripMenuItem, "индексToolStripMenuItem");
            // 
            // поискToolStripMenuItem
            // 
            this.поискToolStripMenuItem.Name = "поискToolStripMenuItem";
            resources.ApplyResources(this.поискToolStripMenuItem, "поискToolStripMenuItem");
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            resources.ApplyResources(this.toolStripSeparator5, "toolStripSeparator5");
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            resources.ApplyResources(this.aboutToolStripMenuItem, "aboutToolStripMenuItem");
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // tc_Info
            // 
            resources.ApplyResources(this.tc_Info, "tc_Info");
            this.tc_Info.Controls.Add(this.tabPage_Book);
            this.tc_Info.Controls.Add(this.tabPage_Film);
            this.tc_Info.Name = "tc_Info";
            this.tc_Info.SelectedIndex = 0;
            // 
            // tabPage_Book
            // 
            this.tabPage_Book.Controls.Add(this.grpbox_BookInfo);
            this.tabPage_Book.Controls.Add(this.tw_Book);
            resources.ApplyResources(this.tabPage_Book, "tabPage_Book");
            this.tabPage_Book.Name = "tabPage_Book";
            this.tabPage_Book.UseVisualStyleBackColor = true;
            // 
            // grpbox_BookInfo
            // 
            resources.ApplyResources(this.grpbox_BookInfo, "grpbox_BookInfo");
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
            this.grpbox_BookInfo.Controls.Add(this.txtbox_Title);
            this.grpbox_BookInfo.Controls.Add(this.txtbox_Author);
            this.grpbox_BookInfo.Controls.Add(this.txtbox_MajorSeries);
            this.grpbox_BookInfo.Controls.Add(this.txtbox_ID);
            this.grpbox_BookInfo.Name = "grpbox_BookInfo";
            this.grpbox_BookInfo.TabStop = false;
            // 
            // msktxtbox_ISBN
            // 
            resources.ApplyResources(this.msktxtbox_ISBN, "msktxtbox_ISBN");
            this.msktxtbox_ISBN.Name = "msktxtbox_ISBN";
            this.msktxtbox_ISBN.ReadOnly = true;
            // 
            // lbl_Notes
            // 
            resources.ApplyResources(this.lbl_Notes, "lbl_Notes");
            this.lbl_Notes.Name = "lbl_Notes";
            // 
            // lbl_Artist
            // 
            resources.ApplyResources(this.lbl_Artist, "lbl_Artist");
            this.lbl_Artist.Name = "lbl_Artist";
            // 
            // lbl_Translator
            // 
            resources.ApplyResources(this.lbl_Translator, "lbl_Translator");
            this.lbl_Translator.Name = "lbl_Translator";
            // 
            // lbl_ISBN
            // 
            resources.ApplyResources(this.lbl_ISBN, "lbl_ISBN");
            this.lbl_ISBN.Name = "lbl_ISBN";
            // 
            // lbl_PrintCity
            // 
            resources.ApplyResources(this.lbl_PrintCity, "lbl_PrintCity");
            this.lbl_PrintCity.Name = "lbl_PrintCity";
            // 
            // lbl_PrintYear
            // 
            resources.ApplyResources(this.lbl_PrintYear, "lbl_PrintYear");
            this.lbl_PrintYear.Name = "lbl_PrintYear";
            // 
            // lbl_Publisher
            // 
            resources.ApplyResources(this.lbl_Publisher, "lbl_Publisher");
            this.lbl_Publisher.Name = "lbl_Publisher";
            // 
            // lbl_PagesCount
            // 
            resources.ApplyResources(this.lbl_PagesCount, "lbl_PagesCount");
            this.lbl_PagesCount.Name = "lbl_PagesCount";
            // 
            // lbl_Genre
            // 
            resources.ApplyResources(this.lbl_Genre, "lbl_Genre");
            this.lbl_Genre.Name = "lbl_Genre";
            // 
            // lbl_NumberInSeries
            // 
            resources.ApplyResources(this.lbl_NumberInSeries, "lbl_NumberInSeries");
            this.lbl_NumberInSeries.Name = "lbl_NumberInSeries";
            // 
            // txtbox_Notes
            // 
            resources.ApplyResources(this.txtbox_Notes, "txtbox_Notes");
            this.txtbox_Notes.Name = "txtbox_Notes";
            this.txtbox_Notes.ReadOnly = true;
            // 
            // txtbox_Artist
            // 
            resources.ApplyResources(this.txtbox_Artist, "txtbox_Artist");
            this.txtbox_Artist.Name = "txtbox_Artist";
            this.txtbox_Artist.ReadOnly = true;
            // 
            // txtbox_Translator
            // 
            resources.ApplyResources(this.txtbox_Translator, "txtbox_Translator");
            this.txtbox_Translator.Name = "txtbox_Translator";
            this.txtbox_Translator.ReadOnly = true;
            // 
            // txtbox_PrintCity
            // 
            resources.ApplyResources(this.txtbox_PrintCity, "txtbox_PrintCity");
            this.txtbox_PrintCity.Name = "txtbox_PrintCity";
            this.txtbox_PrintCity.ReadOnly = true;
            // 
            // txtbox_PrintYear
            // 
            resources.ApplyResources(this.txtbox_PrintYear, "txtbox_PrintYear");
            this.txtbox_PrintYear.Name = "txtbox_PrintYear";
            this.txtbox_PrintYear.ReadOnly = true;
            // 
            // txtbox_Publisher
            // 
            resources.ApplyResources(this.txtbox_Publisher, "txtbox_Publisher");
            this.txtbox_Publisher.Name = "txtbox_Publisher";
            this.txtbox_Publisher.ReadOnly = true;
            // 
            // txtbox_PagesCount
            // 
            resources.ApplyResources(this.txtbox_PagesCount, "txtbox_PagesCount");
            this.txtbox_PagesCount.Name = "txtbox_PagesCount";
            this.txtbox_PagesCount.ReadOnly = true;
            // 
            // txtbox_Genre
            // 
            resources.ApplyResources(this.txtbox_Genre, "txtbox_Genre");
            this.txtbox_Genre.Name = "txtbox_Genre";
            this.txtbox_Genre.ReadOnly = true;
            // 
            // txtbox_NumberInSeries
            // 
            resources.ApplyResources(this.txtbox_NumberInSeries, "txtbox_NumberInSeries");
            this.txtbox_NumberInSeries.Name = "txtbox_NumberInSeries";
            this.txtbox_NumberInSeries.ReadOnly = true;
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // picBox_BookPreview
            // 
            resources.ApplyResources(this.picBox_BookPreview, "picBox_BookPreview");
            this.picBox_BookPreview.Name = "picBox_BookPreview";
            this.picBox_BookPreview.TabStop = false;
            // 
            // lbl_Series
            // 
            resources.ApplyResources(this.lbl_Series, "lbl_Series");
            this.lbl_Series.Name = "lbl_Series";
            // 
            // txtbox_Series
            // 
            resources.ApplyResources(this.txtbox_Series, "txtbox_Series");
            this.txtbox_Series.Name = "txtbox_Series";
            this.txtbox_Series.ReadOnly = true;
            // 
            // lbl_Name
            // 
            resources.ApplyResources(this.lbl_Name, "lbl_Name");
            this.lbl_Name.Name = "lbl_Name";
            // 
            // lbl_Author
            // 
            resources.ApplyResources(this.lbl_Author, "lbl_Author");
            this.lbl_Author.Name = "lbl_Author";
            // 
            // lbl_MajorSeries
            // 
            resources.ApplyResources(this.lbl_MajorSeries, "lbl_MajorSeries");
            this.lbl_MajorSeries.Name = "lbl_MajorSeries";
            // 
            // lbl_ID
            // 
            resources.ApplyResources(this.lbl_ID, "lbl_ID");
            this.lbl_ID.Name = "lbl_ID";
            // 
            // txtbox_Title
            // 
            resources.ApplyResources(this.txtbox_Title, "txtbox_Title");
            this.txtbox_Title.Name = "txtbox_Title";
            this.txtbox_Title.ReadOnly = true;
            // 
            // txtbox_Author
            // 
            resources.ApplyResources(this.txtbox_Author, "txtbox_Author");
            this.txtbox_Author.Name = "txtbox_Author";
            this.txtbox_Author.ReadOnly = true;
            // 
            // txtbox_MajorSeries
            // 
            resources.ApplyResources(this.txtbox_MajorSeries, "txtbox_MajorSeries");
            this.txtbox_MajorSeries.Name = "txtbox_MajorSeries";
            this.txtbox_MajorSeries.ReadOnly = true;
            // 
            // txtbox_ID
            // 
            resources.ApplyResources(this.txtbox_ID, "txtbox_ID");
            this.txtbox_ID.Name = "txtbox_ID";
            this.txtbox_ID.ReadOnly = true;
            // 
            // tw_Book
            // 
            resources.ApplyResources(this.tw_Book, "tw_Book");
            this.tw_Book.Name = "tw_Book";
            this.tw_Book.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tw_Book_AfterSelect);
            // 
            // tabPage_Film
            // 
            this.tabPage_Film.Controls.Add(this.FilmInfo);
            this.tabPage_Film.Controls.Add(this.tw_Film);
            resources.ApplyResources(this.tabPage_Film, "tabPage_Film");
            this.tabPage_Film.Name = "tabPage_Film";
            this.tabPage_Film.UseVisualStyleBackColor = true;
            // 
            // FilmInfo
            // 
            resources.ApplyResources(this.FilmInfo, "FilmInfo");
            this.FilmInfo.Name = "FilmInfo";
            this.FilmInfo.TabStop = false;
            // 
            // tw_Film
            // 
            resources.ApplyResources(this.tw_Film, "tw_Film");
            this.tw_Film.Name = "tw_Film";
            // 
            // imgLst_BookPreview
            // 
            this.imgLst_BookPreview.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            resources.ApplyResources(this.imgLst_BookPreview, "imgLst_BookPreview");
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
            resources.ApplyResources(this.print_PreviewDialog, "print_PreviewDialog");
            this.print_PreviewDialog.Name = "print_PreviewDialog";
            // 
            // form_Catalog
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tc_Info);
            this.Controls.Add(this.menuStrip1);
            this.Name = "form_Catalog";
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
        private System.Windows.Forms.ToolStripMenuItem LoadToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem SaveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem PrintToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PreviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem правкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem RemoveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CloneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExpandAllToolStripMenuItem;
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
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_Author;
        private System.Windows.Forms.Label lbl_MajorSeries;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.TextBox txtbox_Title;
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
        private System.Windows.Forms.ToolStripMenuItem CreateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CollapseAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem ViewXMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ChangeLanguageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditToolStripMenuItem;
    }
}

