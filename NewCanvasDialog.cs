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
    public partial class NewCanvasDialog : Form
    {

        //hàm trả về độ rộng của canvas mà người dùng đã nhập
        public int CanvasWidth
        {
            get { return (int)width_num.Value; }
        }

        //hàm trả về độ dài của canvas mà người dùng đã nhập
        public int CanvasHeight
        {
            get { return (int)height_num.Value; }
        }

        public NewCanvasDialog()
        {
            InitializeComponent();
        }


    }
}
