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
        private string currentFilePath = "";//khởi tạo đường dẫn file ban đầu là rỗng

        bool isDrawing = false;
        Point lastPoint;

        ToolType currentTool = ToolType.Pencil;
        Color currentColor = Color.Black;
        float currentSize = 1.0f;
        float sizeBrush = 2.0f;


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

        //hàm riêng để lưu file xuống đường dẫn filePath
        private void saveImages(string path)
        {
            string ext = System.IO.Path.GetExtension(path).ToLower(); //lấy phần đuôi định dạng của file
            ImageFormat format = ImageFormat.Png; //mặc định lưu dưới dạng png
            switch (ext)
            {
                case ".jpg":
                case ".jpeg":
                    format = ImageFormat.Jpeg;
                    break;
                case ".bmp":
                    format = ImageFormat.Bmp;
                    break;
            }
            //lưu ảnh
            _mainbitmap.Save(path, format);

            //cập nhật trạng thái
            currentFilePath = path; //lưu thành đường dẫn mới
            isChanged = false; //lưu xong thì set lại cờ thay đổi

            this.Text = System.IO.Path.GetFileName(path) + " - Paint App";
        }

        //Các hàm xử lý thay đổi từ màu, size từ properties panel
        private void propertiesPanel1_colorChanged(object sender, EventArgs e)
        {
            // Cập nhật biến màu cục bộ ngay lập tức
            this.currentColor = propertiesPanel1.selectedColor;
        }

        private void propertiesPanel1_sizeChanged(object sender, EventArgs e)
        {
            // Cập nhật biến size cục bộ ngay lập tức
            this.currentSize = propertiesPanel1.selectedSize;
        }

        //Hàm xử lý thay đổi công cụ từ tools panel
        private void toolsPanel1_toolChanged(object sender, EventArgs e)
        {
            this.currentTool = toolsPanel1.currentTool;
        }

        public mainForm()
        {
            InitializeComponent();

            int defaultWidth = 800;
            int defaultHeight = 400;
            //tạo giấy vẽ mới có kích thước mặc định tự set
            createNewCanvas(defaultWidth, defaultHeight);

            // --- ĐẤU DÂY SỰ KIỆN (QUAN TRỌNG) ---
            // Khi propertiesPanel1 hét lên "ColorChanged", chạy hàm PropertiesPanel1_ColorChanged
            if (propertiesPanel1 != null)
            {
                propertiesPanel1.colorChanged += propertiesPanel1_colorChanged;
                propertiesPanel1.sizeChanged += propertiesPanel1_sizeChanged;
            }

            // Tương tự cho ToolsPanel của Đức nếu có
            if (toolsPanel1 != null)
            {
                toolsPanel1.toolChanged += toolsPanel1_toolChanged;
            }
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

                    currentFilePath = ofd.FileName;
                    this.Text = System.IO.Path.GetFileName(currentFilePath) + " - Paint App";
                    isChanged = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không mở được file này: " + ex.Message);
                }
            }

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
                    currentFilePath = "";
                    this.Text = "NewPaint - Paint App";
                    isChanged = false;
                }
            }

        }

        private void save_menu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(currentFilePath))
            {
                saveAsMenu_Click(sender, e); //nếu chuỗi đường dẫn trống hoặc null thì lưu mới bằng cách gọi hàm saveAs
            }
            else
            {
                saveImages(currentFilePath); //đã tồn tại đường dẫn thì lưu đè, không cần hỏi lại
            }
        }
        private void saveAsMenu_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PNG Image|*.png|JPEG Image|*.jpg|Bitmap Image|*.bmp"; //bộ lọc file
            sfd.Title = "Lưu tác phẩm của bạn";
            sfd.FileName = "NewPaint.png"; //tên mặc định
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                saveImages(sfd.FileName);
            }
        }
        private void canvasContainer_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Chỉ hỏi khi hình CÓ thay đổi
            if (isChanged == true)
            {
                DialogResult res = MessageBox.Show(
                    "Hình chưa được lưu. Bạn có muốn lưu trước khi thoát không?",
                    "Cảnh báo",
                    MessageBoxButtons.YesNoCancel, // Phải dùng 3 nút: Yes, No, Cancel
                    MessageBoxIcon.Warning);

                if (res == DialogResult.Yes)
                {
                    // Bấm Yes -> Lưu file -> Sau đó để Form tự đóng
                    save_menu_Click(sender, e);
                }
                else if (res == DialogResult.Cancel)
                {
                    // Bấm Cancel -> Hủy lệnh đóng form -> Ở lại
                    e.Cancel = true;
                }
                // Nếu bấm No -> Không làm gì cả -> Form tự đóng (Mất hình cũ, đúng ý người dùng)
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDrawing = true;
                lastPoint = e.Location; // cập nhật vị trí điểm vẽ lúc đó
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            //cập nhật tọa độ chuột cho status panel 
            if(statusPanel1 != null)
                statusPanel1.updateMousePosition(e.X,e.Y);

            if (isDrawing)
            {
                // Tạo Graphics từ tờ giấy chính (_mainbitmap)
                using (Graphics g = Graphics.FromImage(_mainbitmap)) //không dùng using thì dùng dispose cũng được, mà dùng using cho tiện
                {
                    // Áp dụng khử răng cưa cho nét vẽ mượt (tùy chọn)
                    g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                    // Gọi logic vẽ của Đức
                    if (currentTool == ToolType.Pencil)
                    {
                        // Pencil thường không khử răng cưa và size nhỏ (1px)
                        g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
                        DrawingLogic.DrawPencil(g, lastPoint, e.Location, currentColor,currentSize);
                    }
                    else if (currentTool == ToolType.Brush)
                    {
                        //Brush thì áp dụng antialias để nhìn nét cho mềm
                        g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                        DrawingLogic.DrawBrush(g, lastPoint, e.Location, currentColor, currentSize);
                    }
                    // Các hình học khác (Line, Rect) sẽ xử lý khác (vẽ preview), chưa làm ở đây
                }

                lastPoint = e.Location; // Cập nhật vị trí cũ
                pictureBox1.Invalidate(); // Yêu cầu PictureBox vẽ lại tờ giấy ra màn hình
                isChanged = true; // Đánh dấu là hình đã thay đổi
            }

        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            isDrawing = false;
        }



        //private void toolsPanel1_Load(object sender, EventArgs e)
        //{
        //
        //}
    }
}
