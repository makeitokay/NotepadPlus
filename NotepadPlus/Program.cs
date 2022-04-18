using System;
using System.Windows.Forms;

namespace NotepadPlus
{
    /// <summary>
    /// Главный исполняемый класс программы.
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// Входная точка в приложение.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
