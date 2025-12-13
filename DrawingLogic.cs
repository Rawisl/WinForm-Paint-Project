using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
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

        public static void DrawLine(Graphics g, Point p1, Point p2, Color color, float width)
        {
            // Với công cụ hình học (Line), ta nên bật làm mịn (AntiAlias) để đường thẳng đẹp hơn
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // Sử dụng 'using' để tự động Dispose pen sau khi dùng xong (Code gọn và an toàn hơn)
            using (Pen pen = new Pen(color, width))
            {
                // Bo tròn 2 đầu mút của đoạn thẳng cho đẹp (đỡ bị cụt lủn nếu nét to)
                pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
                pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

                // Vẽ đường thẳng từ điểm đầu (MouseDown) đến điểm cuối (MouseUp)
                g.DrawLine(pen, p1, p2);
            }
        }

        public static void DrawRectangle(Graphics g, Rectangle r, Color color, float width)
        {
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

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
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            using (Pen pen = new Pen(color, width))
            {
                g.DrawEllipse(pen, rect);
            }
        }

        public static void DrawTriangle(Graphics g, Rectangle rect, Color color, float width)
        {
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            using (Pen pen = new Pen(color, width))
            {
                //bo tròn các góc nối để hình nhìn mềm hơn
                pen.LineJoin = System.Drawing.Drawing2D.LineJoin.Round;

                Point p1 = new Point(rect.X + rect.Width / 2, rect.Y); //tính tọa độ đỉnh giữa
                Point p2 = new Point(rect.X, rect.Bottom); //góc trái (Dưới)
                Point p3 = new Point(rect.Right, rect.Bottom); //góc phải (dưới)

                g.DrawPolygon(pen, new Point[] { p1, p2, p3 });
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
        public static void DrawEraser(Graphics g, Point start, Point end, float size)
        {
            //tính toán tọa độ và khoảng cách
            float dx = end.X - start.X;
            float dy = end.Y - start.Y;
            float distance = (float)Math.Sqrt(dx * dx + dy * dy);

            //làm mịn trong trường hợp chuột di chuyển quá nhanh
            float step = 0.5f;
            if (distance <= 0) distance = 1; // tránh bug chia 0

            for (float i = 0; i <= distance; i += step)
            {
                // Tính tọa độ trung gian
                float t = i / distance;
                float x = start.X + dx * t;
                float y = start.Y + dy * t;

                // Vẽ hình vuông màu trắng tại tọa độ đó
                // (Trừ đi size/2 để tâm hình vuông trùng với con chuột)
                g.FillRectangle(Brushes.White, x - size / 2, y - size / 2, size, size);
            }
        }

        // LockBitmap phải kế thừa IDisposable để có thể dùng using vì using không hỗ trợ cho BitmapData
        // có thể dùng cấu trúc try finally nhưng nó dài với code không được gọn
        public struct LockBitmap : IDisposable
        {
            private readonly Bitmap bitmap;
            public BitmapData data { get; private set; }

            // cú pháp '=>' tương đương với int function { return value; }
            public IntPtr Scan0 => data.Scan0;
            public int Stride => data.Stride;
            public int Width => data.Width;
            public int Height => data.Height;
            public int BytesPerPixel { get; private set; }

            public LockBitmap(Bitmap bmp)
            {
                bitmap = bmp;
                Rectangle rect = new Rectangle(0, 0, bmp.Width, bmp.Height);
                data = bitmap.LockBits(rect, ImageLockMode.ReadWrite, bmp.PixelFormat);

                BytesPerPixel = Image.GetPixelFormatSize(bmp.PixelFormat) / 8;
            }

            // kế thừa IDisposable sẽ tự động gọi hàm Dispose này và bắt buộc phải có
            public void Dispose()
            {
                // sau khi làm xong trong lúc lockbits lại thì phải unlock nó ra để thả công việc cho GC tiếp tục làm
                bitmap.UnlockBits(data);
            }
        }

        // Hàm kiểm tra màu trong mảng byte
        private static bool IsMatch(byte[] pixels, int idx, byte r, byte g, byte b, int tolerance)
        {
            // Chú ý: Thứ tự trong mảng là B-G-R
            byte bVal = pixels[idx];
            byte gVal = pixels[idx + 1];
            byte rVal = pixels[idx + 2];

            // Công thức Manhattan
            // có thể dùng công thức khoảng cách euclid nhưng vì nó dùng căn bậc 2 với bình phương nên tốc độ tính toán sẽ khá chậm
            // công thức này tính tổng độ sai lệch màu sắc giữa hai điểm ảnh
            int delta = Math.Abs(bVal - b) + Math.Abs(gVal - g) + Math.Abs(rVal - r);
            
            // so sánh với dung sai
            return delta <= tolerance;
        }

        // Hàm kiểm tra màu ở đầu hàm fill
        private static bool CheckColor(Color c1, Color c2, int tolerance)
        {
            if (tolerance == 0) return c1.ToArgb() == c2.ToArgb();

            int delta = Math.Abs(c1.R - c2.R) + Math.Abs(c1.G - c2.G) + Math.Abs(c1.B - c2.B);
            return delta <= tolerance;
        }

        public static void Fill(Bitmap bmp, Point p1, Color currentColor, int tolerance)
        {
            // Lấy màu lúc con trỏ chỉ vào
            Color targetColor = bmp.GetPixel(p1.X, p1.Y);

            // Kiểm tra nhanh: Nếu màu trùng nhau thì nghỉ
            if (CheckColor(targetColor, currentColor, tolerance)) return;

            // Sử dụng LockBitmap
            // Khi chạy hết khối using này, ảnh sẽ TỰ ĐỘNG được Unlock.
            using (var lockBmp = new LockBitmap(bmp))
            {
                // Copy toàn bộ pixel từ ảnh ra mảng byte[] cho nhanh
                int byteCount = lockBmp.Stride * lockBmp.Height;
                byte[] pixels = new byte[byteCount];
                Marshal.Copy(lockBmp.Scan0, pixels, 0, byteCount);

                // Các biến cục bộ để truy xuất nhanh
                int width = lockBmp.Width;
                int height = lockBmp.Height;
                int stride = lockBmp.Stride;
                int bpp = lockBmp.BytesPerPixel; // 3 hoặc 4 byte

                // Màu hiện tại con trỏ chỉ vào (tR,tG,tB) và Màu mình chọn để thay thế (cR,cG,cB,cA)
                byte tR = targetColor.R, tG = targetColor.G, tB = targetColor.B;
                byte cR = currentColor.R, cG = currentColor.G, cB = currentColor.B, cA = currentColor.A;

                // Stack cho thuật toán
                Stack<Point> stack = new Stack<Point>();
                stack.Push(p1);

                // Vòng lặp quét (Scanline Loop)
                while (stack.Count > 0)
                {
                    Point p = stack.Pop();
                    int x = p.X;
                    int y = p.Y;
                    int idx = (y * stride) + (x * bpp); // Tính index trong mảng byte

                    // Di chuyển sang TRÁI tìm biên
                    while (x >= 0 && IsMatch(pixels, idx, tR, tG, tB, tolerance))
                    {
                        --x;
                        idx -= bpp;
                    }

                    // Lùi lại 1 bước vì vòng lặp trên di chuyển quá mức
                    ++x;
                    idx += bpp;

                    // cờ để xác định tô màu và quét trên/dưới
                    bool Above = false;
                    bool Below = false;
                    
                    // Di chuyển sang PHẢI: Tô màu và quét trên/dưới
                    while (x < width && IsMatch(pixels, idx, tR, tG, tB, tolerance))
                    {
                        // TÔ MÀU
                        pixels[idx] = cB;   // Blue
                        pixels[idx + 1] = cG;   // Green
                        pixels[idx + 2] = cR;   // Red
                        if (bpp == 4) pixels[idx + 3] = cA; // Alpha

                        // Kiểm tra dòng trên của pixels
                        if (y > 0)
                        {
                            int upIdx = idx - stride;
                            bool match = IsMatch(pixels, upIdx, tR, tG, tB, tolerance);
                            if (!Above && match)
                            {
                                stack.Push(new Point(x, y - 1));
                                Above = true;
                            }
                            else if (Above && !match) Above = false;
                        }

                        // Kiểm tra dòng dưới
                        if (y < height - 1)
                        {
                            int downIdx = idx + stride;
                            bool match = IsMatch(pixels, downIdx, tR, tG, tB, tolerance);
                            if (!Below && match)
                            {
                                stack.Push(new Point(x, y + 1));
                                Below = true;
                            }
                            else if (Below && !match) Below = false;
                        }

                        // Dịch sang phải
                        ++x;
                        idx += bpp;
                    }
                }

                // Copy ngược mảng byte đã sửa vào lại Bitmap
                Marshal.Copy(pixels, 0, lockBmp.Scan0, byteCount);
            }
        }
    }
}
