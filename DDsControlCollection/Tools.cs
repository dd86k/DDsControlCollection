using System.Drawing;
using static System.Reflection.Assembly;

namespace DDsControlCollection
{
    /// <summary>
    /// Type extensions.
    /// </summary>
    static class Extensions
    {
        internal static SolidBrush Negate(this SolidBrush s) =>
            new SolidBrush(s.Color.Negate());

        internal static Color Negate(this Color c) =>
            Color.FromArgb(0xFF - c.R, 0xFF - c.G, 0xFF - c.B);

        internal static Image GetEmbeddedImage(this string path)
        {
            return
                Image.FromStream(
                    GetExecutingAssembly().GetManifestResourceStream(
                    "DDsControlCollection." + path
                )
            );
        }

        // http://stackoverflow.com/a/14347746
        // Slightly edited for readability and tweaks
        internal static Image Resize(this Image image, Size size)
        {
            return new Bitmap(image, size);
        }
    }
}
