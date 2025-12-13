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
        public int CanvasHeight
        { get { return (int)height_num.Value; } }
        public int CanvasWidth
        { get { return (int)width_num.Value; } }

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
