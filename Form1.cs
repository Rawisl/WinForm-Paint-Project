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
    public partial class mainForm : Form
    {
        private Bitmap _mainbitmap; //giấy vẽ chính
        public mainForm()
        {
            InitializeComponent();

            //tạo tờ giấy với kích thước bằng kích thước màn hình
            _mainbitmap = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);

            //tô tờ giấy màu trắng (vì mặc định của bitmap là trong suốt)
            using (Graphics g = Graphics.FromImage(_mainbitmap))
            {
                g.Clear(Color.White);
            }
            pictureBox1.Image = _mainbitmap;
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            //system-setup

            /*test push comment - 1*/
            //con me m beo

            //drawing

            //ui-layer

            //Tao moi them dong nay ne

            //Voi dong nay

            //Hello World!!!
        }

        private void propertiesPanel1_Load(object sender, EventArgs e)
        {

        }

        private void toolsPanel1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void statusPanel1_Load(object sender, EventArgs e)
        {

        }

        //private void toolsPanel1_Load(object sender, EventArgs e)
        //{
        //
        //}
    }
}
