using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
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

        // http://stackoverflow.com/a/24199315
        // Slightly edited for readability and tweaks
        /*internal static Image HighDefinitionResize(this Image image, int width, int height)
        {
            Rectangle destRect = new Rectangle(0, 0, width, height);
            Bitmap destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (Graphics graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    //wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }*/
    }
}
