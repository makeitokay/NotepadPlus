using System.IO;

namespace NotepadPlus
{
    /// <summary>
    /// Класс файла.
    /// </summary>
    internal class File
    {
        public string FullPath = "";
        public string DisplayName => Path.GetFileName(FullPath);
        public string Extension => Path.GetExtension(FullPath);
        public bool IsSaved = true;
        public bool NoFilename => string.IsNullOrEmpty(FullPath);

        /// <summary>
        /// Пустой конструктор для новых файлов.
        /// </summary>
        public File() { }

        /// <summary>
        /// Конструктор для существующих файлов.
        /// </summary>
        /// <param name="filePath">Путь к файлу.</param>
        public File(string filePath)
        {
            FullPath = Path.GetFullPath(filePath);
        }

        /// <summary>
        /// Читает файл и возвращает содержимое.
        /// </summary>
        /// <returns>Содержимое файла.</returns>
        public string ReadFile()
        {
            return System.IO.File.ReadAllText(FullPath);
        }
        
        /// <summary>
        /// Перезаписывает файл.
        /// </summary>
        /// <param name="newContent">Новое содержимое файла.</param>
        public void Save(string newContent)
        {
            if (IsSaved)
                return;

            System.IO.File.WriteAllText(FullPath, newContent);
            IsSaved = true;
        }

        /// <summary>
        /// Переписывает содержимое файла под новым именем.
        /// </summary>
        /// <param name="newPath">Новый путь к файлу.</param>
        /// <param name="newContent">Новое содержимое файла.</param>
        public void Save(string newPath, string newContent)
        {
            FullPath = Path.GetFullPath(newPath);
            System.IO.File.WriteAllText(FullPath, newContent);
            IsSaved = true;
        }

        /// <summary>
        /// Возвращает, можно ли прочитать файл.
        /// </summary>
        /// <param name="filePath">Путь к файлу.</param>
        /// <returns>true, если файл можно прочитать; false иначе.</returns>
        public static bool IsReadableFile(string filePath)
        {
            try
            {
                using FileStream fileStream = new FileStream(filePath, FileMode.Open);
                return fileStream.CanRead;
            }
            catch 
            { 
                return false; 
            }
        }
    }
}
