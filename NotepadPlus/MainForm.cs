using System;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;
using System.Drawing;

namespace NotepadPlus
{
    /// <summary>
    /// Главная форма приложения.
    /// </summary>
    public partial class MainForm : Form
    {
        private int newFilesCount = 1;

        private static List<(string, int)> _fileSaveIntervals = new List<(string, int)> { 
            ("Нет", 0), ("1 сек.", 1), ("3 сек.", 3), ("5 сек.", 5), ("10 сек.", 10), ("30 сек.", 30), ("1 мин.", 60),
            ("3 мин.", 180), ("5 мин.", 300), ("15 мин.", 900), ("30 мин.", 1800)
        };

        private Timer autoSaveTimer;

        /// <summary>
        /// Инициализация формы.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            InitializeSettings();
        }

        /// <summary>
        /// Метод, показывающий диалог с ошибкой и выводящий пользователю сообщение.
        /// </summary>
        /// <param name="message">Сообщение, которое необходимо вывести.</param>
        private void ShowError(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// Инициализирует сохраненные настройки.
        /// </summary>
        private void InitializeSettings()
        {
            foreach (ToolStripMenuItem fontItem in fontToolStripMenuItem.DropDownItems)
                if (fontItem.Text == Properties.Settings.Default.Font)
                    fontItem.Checked = true;
            foreach (ToolStripMenuItem fontSizeItem in fontSizeToolStripMenuItem.DropDownItems)
                if (fontSizeItem.Text == Properties.Settings.Default.FontSize.ToString())
                    fontSizeItem.Checked = true;
            string fileSaveIntervalText = "";
            foreach ((string, int) fileSaveInterval in _fileSaveIntervals)
                if (fileSaveInterval.Item2 == Properties.Settings.Default.FileSaveInterval)
                    fileSaveIntervalText = fileSaveInterval.Item1;
            foreach (ToolStripMenuItem fileSaveIntervalItem in fileSaveIntervalToolStripMenuItem.DropDownItems)
                if (fileSaveIntervalItem.Text == fileSaveIntervalText)
                    fileSaveIntervalItem.Checked = true;
            lightThemeToolStripMenuItem.Checked = Properties.Settings.Default.BackgroundColor == Color.White;
            darkThemeToolStripMenuItem.Checked = !lightThemeToolStripMenuItem.Checked;

            SetAutosaveTimer(Properties.Settings.Default.FileSaveInterval);

            filesTabControl.Controls.Clear();
            if (Properties.Settings.Default.OpenedFiles == null)
                Properties.Settings.Default.OpenedFiles = new List<string>();
            foreach (string filePath in Properties.Settings.Default.OpenedFiles)
            {
                Console.WriteLine(filePath);
                if (System.IO.File.Exists(filePath))
                    AddNewFileTabPage(new File(filePath));
            }
                
            Properties.Settings.Default.OpenedFiles.Clear();
            Properties.Settings.Default.Save();

            if (filesTabControl.Controls.Count == 0)
                AddNewFileTabPage();

            UpdateTheme();
        }

        /// <summary>
        /// Устанавливает таймер на автосохранение файлов.
        /// </summary>
        /// <param name="seconds">Количество секунд, на которое необходимо установить таймер.</param>
        private void SetAutosaveTimer(int seconds)
        {
            if (autoSaveTimer != null)
                autoSaveTimer.Stop();
            if (seconds == 0)
                return;
            autoSaveTimer = new Timer();
            autoSaveTimer.Interval = seconds * 1000;
            autoSaveTimer.Tick += (sender, e) => SaveAllOpenedFiles(saveOnlyExistingFiles: true);
            autoSaveTimer.Start();
        }

        /// <summary>
        /// Обновляет тему приложения в соответствии с сохраненными настройками.
        /// </summary>
        private void UpdateTheme()
        {
            foreach (Control control in this.Controls)
                UpdateAllControlsColor(control, Properties.Settings.Default.BackgroundColor, Properties.Settings.Default.ForegroundColor);
            UpdateAllMenuItemsColor(menuStrip.Items, Properties.Settings.Default.BackgroundColor, Properties.Settings.Default.ForegroundColor);
            ToolStripProfessionalRenderer newRenderer;
            if (Properties.Settings.Default.BackgroundColor == Color.White)
                newRenderer = new ToolStripProfessionalRenderer();
            else
                newRenderer = new ToolStripProfessionalRenderer(new DarkMenuStripColorTable());
            menuStrip.Renderer = newRenderer;
            foreach (FileTabPage tabPage in filesTabControl.Controls)
            {
                tabPage.BackgroundColor = Properties.Settings.Default.BackgroundColor;
                tabPage.ForegroundColor = Properties.Settings.Default.ForegroundColor;
                tabPage.ContextMenuRenderer = newRenderer;
            }
        }

        /// <summary>
        /// Рекурсивно обновляет цвет (background и foreground) всех Controls.
        /// </summary>
        /// <param name="control">Объект, цвет которого необходимо поменять.</param>
        /// <param name="newBackColor">Новый background color.</param>
        /// <param name="newForeColor">Новый foreground color.</param>
        private void UpdateAllControlsColor(Control control, Color newBackColor, Color newForeColor)
        {
            control.BackColor = newBackColor;
            control.ForeColor = newForeColor;
            foreach (Control subControl in control.Controls)
            {
                UpdateAllControlsColor(subControl, newBackColor, newForeColor);
            }
        }

        /// <summary>
        /// Рекурсивно обновляет цвет (background и foreground) для коллекции объектов ToolStripItemCollection
        /// </summary>
        /// <param name="itemsCollection">Коллекция, элементы которой необходимо обновить.</param>
        /// <param name="newBackColor">Новый background color.</param>
        /// <param name="newForeColor">Новый foreground color.</param>
        private void UpdateAllMenuItemsColor(ToolStripItemCollection itemsCollection, Color newBackColor, Color newForeColor)
        {
            foreach (ToolStripMenuItem item in itemsCollection)
            {
                item.BackColor = newBackColor;
                item.ForeColor = newForeColor;
                if (item.DropDownItems != null)
                    UpdateAllMenuItemsColor(item.DropDownItems, newBackColor, newForeColor);
            }

        }

        /// <summary>
        /// Открывает вкладку с пустым (новым) файлом.
        /// </summary>
        private void AddNewFileTabPage()
        {
            File newFile = new File();
            FileTabPage newFileTabPage = new FileTabPage(newFile);
            newFileTabPage.Text = $"New File {newFilesCount}";
            filesTabControl.Controls.Add(newFileTabPage);
            filesTabControl.SelectedTab = newFileTabPage;
            newFilesCount++;
        }

        /// <summary>
        /// Открывает вкладку с существующим файлом.
        /// </summary>
        /// <param name="file">Объект файла, который необходимо открыть.</param>
        private void AddNewFileTabPage(File file)
        {
            try
            {
                FileTabPage fileTab = new FileTabPage(file);
                fileTab.Text = file.DisplayName;
                filesTabControl.Controls.Add(fileTab);
                filesTabControl.SelectedTab = fileTab;
            }
            catch
            {
                ShowError("Не удалось открыть файл.");
            }
        }

        /// <summary>
        /// Обработчик нажатия на кнопку `Новый файл`.
        /// </summary>
        /// <param name="sender">Объект, который вызвал событие.</param>
        /// <param name="e">Аргументы события.</param>
        private void NewFileMenuItemClick(object sender, EventArgs e) => AddNewFileTabPage();

        /// <summary>
        /// Обработчик нажатия на кнопку `Новый файл в новом окне`.
        /// </summary>
        /// <param name="sender">Объект, который вызвал событие.</param>
        /// <param name="e">Аргументы события.</param>
        private void NewFileInNewWindowMenuItemClick(object sender, EventArgs e)
        {
            MainForm newMainForm = new();
            newMainForm.Show();
        }

        /// <summary>
        /// Запрашивает у пользователя filename из FileDialog: SaveFileDialog или OpenFileDialog.
        /// </summary>
        /// <param name="dialog">Объект диалога, который нужно показать пользователю.</param>
        /// <param name="filename">Переменная, в которую записать полученный filename.</param>
        /// <returns>true, если filename был получен; false иначе.</returns>
        private bool TryGetFilenameFromDialog(FileDialog dialog, out string filename)
        {
            filename = "";
            try
            {
                dialog.Filter = "Text files(*.txt)|*.txt|RTF Files|*.rtf|All files(*.*)|*.*";
                if (dialog.ShowDialog() == DialogResult.Cancel)
                    return false;
                if (IsFileAlreadyOpened(Path.GetFullPath(dialog.FileName)))
                {
                    ShowError("Этот файл уже открыт в редакторе");
                    return false;
                }
                filename = dialog.FileName;
                return true;
            }
            catch
            {
                ShowError("Не удалось выбрать этот файл.");
                return false;
            }
        }

        /// <summary>
        /// Проверяет, открыт ли уже файл в программе или нет.
        /// </summary>
        /// <param name="fullPath">Полный путь к файлу.</param>
        /// <returns>true, если открыт; false иначе.</returns>
        private bool IsFileAlreadyOpened(string fullPath)
        {
            foreach (var tabPage in filesTabControl.TabPages)
            {
                var fileTabPage = (FileTabPage)tabPage;
                if (fileTabPage.File.FullPath == fullPath)
                    return true;
            }
            return false;
        }

        /// <summary>
        /// Обработчик нажатия на `Открыть файл`.
        /// </summary>
        /// <param name="sender">Объект, который вызвал событие.</param>
        /// <param name="e">Аргументы события.</param>
        private void OpenFileMenuItemClick(object sender, EventArgs e)
        {
            if (!TryGetFilenameFromDialog(new OpenFileDialog(), out string filename))
                return;
            if (!File.IsReadableFile(filename))
                ShowError("Невозможно прочитать этот файл.");
            else
                AddNewFileTabPage(new File(filename));
        }

        /// <summary>
        /// Обработчик нажатия на `Сохранить файл`
        /// </summary>
        /// <param name="sender">Объект, который вызвал событие.</param>
        /// <param name="e">Аргументы события.</param>
        private void SaveFileMenuItemClick(object sender, EventArgs e)
        {
            FileTabPage tabPage = (FileTabPage) filesTabControl.SelectedTab;
            SaveFileInTabPage(tabPage);
        }

        /// <summary>
        /// Сохраняет файл в указанной вкладке.
        /// </summary>
        /// <param name="tabPage">Вкладка, файл которой нужно сохранить.</param>
        /// <param name="saveOnlyExistingFiles">Флаг: сохранять только существующие файлы или все файлы.</param>
        private void SaveFileInTabPage(FileTabPage tabPage, bool saveOnlyExistingFiles = false)
        {
            try
            {
                if (tabPage.File.NoFilename && !saveOnlyExistingFiles)
                {
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Title = $"Сохранение файла `{tabPage.Text}`";
                    if (TryGetFilenameFromDialog(saveFileDialog, out string filename))
                        tabPage.File.FullPath = Path.GetFullPath(filename);
                    else
                        return;
                    // Файл нуждается в сохранении, даже если не был изменен
                    tabPage.File.IsSaved = false;
                }
                tabPage.Save();
            }
            catch (Exception exception)
            {
                ShowError($"Не удалось сохранить файл: {exception.Message}");
            }
        }

        /// <summary>
        /// Сохраняет все открытые файлы.
        /// </summary>
        /// <param name="saveOnlyExistingFiles">Флаг: сохранять только существующие файлы или все файлы.</param>
        private void SaveAllOpenedFiles(bool saveOnlyExistingFiles = false)
        {
            foreach (FileTabPage fileTabPage in filesTabControl.Controls)
                SaveFileInTabPage(fileTabPage, saveOnlyExistingFiles);
        }

        /// <summary>
        /// Обработчик нажатия на `Сохранить файл как`.
        /// </summary>
        /// <param name="sender">Объект, который вызвал событие.</param>
        /// <param name="e">Аргументы события.</param>
        private void SaveFileAsMenuItemClick(object sender, EventArgs e)
        {
            try
            {
                FileTabPage tabPage = (FileTabPage)filesTabControl.SelectedTab;
                if (!TryGetFilenameFromDialog(new SaveFileDialog(), out string filename))
                    return;
                tabPage.File.FullPath = filename;
                // Файл нуждается в сохранении, даже если не был изменен
                tabPage.File.IsSaved = false;

                tabPage.Save();
            }
            catch (Exception exception)
            {
                ShowError($"Не удалось сохранить файл: {exception.Message}");
            }
        }

        /// <summary>
        /// Спрашивает пользователя, сохранить файл или нет перед закрытием. Если да, то сохраняет.
        /// </summary>
        /// <param name="tabPage">Вкладка, для которой необходимо сохранить файл.</param>
        /// <returns>true, если пользователь выбрал да/нет; false, если пользователь нажал на отмену.</returns>
        private bool AskAndSaveBeforeClose(FileTabPage tabPage)
        {
            DialogResult dialogResult = MessageBox.Show(
                $"Сохранить файл {tabPage.Text} перед закрытием?",
                "Сохранение файла",
                MessageBoxButtons.YesNoCancel);
            if (dialogResult == DialogResult.Yes)
                SaveFileInTabPage(tabPage);
            else if (dialogResult == DialogResult.No)
                return true;
            else
                return false;
            return true;
        }

        /// <summary>
        /// Закрывает текущую открытую вкладку.
        /// </summary>
        private void CloseSelectedTab()
        {
            FileTabPage tabPage = (FileTabPage)filesTabControl.SelectedTab;
            if (!tabPage.File.IsSaved && !AskAndSaveBeforeClose(tabPage))
                return;
            filesTabControl.Controls.Remove(filesTabControl.SelectedTab);
            if (filesTabControl.TabCount == 0)
                AddNewFileTabPage();
        }

        /// <summary>
        /// Обработчик нажатия на `Закрыть файл`.
        /// </summary>
        /// <param name="sender">Объект, который вызвал событие.</param>
        /// <param name="e">Аргументы события.</param>
        private void CloseFileMenuItemClick(object sender, EventArgs e) => CloseSelectedTab();

        /// <summary>
        /// Обработчик нажатия на `Закрыть все файлы`.
        /// </summary>
        /// <param name="sender">Объект, который вызвал событие.</param>
        /// <param name="e">Аргументы события.</param>
        private void CloseAllFilesMenuItemClick(object sender, EventArgs e)
        {
            foreach (FileTabPage tabPage in filesTabControl.Controls)
                if (!tabPage.File.IsSaved && !AskAndSaveBeforeClose(tabPage))
                    return;
            filesTabControl.Controls.Clear();
            AddNewFileTabPage();
        }

        /// <summary>
        /// Обработчик нажатия на `Выход`.
        /// </summary>
        /// <param name="sender">Объект, который вызвал событие.</param>
        /// <param name="e">Аргументы события.</param>
        private void QuitProgramMenuItemClick(object sender, EventArgs e)
        {
            foreach (FileTabPage tabPage in filesTabControl.Controls)
                if (!tabPage.File.IsSaved && !AskAndSaveBeforeClose(tabPage))
                    return;
            Application.Exit();
        }

        /// <summary>
        /// Обработчик дабл-клика на пустое место в панели вкладок.
        /// </summary>
        /// <param name="sender">Объект, который вызвал событие.</param>
        /// <param name="e">Аргументы события.</param>
        private void WorkaroundPanelDoubleClick(object sender, EventArgs e) => AddNewFileTabPage();

        /// <summary>
        /// Обработчик нажатия мышкой на открытые вкладки (обрабатывает нажатие колесика мыши => закрывает нажатую вкладку).
        /// </summary>
        /// <param name="sender">Объект, который вызвал событие.</param>
        /// <param name="e">Аргументы события.</param>
        private void FilesTabControlMouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
                CloseSelectedTab();
        }

