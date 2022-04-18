using System.Windows.Forms;
using System.Drawing;

namespace NotepadPlus
{
    /// <summary>
    /// Класс-таблица с цветами, необходимый для корректного отображения контекстого меню.
    /// </summary>
    internal class DarkMenuStripColorTable : ProfessionalColorTable
    {
        public override Color ToolStripDropDownBackground => Color.Black;

        public override Color MenuItemPressedGradientBegin => Color.Black;

        public override Color MenuItemPressedGradientEnd => Color.Black;

        public override Color MenuStripGradientBegin => Color.Black;

        public override Color MenuStripGradientEnd => Color.Black;

        public override Color MenuItemSelected => Color.Black;

        public override Color MenuItemBorder => Color.Black;

        public override Color MenuBorder => Color.Black;

        public override Color ImageMarginGradientBegin => Color.FromArgb(30, 30, 30);

        public override Color ImageMarginGradientEnd => Color.FromArgb(30, 30, 30);

        public override Color ImageMarginGradientMiddle => Color.FromArgb(30, 30, 30);

        public override Color MenuItemSelectedGradientBegin => Color.DarkGray;

        public override Color MenuItemSelectedGradientEnd => Color.DarkGray;
    }
}
