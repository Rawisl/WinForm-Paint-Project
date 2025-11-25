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
        }

        private void PropertiesPanel_Load(object sender, EventArgs e)
        {

        }

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

        private void trackBar1_MouseUp(object sender, MouseEventArgs e)
        {
            int value = trackBar1.Value;
            MessageBox.Show("Giá trị hiện tại: " + value);
        }
    }
}

