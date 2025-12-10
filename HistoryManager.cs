using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm_Paint_Gr12
{
    public class HistoryManager
    {
        //tạo một List và biến index để theo dõi lịch sử
        private List<Bitmap> history;
        private int currentIndex;
        private int maxHistorySize;

        public HistoryManager(int maxSize = 20)
        {
            history = new List<Bitmap>();
            currentIndex = -1; //chưa có gì nên set -1
            maxHistorySize = maxSize;
        }

        //viết hàm lưu hình ảnh hiện tại
        public void saveSnapshot(Bitmap currentImage)
        {
            // Ví dụ: Đang có [1, 2, 3, 4], Undo về 2, vẽ nét mới -> Xóa 3, 4 -> Thành [1, 2, Mới]
            if (currentIndex < history.Count - 1)
            {
                for (int i = history.Count - 1; i > currentIndex; i--)
                {
                    history[i].Dispose();
                    history.RemoveAt(i);
                }
            }
            //thêm cái clone của bitmap ảnh hiện tại vào list
            history.Add((Bitmap)currentImage.Clone());
            currentIndex++;

            if (history.Count > maxHistorySize)
            {
                history[0].Dispose();
                history.RemoveAt(0);
                currentIndex--;
            }

        }

        //thực hiện undo
        public Bitmap undo(Bitmap currentImage)
        {
            if (currentIndex > 0)
            {
                currentIndex--;
                return (Bitmap)history[currentIndex].Clone();
            }
            return null; //không còn gì để undo
        }

        //thực hiện redo
        public Bitmap redo(Bitmap currentImage)
        {
            if (currentIndex < history.Count - 1)
            {
                currentIndex++;
                return (Bitmap)history[currentIndex].Clone();
            }
            return null; //không có gì để redo
        }

        // Kiểm tra để bật/tắt nút trên giao diện
        public bool CanUndo => currentIndex > 0;
        public bool CanRedo => currentIndex < history.Count - 1;


        //hàm dọn dẹp bộ nhớ
        public void ClearAll()
        {
            foreach (var bmp in history)
            {
                bmp.Dispose();
            }
            history.Clear();
            currentIndex = -1;
        }
    }
}
