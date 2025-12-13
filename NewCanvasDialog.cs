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
        public int CanvasWidth
        {
            get { return (int)width_num.Value; }
        }

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
