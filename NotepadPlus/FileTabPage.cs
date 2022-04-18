using System;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing;

namespace NotepadPlus
{
    /// <summary>
    /// Класс вкладки с файлом, унаследованный от `TabPage`.
    /// </summary>
    internal class FileTabPage : TabPage
    {
        private RichTextBox textInputBox;
        
        public string UserText => textInputBox.Text;

        public File File;

        private ToolStripMenuItem copyItem;
        private ToolStripMenuItem cutItem;
        private ToolStripMenuItem pasteItem;
        private ToolStripMenuItem selectAllItem;
        private ToolStripMenuItem italicsItem;
        private ToolStripMenuItem boldItem;
        private ToolStripMenuItem underlineItem;
        private ToolStripMenuItem strikethroughItem;

        public bool WordWrap {
            get => textInputBox.WordWrap;
            set => textInputBox.WordWrap = value;
        }

        public Color BackgroundColor
        {
            set
            {
                textInputBox.BackColor = value;
                textInputBox.ContextMenuStrip.BackColor = value;
                BackColor = value;
            }
        }

        public Color ForegroundColor
        {
            set
            {
                textInputBox.ForeColor = value;
                textInputBox.ContextMenuStrip.ForeColor = value;
                ForeColor = value;
            }
        }

        public ToolStripProfessionalRenderer ContextMenuRenderer
        {
            set
            {
                textInputBox.ContextMenuStrip.Renderer = value;
            }
        }

        /// <summary>
        /// Инициализирует элементы контекстного меню, активируемого ПКМ.
        /// </summary>
        public void InitializeContextMenuStripItems()
        {
            textInputBox.ContextMenuStrip.Items.Add("Костыль, чтобы контекстное меню открывалось с первого раза");

            copyItem = new ToolStripMenuItem("Копировать");
            cutItem = new ToolStripMenuItem("Вырезать");
            pasteItem = new ToolStripMenuItem("Вставить");
            selectAllItem = new ToolStripMenuItem("Выделить всё");
            italicsItem = new ToolStripMenuItem("Курсив");
            boldItem = new ToolStripMenuItem("Жирный");
            underlineItem = new ToolStripMenuItem("Подчеркнуть");
            strikethroughItem = new ToolStripMenuItem("Зачеркнуть");

            copyItem.Click += (sender, e) => Copy();
            cutItem.Click += (sender, e) => Cut();
            pasteItem.Click += (sender, e) => Paste();
            selectAllItem.Click += (sender, e) => SelectAll();

            italicsItem.Click += (sender, e) => ItalicsSelection();
            boldItem.Click += (sender, e) => BoldSelection();
            underlineItem.Click += (sender, e) => UnderlineSelection();
            strikethroughItem.Click += (sender, e) => StrikeoutSelection();
        }

        /// <summary>
        /// Конструктор: принимает на вход файл, инициализирует RichTextBox, применяет тему.
        /// </summary>
        /// <param name="file"></param>
        public FileTabPage(File file) : base()
        {
            File = file;

            textInputBox = new RichTextBox();
            textInputBox.Dock = DockStyle.Fill;
            UpdateFont();
            if (!File.NoFilename)
                UpdateText();
            textInputBox.TextChanged += new EventHandler(TextInputBoxValueChanged);
            textInputBox.ContextMenuStrip = new ContextMenuStrip();
            textInputBox.ContextMenuStrip.Opening += new CancelEventHandler(ContextMenuStripOpening);
            Controls.Add(textInputBox);

            BackgroundColor = Properties.Settings.Default.BackgroundColor;
            ForegroundColor = Properties.Settings.Default.ForegroundColor;

            InitializeContextMenuStripItems();
        }

        /// <summary>
        /// Обновляет содержимое RichTextBox в соответствии с файлом. 
        /// </summary>
        public void UpdateText()
        {
            if (File.NoFilename)
                return;

            if (File.Extension == ".rtf")
                textInputBox.LoadFile(File.FullPath);
            else
                textInputBox.Text = File.ReadFile();
        }

        /// <summary>
        /// Обновляет шрифт в соответствии с сохраненными настройками.
        /// </summary>
        public void UpdateFont()
        {
            textInputBox.Font = new Font(Properties.Settings.Default.Font, Properties.Settings.Default.FontSize);
        }

        /// <summary>
        /// Сохраняет файл, привязанный к вкладке.
        /// </summary>
        public void Save()
        {
            if (File.NoFilename || File.IsSaved)
                return;

            if (File.Extension == ".rtf")
                textInputBox.SaveFile(File.FullPath);
            else
                File.Save(UserText);

            Text = File.DisplayName;
        }

