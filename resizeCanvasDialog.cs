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
    public partial class resizeCanvasDialog : Form
    {
        //2 hàm trả về chiều dài và rộng của canvas mà người dùng muốn resize
        public int CanvasHeight
        { get { return (int)height_num.Value; } }
        public int CanvasWidth
        { get { return (int)width_num.Value; } }

        //hiển thị lên kích thước hiện tại của canvas cho người dùng dễ hình dung
        public void setLabel_CurrentSize(int currentWidth, int currentHeight)
        {
            currentSize_label.Text = $"Kích thước hiện tại (Rộng,Cao): {currentWidth}, {currentHeight}";
        }
        public resizeCanvasDialog()
        {
            InitializeComponent();
        }
    }
}
