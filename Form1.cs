using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm_Paint_Gr12
{
    public partial class mainForm : Form
    {
        private Bitmap _mainbitmap; //giấy vẽ chính
        private HistoryManager _historyManager;
        private bool isChanged = false; //tạo cờ đánh dấu giấy đó bị vẽ nét mới lên chưa

        //hàm riêng để tạo tờ giấy vẽ mới
        private void createNewCanvas(int width, int height)
        {
            //nếu đã tồn tại giấy vẽ nào trước thì xóa để giải phóng RAM
            if (_mainbitmap != null)
            {
                _mainbitmap.Dispose();
            }

            //tạo giấy vẽ mới
            _mainbitmap = new Bitmap(width, height);

            //tô full trắng
            using (Graphics g = Graphics.FromImage(_mainbitmap))
            {
                g.Clear(Color.White);
            }

            //gắn giấy vẽ vô ảnh
            pictureBox1.Image = _mainbitmap;
        }

        public mainForm()
        {
            InitializeComponent();

            int defaultWidth = 800;
            int defaultHeight = 400;
            //tạo giấy vẽ mới có kích thước mặc định tự set
            createNewCanvas(defaultWidth, defaultHeight);
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            //system-setup
            //code system ở đây

            //drawing
            //code gdi ở đây

            //ui-layer
            //code ui ở đây     

        }


        //Các phần liên quan đến panel và picturebox
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

        //Các thành phần liên quan đến tác vụ file
        private void file_menu_Click(object sender, EventArgs e)
        {

        }

        private void open_menu_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.png;*.jpg;*.bmp";
            ofd.Title = "Mở ảnh có sẵn";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Mẹo quan trọng: Không mở trực tiếp bằng new Bitmap(filename)
                    // Vì nó sẽ KHÓA cái file ảnh đó lại, không cho save đè lên.

                    // Cách chuẩn: Mở file -> Copy sang Bitmap mới -> Đóng file gốc ngay.
                    using (Bitmap tempImage = new Bitmap(ofd.FileName))
                    {
                        // Tạo tờ giấy mới bằng đúng kích thước ảnh vừa mở
                        createNewCanvas(tempImage.Width, tempImage.Height);

                        // Vẽ ảnh vừa mở lên tờ giấy trắng của mình
                        using (Graphics g = Graphics.FromImage(_mainbitmap))
                        {
                            g.DrawImage(tempImage, 0, 0);
                        }
                    }

                    // Cập nhật lại khung tranh
                    pictureBox1.Image = _mainbitmap;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không mở được file này: " + ex.Message);
                }
                isChanged = false;
            }
            this.Text = System.IO.Path.GetFileName(ofd.FileName) + " - Paint App";
        }

        private void new_menu_Click(object sender, EventArgs e)
        {
            if (isChanged)
            {
                DialogResult res = MessageBox.Show(
                    "Bạn có muốn tạo trang mới không? Hình cũ sẽ mất nếu chưa được lưu!",
                    "Xác nhận",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                // Nếu người dùng chọn "No" (Không muốn mất hình cũ) -> Thoát hàm ngay lập tức
                if (res == DialogResult.No)
                {
                    return;
                }
            }

            using (NewCanvasDialog dlg = new NewCanvasDialog())
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    createNewCanvas(dlg.CanvasWidth, dlg.CanvasHeight);

                    // Xóa lịch sử Undo/Redo (nếu có)
                    // _historyManager.Clear();

                    isChanged = false;
                }
            }
        }

        private void save_menu_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PNG Image|*.png|JPEG Image|*.jpg|Bitmap Image|*.bmp"; //bộ lọc file
            sfd.Title = "Lưu tác phẩm của bạn";
            sfd.FileName = "NewPaint.png"; //tên mặc định

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                // Lấy phần mở rộng file để lưu đúng định dạng
                string ext = System.IO.Path.GetExtension(sfd.FileName).ToLower();
                ImageFormat format = ImageFormat.Png; // Mặc định

                switch (ext)
                {
                    case ".jpg": format = ImageFormat.Jpeg; break;
                    case ".bmp": format = ImageFormat.Bmp; break;
                }

                // Lưu tờ giấy (_mainbitmap) xuống ổ cứng
                _mainbitmap.Save(sfd.FileName, format);
            }
            isChanged = false;
            this.Text = System.IO.Path.GetFileName(sfd.FileName) + " - Paint App";
        }

        private void canvasContainer_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isChanged == false)
            {
                DialogResult res = MessageBox.Show("Bạn chưa lưu file, nếu thoát sẽ mất!", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (res == DialogResult.OK)
                {
                    save_menu_Click(sender, e);
                }
                else if(res == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }

        //private void toolsPanel1_Load(object sender, EventArgs e)
        //{
        //
        //}
    }
}