        /// <summary>
        /// Обработчик события закрытия главной формы.
        /// </summary>
        /// <param name="sender">Объект, который вызвал событие.</param>
        /// <param name="e">Аргументы события.</param>
        private void MainFormFormClosing(object sender, FormClosingEventArgs e)
        {
            Console.WriteLine(filesTabControl.Controls.Count);
            foreach (FileTabPage tabPage in filesTabControl.Controls)
                if (!tabPage.File.IsSaved && !AskAndSaveBeforeClose(tabPage))
                    e.Cancel = true;
            if (e.Cancel)
                return;
            
            foreach (FileTabPage tabPage in filesTabControl.Controls)
                if (!tabPage.File.NoFilename && !Properties.Settings.Default.OpenedFiles.Contains(tabPage.File.FullPath))
                    Properties.Settings.Default.OpenedFiles.Add(tabPage.File.FullPath);
            Properties.Settings.Default.Save();
        }

        /// <summary>
        /// Обработчик нажатия на `Вырезать`.
        /// </summary>
        /// <param name="sender">Объект, который вызвал событие.</param>
        /// <param name="e">Аргументы события.</param>
        private void CutTextMenuItemClick(object sender, EventArgs e)
        {
            FileTabPage tabPage = (FileTabPage)filesTabControl.SelectedTab;
            tabPage.Cut();
        }

