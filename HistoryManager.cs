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
        private List<Bitmap> history;//tạo một List
        private int currentIndex; //tạo biến để theo dõi index hiện tại nằm trong list
        private int maxHistorySize; //tạo biến chứa maxsize của list để tránh tình trạng tràn RAM

        // Kiểm tra để bật/tắt nút trên giao diện
        public bool CanUndo => currentIndex > 0;
        public bool CanRedo => currentIndex < history.Count - 1;

        public HistoryManager(int maxSize = 20)
        {
            history = new List<Bitmap>();
            currentIndex = -1; //chưa có gì nên set -1
            maxHistorySize = maxSize;
        }

        //Hàm lưu hình ảnh hiện tại
        public void saveSnapshot(Bitmap currentImage)
        {
            // Ví dụ cho ý tưởng: Đang có Bitmap[1, 2, 3, 4], Undo về 2, vẽ nét mới -> Xóa 3, 4 -> Thành [1, 2, Mới]
            if (currentIndex < history.Count - 1)
            {
                for (int i = history.Count - 1; i > currentIndex; i--)
                {
                    history[i].Dispose();
                    history.RemoveAt(i);
                }
            }

            //thêm clone của bitmap hiện tại vào list
            history.Add((Bitmap)currentImage.Clone());
            //tăng biến index
            currentIndex++;

            //trường hợp trong list đã chứa quá 19 bitmap rồi thì bắt đầu xóa từ đầu [0] đi (xóa cái bitmap cũ nhất)
            if (history.Count > maxHistorySize)
            {
                history[0].Dispose();
                history.RemoveAt(0);
                currentIndex--;
            }

        }

        //hàm xử lý undo
        public Bitmap undo(Bitmap currentImage)
        {
            if (currentIndex > 0)
            {
                currentIndex--;
                return (Bitmap)history[currentIndex].Clone();
            }
            return null; //không còn gì để undo
        }

        //hàm xử lý redo
        public Bitmap redo(Bitmap currentImage)
        {
            if (currentIndex < history.Count - 1)
            {
                currentIndex++;
                return (Bitmap)history[currentIndex].Clone();
            }
            return null; //không có gì để redo
        }

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
