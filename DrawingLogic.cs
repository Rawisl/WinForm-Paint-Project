using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm_Paint_Gr12
{
    internal class DrawingLogic
    {
        //Chứa các hàm toán học: g.DrawRectangle(...), g.DrawLine(...), tính toán tọa độ x, y, w, h.

        public static void DrawPencil(Graphics g, Point p1, Point p2, Color color, float width)
        {
            // Tắt làm mịn để vẽ nét sắc cạnh
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;

            Pen pen = new Pen(color, width);
            // Nối điểm cũ với điểm mới để không bị đứt khi di chuột
            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.LineJoin = System.Drawing.Drawing2D.LineJoin.Round;
            g.DrawLine(pen, p1, p2);
            pen.Dispose(); // Dispose để giải phóng tài nguyên tăng hiệu suất tránh lãng phí
        }

        public static void DrawBrush(Graphics g, Point p1, Point p2, Color color, float width)
        {
            // Bật làm mịn để vẽ nét to liền
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            Pen brushPen = new Pen(color, width);

            // Bo tròn 2 đầu bút để đoạn vẽ liền mượt (để ý khi vẽ một đoạn sẽ thấy đầu và cuối đoạn sẽ bo tròn)
            brushPen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            brushPen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            g.DrawLine(brushPen, p1, p2);
            brushPen.Dispose(); // Dispose để giải phóng tài nguyên tăng hiệu suất tránh lãng phí
        }

        // Hàm để căn giữa canvas
        public static void CenterPictureBox(Control control, Control form)
        {
            // công thức căn chỉnh cho picturebox ở giữa
            int x = (form.Width - control.Width) / 2;
            int y = (form.Height - control.Height) / 2;

            if (x < 0) x = 0;
            if (y < 0) y = 0;

            control.Location = new Point(x, y);
        }

        public static void DrawRectangle(Graphics g, Rectangle r, Color color, float width)
        {
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;

            using (Pen pen = new Pen(color, width))
            {
                g.DrawRectangle(pen, r);
            }
        }

        // Hàm tính kích cỡ và toạ độ của hình chữ nhật
        public static Rectangle GetRectangle(Point p1, Point p2)
        {
            // tính toạ độ x, y bên góc trái của hình chữ nhật
            int x = Math.Min(p1.X, p2.X);
            int y = Math.Min(p1.Y, p2.Y);

            // tính chiều dài chiều rộng hcn
            int width = Math.Abs(p1.X - p2.X);
            int height = Math.Abs(p1.Y - p2.Y);

            return new Rectangle(x, y, width, height);
        }

        public static void DrawEllipse(Graphics g, Rectangle rect, Color color, float width)
        {
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;

            using (Pen pen = new Pen(color, width))
            {
                g.DrawEllipse(pen, rect);
            }
        }

        // Hàm tính lại kích cỡ và toạ độ để vẽ hình vuông hay tròn tỉ lệ 1:1
        public static Rectangle GetPerfectShape(Point p1, Point p2)
        {
            int x = Math.Min(p1.X, p2.X);
            int y = Math.Min(p1.Y, p2.Y);
            int width = Math.Abs(p1.X - p2.X);
            int height = Math.Abs(p1.Y - p2.Y);

            int size = Math.Min(width, height); // tính size cho tỉ lệ 1:1

            // tính lại toạ độ khi thay đổi width với height bằng size
            if (p1.X > p2.X)
                x = p1.X - size;
            if (p1.Y > p2.Y)
                y = p1.Y - size;

            width = size;
            height = size;

            return new Rectangle(x, y, width, height);
        }
    }
}
