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
    public partial class StatusPanel : UserControl
    {
        public StatusPanel()
        {
            InitializeComponent();
            //Thiết kế nút, chức năng nút,...
        }

        //Hàm in ra tọa độ khi di chuyển chuột
        public void UpdateMousePosition(int x, int y)
        {
            //In ra label chứa tọa độ chuột
            lblMousePosition.Text = $"X:{x},Y:{y}";
        }

        //Hàm bắt sự kiện di chuyển chuột trong status panel
        private void StatusPanel_MouseMove(object sender, MouseEventArgs e)
        {
            //Lấy tọa độ chuột truyền vào hàm in
            UpdateMousePosition(e.X, e.Y);
        }
    }
}
