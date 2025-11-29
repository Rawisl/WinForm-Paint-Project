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
    public partial class PropertiesPanel : UserControl
    {
        // --- 1. SỰ KIỆN (EVENTS) ---
        public event EventHandler colorChanged;
        public event EventHandler sizeChanged;

        // --- 2. THUỘC TÍNH PUBLIC (DATA) ---
        public Color selectedColor { get; private set; } = Color.Black;
        public float selectedSize { get; private set; } = 2.0f;


        public PropertiesPanel()
        {
            InitializeComponent();
        }
        
        private void PropertiesPanel_Load(object sender, EventArgs e)
        {
            //btnPickColor.BackColor = this.SelectedColor;
        }

        //Nút chọn màu
        private void btnPickColor_Click(object sender, EventArgs e)
        {
            // Mở bảng màu
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                // Cập nhật dữ liệu
                this.selectedColor = colorDialog1.Color;

                // Cập nhật giao diện nút
                btnPickColor.BackColor = this.selectedColor;

                // Bắn tin hiệu ra ngoài cho mainForm biết
                colorChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        //Hàm bắt sự kiện thả chuột khi kéo trên trackBar
        private void trackBar1_MouseUp(object sender, MouseEventArgs e)
        {
            showSize_Label.Text = "Size: " + this.selectedSize;
        }

        //Nút ẩn hiện trackBar
        private void btnTrackbarSize_Click(object sender, EventArgs e)
        {
            //Đảo ngược trạng thái ẩn hiện của trackBar
            trackBar1.Visible = !trackBar1.Visible;
            showSize_Label.Visible = !showSize_Label.Visible;
        }

        //Chỉnh sửa Size cọ bằng cách kéo trackbar 
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            // 1. Cập nhật dữ liệu
            this.selectedSize = (float)trackBar1.Value;

            // 2. BẮN SỰ KIỆN RA NGOÀI
            sizeChanged?.Invoke(this, EventArgs.Empty);
        }


    }
}

