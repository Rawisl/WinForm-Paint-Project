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
        public PropertiesPanel()
        {
            InitializeComponent();

            //Bắt mousemove
            this.MouseMove += PropertiesPanel_MouseMove;
        }

        public event EventHandler<Point> MousePositionChanged;

        private void PropertiesPanel_Load(object sender, EventArgs e)
        {

        }

        //Nút chọn màu
        private void btnPickColor_Click(object sender, EventArgs e)
        {
            //Mở cửa sổ để chọn màu
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                //Người dùng sẽ chọn màu
                Color selectedColor = colorDialog1.Color;

                //Cập nhật màu lại cho nút bấm (do chưa có đối tượng để cập nhật màu)
                btnPickColor.BackColor = selectedColor;
            }
        }

        //Hàm bắt sự kiện thả chuột khi kéo trên trackBar
        private void trackBar1_MouseUp(object sender, MouseEventArgs e)
        {
            //Lưu giá trị của trackbar rồi in ra
            int value = trackBar1.Value;
            MessageBox.Show("Giá trị hiện tại: " + value);
        }

        //Bắt tọa độ khi di chuyển chuột vào PropertiesPanel
        private void PropertiesPanel_MouseMove(object sender, MouseEventArgs e)
        {
            // Gửi tọa độ ra form_test
            MousePositionChanged?.Invoke(this, new Point(e.X, e.Y));
        }

        //Nút ẩn hiện trackBar
        private void btnTrackbarSize_Click(object sender, EventArgs e)
        {
            //Đảo ngược trạng thái ẩn hiện của trackBar
            trackBar1.Visible = !trackBar1.Visible;
        }
    }
}