        /// <summary>
        /// Обработчик нажатия на `Копировать`.
        /// </summary>
        /// <param name="sender">Объект, который вызвал событие.</param>
        /// <param name="e">Аргументы события.</param>
        private void CopyTextMenuItemClick(object sender, EventArgs e)
        {
            FileTabPage tabPage = (FileTabPage)filesTabControl.SelectedTab;
            tabPage.Copy();
        }

        /// <summary>
        /// Обработчик нажатия на `Вставить`.
        /// </summary>
        /// <param name="sender">Объект, который вызвал событие.</param>
        /// <param name="e">Аргументы события.</param>
        private void PasteTextMenuItemClick(object sender, EventArgs e)
        {
            FileTabPage tabPage = (FileTabPage)filesTabControl.SelectedTab;
            tabPage.Paste();
        }

        /// <summary>
        /// Обработчик нажатия на `Выделить все`.
        /// </summary>
        /// <param name="sender">Объект, который вызвал событие.</param>
        /// <param name="e">Аргументы события.</param>
        private void SelectAllMenuItemClick(object sender, EventArgs e)
        {
            FileTabPage tabPage = (FileTabPage)filesTabControl.SelectedTab;
            tabPage.SelectAll();
        }

        /// <summary>
        /// Обработчик нажатия на `Перенос по словам`.
        /// </summary>
        /// <param name="sender">Объект, который вызвал событие.</param>
        /// <param name="e">Аргументы события.</param>
        private void WordWrapToolStripMenuItemClick(object sender, EventArgs e)
        {
            foreach (FileTabPage tabPage in filesTabControl.Controls)
                tabPage.WordWrap = !tabPage.WordWrap;
        }

