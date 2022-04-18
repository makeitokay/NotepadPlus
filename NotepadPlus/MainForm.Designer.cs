namespace NotepadPlus
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newFileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newFileInNewWindowMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileAsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeFileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAllFilesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitProgramMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutTextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyTextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteTextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAllMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wordWrapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.segoeUIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timesNewRomanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.georgiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.robotoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consolasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tahomaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontSizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileSaveIntervalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noAutoFileSaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sec1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sec3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sec5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sec10ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sec30ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.min1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.min3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.min5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.min15ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.min30ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.themeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lightThemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darkThemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.workaroundPanel = new System.Windows.Forms.Panel();
            this.filesTabControl = new System.Windows.Forms.TabControl();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.saveAllFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.workaroundPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuItem,
            this.editMenuItem,
            this.formatMenuItem,
            this.settingsMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip";
            // 
            // fileMenuItem
            // 
            this.fileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newFileMenuItem,
            this.newFileInNewWindowMenuItem,
            this.openFileMenuItem,
            this.saveFileMenuItem,
            this.saveFileAsMenuItem,
            this.saveAllFilesToolStripMenuItem,
            this.closeFileMenuItem,
            this.closeAllFilesMenuItem,
            this.quitProgramMenuItem});
            this.fileMenuItem.Name = "fileMenuItem";
            this.fileMenuItem.Size = new System.Drawing.Size(48, 20);
            this.fileMenuItem.Text = "Файл";
            // 
            // newFileMenuItem
            // 
            this.newFileMenuItem.Name = "newFileMenuItem";
            this.newFileMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newFileMenuItem.Size = new System.Drawing.Size(302, 22);
            this.newFileMenuItem.Text = "Новый файл";
            this.newFileMenuItem.Click += new System.EventHandler(this.NewFileMenuItemClick);
            // 
            // newFileInNewWindowMenuItem
            // 
            this.newFileInNewWindowMenuItem.Name = "newFileInNewWindowMenuItem";
            this.newFileInNewWindowMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.N)));
            this.newFileInNewWindowMenuItem.Size = new System.Drawing.Size(302, 22);
            this.newFileInNewWindowMenuItem.Text = "Новый файл в новом окне";
            this.newFileInNewWindowMenuItem.Click += new System.EventHandler(this.NewFileInNewWindowMenuItemClick);
            // 
            // openFileMenuItem
            // 
            this.openFileMenuItem.Name = "openFileMenuItem";
            this.openFileMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openFileMenuItem.Size = new System.Drawing.Size(302, 22);
            this.openFileMenuItem.Text = "Открыть файл";
            this.openFileMenuItem.Click += new System.EventHandler(this.OpenFileMenuItemClick);
            // 
            // saveFileMenuItem
            // 
            this.saveFileMenuItem.Name = "saveFileMenuItem";
            this.saveFileMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveFileMenuItem.Size = new System.Drawing.Size(302, 22);
            this.saveFileMenuItem.Text = "Сохранить файл";
            this.saveFileMenuItem.Click += new System.EventHandler(this.SaveFileMenuItemClick);
            // 
            // saveFileAsMenuItem
            // 
            this.saveFileAsMenuItem.Name = "saveFileAsMenuItem";
            this.saveFileAsMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveFileAsMenuItem.Size = new System.Drawing.Size(302, 22);
            this.saveFileAsMenuItem.Text = "Сохранить файл как...";
            this.saveFileAsMenuItem.Click += new System.EventHandler(this.SaveFileAsMenuItemClick);
            // 
            // closeFileMenuItem
            // 
            this.closeFileMenuItem.Name = "closeFileMenuItem";
            this.closeFileMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.closeFileMenuItem.Size = new System.Drawing.Size(302, 22);
            this.closeFileMenuItem.Text = "Закрыть файл";
            this.closeFileMenuItem.Click += new System.EventHandler(this.CloseFileMenuItemClick);
            // 
            // closeAllFilesMenuItem
            // 
            this.closeAllFilesMenuItem.Name = "closeAllFilesMenuItem";
            this.closeAllFilesMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.W)));
            this.closeAllFilesMenuItem.Size = new System.Drawing.Size(302, 22);
            this.closeAllFilesMenuItem.Text = "Закрыть все файлы";
            this.closeAllFilesMenuItem.Click += new System.EventHandler(this.CloseAllFilesMenuItemClick);
            // 
            // quitProgramMenuItem
            // 
            this.quitProgramMenuItem.Name = "quitProgramMenuItem";
            this.quitProgramMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.quitProgramMenuItem.Size = new System.Drawing.Size(302, 22);
            this.quitProgramMenuItem.Text = "Выход";
            this.quitProgramMenuItem.Click += new System.EventHandler(this.QuitProgramMenuItemClick);
            // 
            // editMenuItem
            // 
            this.editMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cutTextMenuItem,
            this.copyTextMenuItem,
            this.pasteTextMenuItem,
            this.selectAllMenuItem});
            this.editMenuItem.Name = "editMenuItem";
            this.editMenuItem.Size = new System.Drawing.Size(59, 20);
            this.editMenuItem.Text = "Правка";
            // 
            // cutTextMenuItem
            // 
            this.cutTextMenuItem.Name = "cutTextMenuItem";
            this.cutTextMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutTextMenuItem.Size = new System.Drawing.Size(190, 22);
            this.cutTextMenuItem.Text = "Вырезать";
            this.cutTextMenuItem.Click += new System.EventHandler(this.CutTextMenuItemClick);
            // 
            // copyTextMenuItem
            // 
            this.copyTextMenuItem.Name = "copyTextMenuItem";
            this.copyTextMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyTextMenuItem.Size = new System.Drawing.Size(190, 22);
            this.copyTextMenuItem.Text = "Копировать";
            this.copyTextMenuItem.Click += new System.EventHandler(this.CopyTextMenuItemClick);
            // 
            // pasteTextMenuItem
            // 
            this.pasteTextMenuItem.Name = "pasteTextMenuItem";
            this.pasteTextMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteTextMenuItem.Size = new System.Drawing.Size(190, 22);
            this.pasteTextMenuItem.Text = "Вставить";
            this.pasteTextMenuItem.Click += new System.EventHandler(this.PasteTextMenuItemClick);
            // 
            // selectAllMenuItem
            // 
            this.selectAllMenuItem.Name = "selectAllMenuItem";
            this.selectAllMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.selectAllMenuItem.Size = new System.Drawing.Size(190, 22);
            this.selectAllMenuItem.Text = "Выделить всё";
            this.selectAllMenuItem.Click += new System.EventHandler(this.SelectAllMenuItemClick);
            // 
            // formatMenuItem
            // 
            this.formatMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wordWrapToolStripMenuItem,
            this.fontToolStripMenuItem,
            this.fontSizeToolStripMenuItem});
            this.formatMenuItem.Name = "formatMenuItem";
            this.formatMenuItem.Size = new System.Drawing.Size(62, 20);
            this.formatMenuItem.Text = "Формат";
            // 
            // wordWrapToolStripMenuItem
            // 
            this.wordWrapToolStripMenuItem.Checked = true;
            this.wordWrapToolStripMenuItem.CheckOnClick = true;
            this.wordWrapToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.wordWrapToolStripMenuItem.Name = "wordWrapToolStripMenuItem";
            this.wordWrapToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.wordWrapToolStripMenuItem.Text = "Перенос по словам";
            this.wordWrapToolStripMenuItem.Click += new System.EventHandler(this.WordWrapToolStripMenuItemClick);
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.segoeUIToolStripMenuItem,
            this.timesNewRomanToolStripMenuItem,
            this.georgiaToolStripMenuItem,
            this.robotoToolStripMenuItem,
            this.arialToolStripMenuItem,
            this.consolasToolStripMenuItem,
            this.tahomaToolStripMenuItem});
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.fontToolStripMenuItem.Text = "Шрифт";
            // 
            // segoeUIToolStripMenuItem
            // 
            this.segoeUIToolStripMenuItem.CheckOnClick = true;
            this.segoeUIToolStripMenuItem.Name = "segoeUIToolStripMenuItem";
            this.segoeUIToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.segoeUIToolStripMenuItem.Text = "Segoe UI";
            this.segoeUIToolStripMenuItem.Click += new System.EventHandler(this.FontToolStripMenuItemClick);
            // 
            // timesNewRomanToolStripMenuItem
            // 
            this.timesNewRomanToolStripMenuItem.CheckOnClick = true;
            this.timesNewRomanToolStripMenuItem.Name = "timesNewRomanToolStripMenuItem";
            this.timesNewRomanToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.timesNewRomanToolStripMenuItem.Text = "Times New Roman";
            this.timesNewRomanToolStripMenuItem.Click += new System.EventHandler(this.FontToolStripMenuItemClick);
            // 
            // georgiaToolStripMenuItem
            // 
            this.georgiaToolStripMenuItem.CheckOnClick = true;
            this.georgiaToolStripMenuItem.Name = "georgiaToolStripMenuItem";
            this.georgiaToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.georgiaToolStripMenuItem.Text = "Georgia";
            this.georgiaToolStripMenuItem.Click += new System.EventHandler(this.FontToolStripMenuItemClick);
            // 
            // robotoToolStripMenuItem
            // 
            this.robotoToolStripMenuItem.CheckOnClick = true;
            this.robotoToolStripMenuItem.Name = "robotoToolStripMenuItem";
            this.robotoToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.robotoToolStripMenuItem.Text = "Lucida Sans";
            this.robotoToolStripMenuItem.Click += new System.EventHandler(this.FontToolStripMenuItemClick);
            // 
            // arialToolStripMenuItem
            // 
            this.arialToolStripMenuItem.CheckOnClick = true;
            this.arialToolStripMenuItem.Name = "arialToolStripMenuItem";
            this.arialToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.arialToolStripMenuItem.Text = "Arial";
            this.arialToolStripMenuItem.Click += new System.EventHandler(this.FontToolStripMenuItemClick);
            // 
            // consolasToolStripMenuItem
            // 
            this.consolasToolStripMenuItem.CheckOnClick = true;
            this.consolasToolStripMenuItem.Name = "consolasToolStripMenuItem";
            this.consolasToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.consolasToolStripMenuItem.Text = "Consolas";
            this.consolasToolStripMenuItem.Click += new System.EventHandler(this.FontToolStripMenuItemClick);
            // 
            // tahomaToolStripMenuItem
            // 
            this.tahomaToolStripMenuItem.CheckOnClick = true;
            this.tahomaToolStripMenuItem.Name = "tahomaToolStripMenuItem";
            this.tahomaToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.tahomaToolStripMenuItem.Text = "Tahoma";
            this.tahomaToolStripMenuItem.Click += new System.EventHandler(this.FontToolStripMenuItemClick);
            // 
            // fontSizeToolStripMenuItem
            // 
            this.fontSizeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6});
            this.fontSizeToolStripMenuItem.Name = "fontSizeToolStripMenuItem";
            this.fontSizeToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.fontSizeToolStripMenuItem.Text = "Размер текста";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.CheckOnClick = true;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(86, 22);
            this.toolStripMenuItem2.Text = "8";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.FontSizeToolStripMenuItemClick);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.CheckOnClick = true;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(86, 22);
            this.toolStripMenuItem3.Text = "12";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.FontSizeToolStripMenuItemClick);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.CheckOnClick = true;
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(86, 22);
            this.toolStripMenuItem4.Text = "16";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.FontSizeToolStripMenuItemClick);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.CheckOnClick = true;
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(86, 22);
            this.toolStripMenuItem5.Text = "24";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.FontSizeToolStripMenuItemClick);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.CheckOnClick = true;
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(86, 22);
            this.toolStripMenuItem6.Text = "48";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.FontSizeToolStripMenuItemClick);
            // 
            // settingsMenuItem
            // 
            this.settingsMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileSaveIntervalToolStripMenuItem,
            this.themeToolStripMenuItem});
            this.settingsMenuItem.Name = "settingsMenuItem";
            this.settingsMenuItem.Size = new System.Drawing.Size(79, 20);
            this.settingsMenuItem.Text = "Настройки";
            // 
            // fileSaveIntervalToolStripMenuItem
            // 
            this.fileSaveIntervalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.noAutoFileSaveToolStripMenuItem,
            this.sec1ToolStripMenuItem,
            this.sec3ToolStripMenuItem,
            this.sec5ToolStripMenuItem,
            this.sec10ToolStripMenuItem,
            this.sec30ToolStripMenuItem,
            this.min1ToolStripMenuItem,
            this.min3ToolStripMenuItem,
            this.min5ToolStripMenuItem,
            this.min15ToolStripMenuItem,
            this.min30ToolStripMenuItem});
            this.fileSaveIntervalToolStripMenuItem.Name = "fileSaveIntervalToolStripMenuItem";
            this.fileSaveIntervalToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.fileSaveIntervalToolStripMenuItem.Text = "Автосохранение";
            // 
            // noAutoFileSaveToolStripMenuItem
            // 
            this.noAutoFileSaveToolStripMenuItem.CheckOnClick = true;
            this.noAutoFileSaveToolStripMenuItem.Name = "noAutoFileSaveToolStripMenuItem";
            this.noAutoFileSaveToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.noAutoFileSaveToolStripMenuItem.Text = "Нет";
            this.noAutoFileSaveToolStripMenuItem.Click += new System.EventHandler(this.FileSaveIntervalToolStripMenuItemClick);
            // 
            // sec1ToolStripMenuItem
            // 
            this.sec1ToolStripMenuItem.CheckOnClick = true;
            this.sec1ToolStripMenuItem.Name = "sec1ToolStripMenuItem";
            this.sec1ToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.sec1ToolStripMenuItem.Text = "1 сек.";
            this.sec1ToolStripMenuItem.Click += new System.EventHandler(this.FileSaveIntervalToolStripMenuItemClick);
            // 
            // sec3ToolStripMenuItem
            // 
            this.sec3ToolStripMenuItem.CheckOnClick = true;
            this.sec3ToolStripMenuItem.Name = "sec3ToolStripMenuItem";
            this.sec3ToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.sec3ToolStripMenuItem.Text = "3 сек.";
            this.sec3ToolStripMenuItem.Click += new System.EventHandler(this.FileSaveIntervalToolStripMenuItemClick);
            // 
            // sec5ToolStripMenuItem
            // 
            this.sec5ToolStripMenuItem.CheckOnClick = true;
            this.sec5ToolStripMenuItem.Name = "sec5ToolStripMenuItem";
            this.sec5ToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.sec5ToolStripMenuItem.Text = "5 сек.";
            this.sec5ToolStripMenuItem.Click += new System.EventHandler(this.FileSaveIntervalToolStripMenuItemClick);
            // 
            // sec10ToolStripMenuItem
            // 
            this.sec10ToolStripMenuItem.CheckOnClick = true;
            this.sec10ToolStripMenuItem.Name = "sec10ToolStripMenuItem";
            this.sec10ToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.sec10ToolStripMenuItem.Text = "10 сек.";
            this.sec10ToolStripMenuItem.Click += new System.EventHandler(this.FileSaveIntervalToolStripMenuItemClick);
            // 
            // sec30ToolStripMenuItem
            // 
            this.sec30ToolStripMenuItem.CheckOnClick = true;
            this.sec30ToolStripMenuItem.Name = "sec30ToolStripMenuItem";
            this.sec30ToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.sec30ToolStripMenuItem.Text = "30 сек.";
            this.sec30ToolStripMenuItem.Click += new System.EventHandler(this.FileSaveIntervalToolStripMenuItemClick);
            // 
            // min1ToolStripMenuItem
            // 
            this.min1ToolStripMenuItem.CheckOnClick = true;
            this.min1ToolStripMenuItem.Name = "min1ToolStripMenuItem";
            this.min1ToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.min1ToolStripMenuItem.Text = "1 мин.";
            this.min1ToolStripMenuItem.Click += new System.EventHandler(this.FileSaveIntervalToolStripMenuItemClick);
            // 
            // min3ToolStripMenuItem
            // 
            this.min3ToolStripMenuItem.CheckOnClick = true;
            this.min3ToolStripMenuItem.Name = "min3ToolStripMenuItem";
            this.min3ToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.min3ToolStripMenuItem.Text = "3 мин.";
            this.min3ToolStripMenuItem.Click += new System.EventHandler(this.FileSaveIntervalToolStripMenuItemClick);
            // 
            // min5ToolStripMenuItem
            // 
            this.min5ToolStripMenuItem.CheckOnClick = true;
            this.min5ToolStripMenuItem.Name = "min5ToolStripMenuItem";
            this.min5ToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.min5ToolStripMenuItem.Text = "5 мин.";
            this.min5ToolStripMenuItem.Click += new System.EventHandler(this.FileSaveIntervalToolStripMenuItemClick);
            // 
            // min15ToolStripMenuItem
            // 
            this.min15ToolStripMenuItem.CheckOnClick = true;
            this.min15ToolStripMenuItem.Name = "min15ToolStripMenuItem";
            this.min15ToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.min15ToolStripMenuItem.Text = "15 мин.";
            this.min15ToolStripMenuItem.Click += new System.EventHandler(this.FileSaveIntervalToolStripMenuItemClick);
            // 
            // min30ToolStripMenuItem
            // 
            this.min30ToolStripMenuItem.CheckOnClick = true;
            this.min30ToolStripMenuItem.Name = "min30ToolStripMenuItem";
            this.min30ToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.min30ToolStripMenuItem.Text = "30 мин.";
            this.min30ToolStripMenuItem.Click += new System.EventHandler(this.FileSaveIntervalToolStripMenuItemClick);
            // 
            // themeToolStripMenuItem
            // 
            this.themeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lightThemeToolStripMenuItem,
            this.darkThemeToolStripMenuItem});
            this.themeToolStripMenuItem.Name = "themeToolStripMenuItem";
            this.themeToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.themeToolStripMenuItem.Text = "Тема";
            // 
            // lightThemeToolStripMenuItem
            // 
            this.lightThemeToolStripMenuItem.Name = "lightThemeToolStripMenuItem";
            this.lightThemeToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.lightThemeToolStripMenuItem.Text = "Светлая";
            this.lightThemeToolStripMenuItem.Click += new System.EventHandler(this.ChangeThemeToolStripMenuItemClick);
            // 
            // darkThemeToolStripMenuItem
            // 
            this.darkThemeToolStripMenuItem.Name = "darkThemeToolStripMenuItem";
            this.darkThemeToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.darkThemeToolStripMenuItem.Text = "Тёмная";
            this.darkThemeToolStripMenuItem.Click += new System.EventHandler(this.ChangeThemeToolStripMenuItemClick);
            // 
            // workaroundPanel
            // 
            this.workaroundPanel.Controls.Add(this.filesTabControl);
            this.workaroundPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.workaroundPanel.Location = new System.Drawing.Point(0, 24);
            this.workaroundPanel.Name = "workaroundPanel";
            this.workaroundPanel.Size = new System.Drawing.Size(800, 426);
            this.workaroundPanel.TabIndex = 2;
            this.workaroundPanel.DoubleClick += new System.EventHandler(this.WorkaroundPanelDoubleClick);
            // 
            // filesTabControl
            // 
            this.filesTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filesTabControl.Location = new System.Drawing.Point(0, 0);
            this.filesTabControl.Name = "filesTabControl";
            this.filesTabControl.SelectedIndex = 0;
            this.filesTabControl.Size = new System.Drawing.Size(800, 426);
            this.filesTabControl.TabIndex = 0;
            this.filesTabControl.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FilesTabControlMouseClick);
            // 
            // saveAllFilesToolStripMenuItem
            // 
            this.saveAllFilesToolStripMenuItem.Name = "saveAllFilesToolStripMenuItem";
            this.saveAllFilesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.S)));
            this.saveAllFilesToolStripMenuItem.Size = new System.Drawing.Size(302, 22);
            this.saveAllFilesToolStripMenuItem.Text = "Сохранить все файлы";
            this.saveAllFilesToolStripMenuItem.Click += new System.EventHandler(this.SaveAllFilesToolStripMenuItemClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.workaroundPanel);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "NotepadPlus";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFormFormClosing);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.workaroundPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newFileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveFileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveFileAsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeFileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeAllFilesMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitProgramMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutTextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyTextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteTextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAllMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wordWrapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newFileInNewWindowMenuItem;
        private System.Windows.Forms.Panel workaroundPanel;
        private System.Windows.Forms.TabControl filesTabControl;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStripMenuItem segoeUIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timesNewRomanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem georgiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem robotoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consolasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tahomaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontSizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem fileSaveIntervalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noAutoFileSaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sec1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sec3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sec5ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sec10ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sec30ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem min1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem min3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem min5ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem min15ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem min30ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem themeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lightThemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem darkThemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAllFilesToolStripMenuItem;
    }
}
