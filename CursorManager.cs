using System;
using System.Collections.Generic;
using System.Drawing; // Dùng cho các đối tượng đồ họa như Bitmap
using System.Runtime.InteropServices; // Dùng để gọi các hàm API của Windows (P/Invoke)
using System.Windows.Forms;

namespace WinForm_Paint_Gr12
{
    public static class CursorManager
    {
        // Dictionary tĩnh: Lưu trữ ánh xạ giữa loại công cụ (ToolType) và con trỏ (Cursor) tương ứng.
        private static readonly Dictionary<ToolType, Cursor> CursorMap = new Dictionary<ToolType, Cursor>();

        // --- Cấu trúc và Hàm API để chuyển đổi Bitmap sang Cursor ---
        // WinForms không hỗ trợ tạo Cursor từ PNG trực tiếp, nên cần gọi hàm API của Windows.

        // Cấu trúc ICONINFO của Windows API, dùng để mô tả thông tin của Icon/Cursor.
        [StructLayout(LayoutKind.Sequential)] // Đảm bảo các trường được sắp xếp đúng thứ tự bộ nhớ của Windows API.
        struct IconInfo
        {
            public bool fIcon;      // FALSE nếu là Cursor, TRUE nếu là Icon.
            public int xHotspot;     // Tọa độ X của Hotspot (điểm chính xác con trỏ trỏ vào).
            public int yHotspot;     // Tọa độ Y của Hotspot (điểm chính xác con trỏ trỏ vào).
            public IntPtr hbmMask;    // Handle tới Bitmap Mask (xác định vùng trong suốt/đen trắng).
            public IntPtr hbmColor;   // Handle tới Bitmap Màu (nội dung hiển thị của con trỏ).
        }

        // Khai báo hàm CreateIconIndirect() từ user32.dll: Dùng để tạo Icon/Cursor từ cấu trúc IconInfo.
        [DllImport("user32.dll")]
        private static extern IntPtr CreateIconIndirect(ref IconInfo icon);

        // Khai báo hàm GetIconInfo() từ user32.dll: Dùng để lấy thông tin Icon/Cursor hiện có.
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)] // Chỉ định kiểu trả về là Boolean.
        private static extern bool GetIconInfo(IntPtr hIcon, out IconInfo pIconInfo);

        // Hàm trợ giúp để tạo đối tượng Cursor .NET từ Bitmap và tọa độ Hotspot.
        private static Cursor CreateCursor(Bitmap bm, int xHotspot, int yHotspot)
        {
            // 1. Lấy Handle của Icon (tạm thời) từ Bitmap.
            IntPtr ptr = bm.GetHicon();

            // 2. Lấy thông tin chi tiết của Icon tạm thời vào cấu trúc tmp.
            IconInfo tmp = new IconInfo();
            GetIconInfo(ptr, out tmp);

            // 3. Sửa đổi thông tin: Đặt Hotspot và chuyển thành Cursor.
            tmp.xHotspot = xHotspot; // Gán tọa độ X do người dùng định nghĩa.
            tmp.yHotspot = yHotspot; // Gán tọa độ Y do người dùng định nghĩa.
            tmp.fIcon = false;       // Bắt buộc phải là FALSE để nó hoạt động như một Con Trỏ (Cursor).

            // 4. Gọi Windows API để tạo Con Trỏ mới từ thông tin đã sửa đổi.
            ptr = CreateIconIndirect(ref tmp);

            // 5. Trả về đối tượng Cursor của WinForms được tạo từ Handle API.
            return new Cursor(ptr);
        }

        // --- Hàm Khởi tạo Tĩnh (Static Constructor) ---
        // Hàm này chỉ chạy MỘT LẦN DUY NHẤT khi lớp CursorManager được sử dụng lần đầu tiên.
        static CursorManager()
        {
            // Lấy hình ảnh từ Resources (Chúng ta ép kiểu từ kiểu tài nguyên sang Bitmap).
            Bitmap pencilBitmap = (Bitmap)Properties.Resources.pencil;
            Bitmap brushBitmap = (Bitmap)Properties.Resources.brush;

            try
            {
                // Tạo Cursor cho Pencil:
                // Hotspot (1, Chiều cao - 2) đặt điểm nóng gần góc dưới bên trái, khớp với đầu bút.
                Cursor customPencil = CreateCursor(pencilBitmap, 1, pencilBitmap.Height - 2);

                // Tạo Cursor cho Brush:
                // Hotspot (Chiều rộng / 2, Chiều cao / 2) đặt điểm nóng ở trung tâm cọ.
                Cursor customBrush = CreateCursor(brushBitmap, brushBitmap.Width / 2, brushBitmap.Height / 2);

                // Thêm các con trỏ tùy chỉnh vào Dictionary để sử dụng sau này.
                CursorMap.Add(ToolType.Pencil, customPencil);
                CursorMap.Add(ToolType.Brush, customBrush);

                // --- Có thể thêm các công cụ mặc định khác tại đây ---
                // CursorMap.Add(ToolType.Eraser, Cursors.Cross);
                // CursorMap.Add(ToolType.Text, Cursors.IBeam);
                // CursorMap.Add(ToolType.None, Cursors.Default);

            }
            catch (Exception ex)
            {
                // Xử lý lỗi: Nếu việc tạo Cursor thất bại (ví dụ: tệp PNG bị lỗi),
                // in ra debug và dùng con trỏ mặc định (Cursors.Cross) để tránh crash ứng dụng.
                System.Diagnostics.Debug.WriteLine($"Lỗi tạo Cursor tùy chỉnh: {ex.Message}");
                CursorMap.Add(ToolType.Pencil, Cursors.Cross);
                CursorMap.Add(ToolType.Brush, Cursors.Cross);
            }
        }

        // Hàm công khai: Trả về đối tượng Cursor tương ứng với ToolType được truyền vào.
        public static Cursor GetCursor(ToolType tool)
        {
            // Kiểm tra xem ToolType đã tồn tại trong Map chưa.
            if (CursorMap.ContainsKey(tool))
            {
                return CursorMap[tool]; // Trả về con trỏ tùy chỉnh.
            }
            // Nếu không tìm thấy, trả về con trỏ mặc định của hệ thống.
            return Cursors.Default;
        }
    }
}