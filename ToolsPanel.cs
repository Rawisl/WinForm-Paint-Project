using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm_Paint_Gr12
{
    public enum ToolType
    {
        Pencil, Brush, Text
    }
    public partial class ToolsPanel : UserControl
    {
        // 1. KHAI BÁO SỰ KIỆN (EVENT)
        public event EventHandler toolChanged;

        // Biến lưu công cụ hiện tại (Public để Form1 đọc được)
        public ToolType currentTool { get; private set; } = ToolType.Pencil;

        public ToolsPanel()
        {
            InitializeComponent();
            //Thiết kế nút, chức năng nút,...
        }

        private void OnToolSelected()
        {
            // 2. KÍCH HOẠT SỰ KIỆN (BẮN TIN)
            toolChanged?.Invoke(this, EventArgs.Empty);
        }

        private void pencilButton_CheckedChanged(object sender, EventArgs e)
        {
            // Chỉ xử lý khi nút được CHỌN (Checked = true)
            // (Vì RadioButton có 2 lần nhảy event: 1 lần bỏ chọn cũ, 1 lần chọn mới)
            if (pencilButton.Checked)
            {
                currentTool = ToolType.Pencil;
                OnToolSelected(); // Báo tin rằng đã đổi tool
            }
        }

        private void brushButton_CheckedChanged(object sender, EventArgs e)
        {
            if (brushButton.Checked)
            {
                currentTool = ToolType.Brush;
                OnToolSelected(); // Báo tin ngay!
            }
        }

        private void textButton_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                currentTool = ToolType.Text;
                OnToolSelected(); // Báo tin rằng đã đổi sang công cụ Text
            }
        }
    }
}
