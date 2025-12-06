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
        //tạo ngăn xếp để chứa lịch sử
        private Stack<Bitmap> undoStack = new Stack<Bitmap>();
        private Stack<Bitmap> redoStack = new Stack<Bitmap>();


        //viết hàm lưu hình ảnh hiện tại
        public void saveSnapshot(Bitmap currentImage)
        {
            //đẩy clone của hình ảnh hiện tại vào trong undo
            undoStack.Push((Bitmap)currentImage.Clone());

            clearRedoStack();
        }

        //thực hiện undo
        public Bitmap undo(Bitmap currentImage)
        {
            if (undoStack.Count > 0)
            {
                //cất ảnh hiện tại vào redo
                redoStack.Push((Bitmap)currentImage.Clone());

                //lấy ảnh cũ ra để trả về
                return undoStack.Pop();
            }
            return null; //không còn gì để undo
        }

        //thực hiện redo
        public Bitmap redo(Bitmap currentImage)
        {
            if (redoStack.Count > 0)
            {
                //cất ảnh hiện tại vào undo
                undoStack.Push((Bitmap)currentImage.Clone());

                //lấy ảnh tương lai ra trả về
                return redoStack.Pop();
            }
            return null; //không có gì để redo
        }

        // Hàm kiểm tra để bật/tắt nút (Enable/Disable buttons)
        public bool CanUndo => undoStack.Count > 0;
        public bool CanRedo => redoStack.Count > 0;

        //hàm dọn dẹp bộ nhớ
        private void clearRedoStack()
        {
            foreach (var bmp in redoStack)
            {
                bmp.Dispose(); //dispose để giải phóng RAM
            }
            redoStack.Clear();
        }

        public void ClearAll()
        {
            foreach (var bmp in undoStack) bmp.Dispose();
            undoStack.Clear();
            clearRedoStack();
        }
    }
}
