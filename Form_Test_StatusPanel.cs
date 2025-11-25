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
    public partial class Form_Test_StatusPanel : Form
    {
        public Form_Test_StatusPanel()
        {
            InitializeComponent();
            //Dùng để kéo 2 StatusPanel.cs và PropertiesPanel.cs về để test.

            //Bắt sự kiện di chuyển chuột khi chuột đi vào PropertiesPanel
            propertiesPanel1.MousePositionChanged += PropertiesPanel_MousePositionChanged;
        }

        //Hàm bắt sự kiện di chuyển chuột trong form và status panel
        private void Form_Test_StatusPanel_MouseMove(object sender, MouseEventArgs e)
        {
            //Gọi hàm của StatusPanel.cs và truyền tọa độ của chuột vào hàm
            statusPanel1.updateMousePosition(e.X, e.Y);
        }

        //Hàm bắt sự kiện di chuyển chuột trong Properties panel
        private void PropertiesPanel_MousePositionChanged(object sender, Point p)
        {
            // Gọi StatusPanel để cập nhật khi chuột đang ở trong PropertiesPanel
            statusPanel1.updateMousePosition(p.X, p.Y);
        }
    }
}
