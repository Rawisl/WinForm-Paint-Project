using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm_Paint_Gr12
{
    internal class DrawingLogic
    {
        //Chứa các hàm toán học: g.DrawRectangle(...), g.DrawLine(...), tính toán tọa độ x, y, w, h.
        public static void DrawPencil(Graphics g, Point p1, Point p2, Color color)
        {
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            Pen pen = new Pen(color, 1);
            g.DrawLine(pen, p1, p2);
            pen.Dispose();
        }

        public static void DrawBrush(Graphics g, Point p1, Point p2,  Color color, float width)
        {
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Pen brushPen = new Pen(color, width);
            g.DrawLine(brushPen, p1, p2);
            brushPen.Dispose();
        }
    }
}