        /// <summary>
        /// Вырезает выделенный текст.
        /// </summary>
        public void Cut() => textInputBox.Cut();

        /// <summary>
        /// Копирует выделенный текст.
        /// </summary>
        public void Copy() => textInputBox.Copy();

        /// <summary>
        /// Вставляет текст из буфера обмена.
        /// </summary>
        public void Paste() => textInputBox.Paste();

        /// <summary>
        /// Выделяет весь текст.
        /// </summary>
        public void SelectAll() => textInputBox.SelectAll();

        /// <summary>
        /// Устанавливает или снимает курсив у выделенного текста.
        /// </summary>
        public void ItalicsSelection()
        {
            if (!textInputBox.SelectionFont.Italic)
                textInputBox.SelectionFont = new Font(textInputBox.SelectionFont, textInputBox.SelectionFont.Style | FontStyle.Italic);
            else
                textInputBox.SelectionFont = new Font(textInputBox.SelectionFont, textInputBox.SelectionFont.Style & ~FontStyle.Italic);
        }

        /// <summary>
        /// Устанавливает или снимает жирность на выделенной текст.
        /// </summary>
        public void BoldSelection()
        {
            if (!textInputBox.SelectionFont.Bold)
                textInputBox.SelectionFont = new Font(textInputBox.SelectionFont, textInputBox.SelectionFont.Style | FontStyle.Bold);
            else
                textInputBox.SelectionFont = new Font(textInputBox.SelectionFont, textInputBox.SelectionFont.Style & ~FontStyle.Bold);
        }

        /// <summary>
        /// Добавляет или удаляет подчеркивание у выделенного текста.
        /// </summary>
        public void UnderlineSelection()
        {
            if (!textInputBox.SelectionFont.Underline)
                textInputBox.SelectionFont = new Font(textInputBox.SelectionFont, textInputBox.SelectionFont.Style | FontStyle.Underline);
            else
                textInputBox.SelectionFont = new Font(textInputBox.SelectionFont, textInputBox.SelectionFont.Style & ~FontStyle.Underline);
        }

        /// <summary>
        /// Добавляет или удаляет зачеркивание у выделенного текста.
        /// </summary>
        public void StrikeoutSelection()
        {
            if (!textInputBox.SelectionFont.Strikeout)
                textInputBox.SelectionFont = new Font(textInputBox.SelectionFont, textInputBox.SelectionFont.Style | FontStyle.Strikeout);
            else
                textInputBox.SelectionFont = new Font(textInputBox.SelectionFont, textInputBox.SelectionFont.Style & ~FontStyle.Strikeout);
        }

        /// <summary>
        /// Обработчик события изменения содержимого RichTextBox.
        /// </summary>
        /// <param name="sender">Объект, который вызвал событие.</param>
        /// <param name="e">Аргументы события.</param>
        private void TextInputBoxValueChanged(object sender, EventArgs e)
        {
            if (File.IsSaved)
                Text += "*";
            File.IsSaved = false;
        }

        /// <summary>
        /// Обработчик события открытия контекстного меню.
        /// </summary>
        /// <param name="sender">Объект, который вызвал событие.</param>
        /// <param name="e">Аргументы события.</param>
        private void ContextMenuStripOpening(object sender, CancelEventArgs e)
        {
            textInputBox.ContextMenuStrip.Items.Clear();
            textInputBox.ContextMenuStrip.Items.Add(pasteItem);
            textInputBox.ContextMenuStrip.Items.Add(selectAllItem);
            if (!string.IsNullOrEmpty(textInputBox.SelectedText))
            {
                textInputBox.ContextMenuStrip.Items.Add(new ToolStripSeparator());
                textInputBox.ContextMenuStrip.Items.Add(copyItem);
                textInputBox.ContextMenuStrip.Items.Add(cutItem);
                textInputBox.ContextMenuStrip.Items.Add(new ToolStripSeparator());
                textInputBox.ContextMenuStrip.Items.Add(boldItem);
                boldItem.Checked = textInputBox.SelectionFont.Bold;
                textInputBox.ContextMenuStrip.Items.Add(italicsItem);
                italicsItem.Checked = textInputBox.SelectionFont.Italic;
                textInputBox.ContextMenuStrip.Items.Add(underlineItem);
                underlineItem.Checked = textInputBox.SelectionFont.Underline;
                textInputBox.ContextMenuStrip.Items.Add(strikethroughItem);
                strikethroughItem.Checked = textInputBox.SelectionFont.Strikeout;
            }

            textInputBox.ContextMenuStrip.Show();
        }
    }
}
