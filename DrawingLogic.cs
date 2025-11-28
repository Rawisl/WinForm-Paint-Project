using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm_Paint_Gr12
{
    internal class DrawingLogic
    {
        //Chứa các hàm toán học: g.DrawRectangle(...), g.DrawLine(...), tính toán tọa độ x, y, w, h.

        public static void DrawPencil(Graphics g, Point p1, Point p2, Color color)
        {
            // Tắt làm mịn để vẽ nét sắc cạnh
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            
            Pen pen = new Pen(color, 1);
            // Nối điểm cũ với điểm mới để không bị đứt khi di chuột
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
    }
}
