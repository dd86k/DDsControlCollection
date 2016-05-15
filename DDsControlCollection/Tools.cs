using System.Drawing;

namespace DDsControlCollection
{
    /// <summary>
    /// Type extensions.
    /// </summary>
    static class Extensions
    {
        public static SolidBrush Negate(this SolidBrush s) =>
            new SolidBrush(s.Color.Negate());

        public static Color Negate(this Color c) =>
            Color.FromArgb(0xFF - c.R, 0xFF - c.G, 0xFF - c.B);
    }
}
