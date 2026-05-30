using System.Drawing.Drawing2D;
using System.Text;

namespace Equipment_rental
{
    internal static class CaptchaGenerator
    {
        private const string Chars = "ABCDEFGHJKLMNPQRSTUVWXYZ23456789";

        public static string GenerateCode(int length = 5)
        {
            var sb = new StringBuilder(length);
            for (int i = 0; i < length; i++)
                sb.Append(Chars[Random.Shared.Next(Chars.Length)]);
            return sb.ToString();
        }

        public static Bitmap CreateImage(string code, int width, int height)
        {
            var bitmap = new Bitmap(width, height);
            using var graphics = Graphics.FromImage(bitmap);
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            graphics.Clear(Color.White);

            var random = Random.Shared;
            for (int i = 0; i < 6; i++)
            {
                using var pen = new Pen(Color.FromArgb(random.Next(120, 200), random.Next(120, 200), random.Next(120, 200)));
                graphics.DrawLine(
                    pen,
                    random.Next(width),
                    random.Next(height),
                    random.Next(width),
                    random.Next(height));
            }

            using var font = new Font("Arial", height * 0.55f, FontStyle.Bold);
            using var brush = new SolidBrush(Color.FromArgb(30, 30, 30));
            var format = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };
            graphics.DrawString(code, font, brush, new RectangleF(0, 0, width, height), format);

            for (int i = 0; i < 40; i++)
            {
                bitmap.SetPixel(random.Next(width), random.Next(height),
                    Color.FromArgb(random.Next(150, 230), random.Next(150, 230), random.Next(150, 230)));
            }

            return bitmap;
        }
    }
}
