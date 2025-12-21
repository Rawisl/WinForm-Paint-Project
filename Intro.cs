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
    public partial class Intro : Form
    {
        public Intro()
        {
            InitializeComponent();
            introTimer.Start(); //bắt đầu đếm
        }

        private void introTimer_Tick(object sender, EventArgs e)
        {
            introTimer.Stop(); //dừng đếm
            this.Close(); //đóng form này
        }
    }
}