        /// <summary>
        /// Устанавливает checked = false для всей коллекции кроме одного элемента.
        /// </summary>
        /// <param name="menuItems">Коллекция элементов.</param>
        /// <param name="newCheckedItem">Элемент, который сохраняет свойство.</param>
        private void UncheckOthers(ToolStripItemCollection menuItems, ToolStripMenuItem newCheckedItem)
        {
            foreach (ToolStripMenuItem item in menuItems)
                if (item != newCheckedItem)
                    item.Checked = false;
        }

        /// <summary>
        /// Обработчик нажатия на `Шрифт`.
        /// </summary>
        /// <param name="sender">Объект, который вызвал событие.</param>
        /// <param name="e">Аргументы события.</param>
        private void FontToolStripMenuItemClick(object sender, EventArgs e)
        {
            ToolStripMenuItem toolStripMenuItem = (ToolStripMenuItem)sender;
            toolStripMenuItem.Checked = true;
            UncheckOthers(fontToolStripMenuItem.DropDownItems, toolStripMenuItem);

            Properties.Settings.Default.Font = toolStripMenuItem.Text;
            Properties.Settings.Default.Save();

            foreach (FileTabPage tabPage in filesTabControl.Controls)
                tabPage.UpdateFont();
        }

        /// <summary>
        /// Обработчик нажатия на `Размер текста`.
        /// </summary>
        /// <param name="sender">Объект, который вызвал событие.</param>
        /// <param name="e">Аргументы события.</param>
        private void FontSizeToolStripMenuItemClick(object sender, EventArgs e)
        {
            ToolStripMenuItem toolStripMenuItem = (ToolStripMenuItem)sender;
            toolStripMenuItem.Checked = true;
            UncheckOthers(fontSizeToolStripMenuItem.DropDownItems, toolStripMenuItem);

            Properties.Settings.Default.FontSize = int.Parse(toolStripMenuItem.Text);
            Properties.Settings.Default.Save();

            foreach (FileTabPage tabPage in filesTabControl.Controls)
                tabPage.UpdateFont();
        }

