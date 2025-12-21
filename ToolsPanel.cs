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
    //Khai báo enum tooltype để quản lý
    public enum ToolType
    {
        Eraser, Pencil, Brush, Text, Line, Rectangle, Oval, Triangle, Fill, ColorPicker, Properties
    }
    public partial class ToolsPanel : UserControl
    {
        //KHAI BÁO SỰ KIỆN
        public event EventHandler toolChanged;

        // Sự kiện ẩn hiện propertiesPanel
        public event EventHandler propertiesToggled;

        // Biến lưu công cụ hiện tại (Public để Form1 đọc được)
        public ToolType currentTool { get; private set; } = ToolType.Pencil;

        public ToolsPanel()
        {
            InitializeComponent();
            //Thiết kế nút, chức năng nút,...
        }

        private void OnToolSelected()
        {
            //KÍCH HOẠT SỰ KIỆN
            toolChanged?.Invoke(this, EventArgs.Empty);
        }

        // Hàm kích hoạt sự kiện Properties
        private void OnPropertiesToggled()
        {
            propertiesToggled?.Invoke(this, EventArgs.Empty);
        }

        //Hàm xử lý chọn tẩy
        private void eraserButton_CheckedChanged(object sender, EventArgs e)
        {
            // Chỉ xử lý khi nút được CHỌN (Checked = true)
            // (Vì RadioButton có 2 lần nhảy event: 1 lần bỏ chọn cũ, 1 lần chọn mới)
            if (eraserButton.Checked)
            {
                currentTool = ToolType.Eraser;
                OnToolSelected();
            }
        }

        //Hàm xử lý chọn bút chì
        private void pencilButton_CheckedChanged(object sender, EventArgs e)
        {
            if (pencilButton.Checked)
            {
                currentTool = ToolType.Pencil;
                OnToolSelected(); // Báo tin rằng đã đổi tool
            }
        }

        //Hàm xử lý chọn cọ
        private void brushButton_CheckedChanged(object sender, EventArgs e)
        {
            if (brushButton.Checked)
            {
                currentTool = ToolType.Brush;
                OnToolSelected(); // Báo tin
            }
        }

        //Hàm xử lý chọn textbox
        private void textButton_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                currentTool = ToolType.Text;
                OnToolSelected(); // Báo tin rằng đã đổi sang công cụ Text
            }
        }

        //Hàm xử lý chọn line
        private void lineButton_CheckedChanged(object sender, EventArgs e)
        {
            if (lineButton.Checked)
            {
                currentTool = ToolType.Line;
                OnToolSelected();
            }
        }

        //Hàm xử lý chọn hình chữ nhật
        private void rectangleButton_CheckedChanged(object sender, EventArgs e)
        {
            if (rectangleButton.Checked)
            {
                currentTool = ToolType.Rectangle;
                OnToolSelected();
            }
        }

        //Hàm xử lý chọn hình ellipse
        private void ellipseButton_CheckedChanged(object sender, EventArgs e)
        {
            if (ellipseButton.Checked)
            {
                currentTool = ToolType.Oval;
                OnToolSelected();
            }
        }

        //Hàm xử lý chọn hình tam giác
        private void triangleButton_CheckedChanged(object sender, EventArgs e)
        {
            if (triangleButton.Checked)
            {
                currentTool = ToolType.Triangle;
                OnToolSelected();
            }
        }

        //Hàm xử lý chọn fill màu
        private void fillButton_CheckedChanged(object sender, EventArgs e)
        {
            if (fillButton.Checked)
            {
                currentTool = ToolType.Fill;
                OnToolSelected();
            }
        }

        //Hàm xử lý chọn hình colorpicker
        private void colorpickerButton_CheckedChanged(object sender, EventArgs e)
        {
            if(colorpickerButton.Checked)
            {
                currentTool = ToolType.ColorPicker;
                OnToolSelected();
            }
        }
        
        //Hàm xử lý khi click vào nút thu phóng properties panel
        private void PropertiesButton_Click(object sender, EventArgs e)
        {
            //Kích hoạt sự kiện Toggled
            OnPropertiesToggled();
        }
    }
}