        /// <summary>
        /// Обработчик нажатия на `Автосохранение`.
        /// </summary>
        /// <param name="sender">Объект, который вызвал событие.</param>
        /// <param name="e">Аргументы события.</param>
        private void FileSaveIntervalToolStripMenuItemClick(object sender, EventArgs e)
        {
            ToolStripMenuItem toolStripMenuItem = (ToolStripMenuItem)sender;
            toolStripMenuItem.Checked = true;
            UncheckOthers(fileSaveIntervalToolStripMenuItem.DropDownItems, toolStripMenuItem);

            int newFileSaveInterval = 0;
            foreach ((string, int) fileSaveInterval in _fileSaveIntervals)
                if (fileSaveInterval.Item1 == toolStripMenuItem.Text)
                    newFileSaveInterval = fileSaveInterval.Item2;
            Properties.Settings.Default.FileSaveInterval = newFileSaveInterval;
            Properties.Settings.Default.Save();

            SetAutosaveTimer(newFileSaveInterval);
        }

        /// <summary>
        /// Обработчик нажатия на `Тема`.
        /// </summary>
        /// <param name="sender">Объект, который вызвал событие.</param>
        /// <param name="e">Аргументы события.</param>
        private void ChangeThemeToolStripMenuItemClick(object sender, EventArgs e)
        {
            ToolStripMenuItem toolStripMenuItem = (ToolStripMenuItem)sender;
            toolStripMenuItem.Checked = true;
            UncheckOthers(themeToolStripMenuItem.DropDownItems, toolStripMenuItem);

            switch (toolStripMenuItem.Text)
            {
                case "Светлая":
                    Properties.Settings.Default.BackgroundColor = Color.White;
                    Properties.Settings.Default.ForegroundColor = Color.Black;
                    break;
                case "Тёмная":
                    Properties.Settings.Default.BackgroundColor = Color.FromArgb(30, 30, 30);
                    Properties.Settings.Default.ForegroundColor = Color.White;
                    break;
            }
            Properties.Settings.Default.Save();

            UpdateTheme();
        }

        /// <summary>
        /// Обработчик нажатия на `Сохранить все файлы`.
        /// </summary>
        /// <param name="sender">Объект, который вызвал событие.</param>
        /// <param name="e">Аргументы события.</param>
        private void SaveAllFilesToolStripMenuItemClick(object sender, EventArgs e) => SaveAllOpenedFiles();
    }
}
