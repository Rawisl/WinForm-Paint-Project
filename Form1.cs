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
        private HistoryManager historyManager;
        private bool isChanged = false; //tạo cờ đánh dấu giấy đó bị vẽ nét mới lên chưa
        private string currentFilePath = "";//khởi tạo đường dẫn file ban đầu là rỗng

        bool isDrawing = false;
        Point firstPoint; // dùng cho hình học, cần có điểm đầu tiên
        Point lastPoint;

        ToolType currentTool = ToolType.Pencil;
        Color currentColor = Color.Black;
        float currentSize = 1.0f;
        float sizeBrush = 2.0f;

        // Biến theo dõi trạng thái Text Tool
        private bool isDrawingTextBounds = false; // Cờ báo đang vẽ vùng Text
        private Point startPoint;              // Điểm bắt đầu kéo chuột
        private Rectangle textBounds;          // Vùng hình chữ nhật đã kéo

        // Đối tượng TextBox tạm thời
        private TextBox activeTextBox = null;  // TextBox đang được người dùng nhập liệu/thao tác

        // Biến cho tính năng Paste
        private Bitmap pastedImage = null; // Chứa ảnh lấy từ Clipboard
        private Point pasteLocation;       // Vị trí để vẽ ảnh preview

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

            historyManager.ClearAll();
            historyManager.saveSnapshot(_mainbitmap);
            //gắn giấy vẽ vô ảnh
            pictureBox1.Image = _mainbitmap;
            updateUnReButton();
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

        //hàm riêng để xử lý resize
        private void resizeCanvas(int newWidth, int newHeight)
        {
            //lưu vô lịch sử để lỡ resize lộn size còn undo được
            if (historyManager != null)
            {
                historyManager.saveSnapshot(_mainbitmap);
            }
            //tạo giấy mới
            Bitmap newCanvas = new Bitmap(newWidth, newHeight);

            using (Graphics g = Graphics.FromImage(newCanvas))
            {
                //tô nền trắng cho giấy mới
                g.Clear(Color.White);
                //vẽ lại hình cũ vô giấy mới
                if (_mainbitmap != null)
                    g.DrawImage(_mainbitmap, 0, 0);
            }

            //xóa giấy cũ để giải phóng RAM
            if (_mainbitmap != null)
                _mainbitmap.Dispose();

            //gán giấy mới vào thành bitmap chính
            _mainbitmap = newCanvas;
            pictureBox1.Image = _mainbitmap;

            //đánh dấu là đã bị thay đổi
            isChanged = true;
        }

        //hàm riêng để xử lý trạng thái của 2 nút undo/redo
        private void updateUnReButton()
        {
            if (historyManager != null)
            {
                //còn undo được thì bật nút undo, tương tự với redo
                quickUndoButton.Enabled = historyManager.CanUndo;
                quickRedoButton.Enabled = historyManager.CanRedo;
            }
        }

        //hàm riêng để xử lý vẽ, tránh bị lặp code ở sự kiện paint và mouseup
        private void processDrawing(Graphics g, Point firstPoint, Point lastPoint, ToolType currentTool)
        {
            // Khai báo biến bool dùng để kiểm tra phím Shift
            bool isShiftDown = (Control.ModifierKeys & Keys.Shift) == Keys.Shift;

            // dùng if else ở đây là để tách hình học với pencil, brush ra riêng không bị dính vào nhau
            if (currentTool == ToolType.Line)
                DrawingLogic.DrawLine(g, firstPoint, lastPoint, currentColor, currentSize);
            else if (currentTool == ToolType.Rectangle)
            {
                if (isShiftDown)
                {
                    Rectangle rectange = DrawingLogic.GetPerfectShape(firstPoint, lastPoint);
                    DrawingLogic.DrawRectangle(g, rectange, currentColor, currentSize);
                }
                else
                {
                    Rectangle rectangle = DrawingLogic.GetRectangle(firstPoint, lastPoint);
                    DrawingLogic.DrawRectangle(g, rectangle, currentColor, currentSize);
                }
            }
            else if (currentTool == ToolType.Oval)
            {
                if (isShiftDown)
                {
                    Rectangle rectange = DrawingLogic.GetPerfectShape(firstPoint, lastPoint);
                    DrawingLogic.DrawEllipse(g, rectange, currentColor, currentSize);
                }
                else
                {
                    Rectangle rectangle = DrawingLogic.GetRectangle(firstPoint, lastPoint);
                    DrawingLogic.DrawEllipse(g, rectangle, currentColor, currentSize);
                }
            }
            else if (currentTool == ToolType.Triangle)
            {
                if (isShiftDown)
                {
                    // --- LOGIC TAM GIÁC ĐỀU ---

                    // 1. Lấy cạnh dựa trên khoảng cách kéo chuột theo chiều ngang
                    int width = Math.Abs(lastPoint.X - firstPoint.X);

                    // 2. Tính chiều cao theo công thức tam giác đều (h = a * căn 3 / 2)
                    // 0.866 chính là căn 3 chia 2
                    int height = (int)(width * 0.866f);

                    // 3. Xác định tọa độ góc trái trên (để vẽ được mọi hướng)
                    int x = Math.Min(firstPoint.X, lastPoint.X);
                    int y = Math.Min(firstPoint.Y, lastPoint.Y);

                    // 4. Tạo hình chữ nhật có tỉ lệ chuẩn tam giác đều
                    Rectangle triRect = new Rectangle(x, y, width, height);

                    // 5. Vẽ
                    DrawingLogic.DrawTriangle(g, triRect, currentColor, currentSize);
                }
                else
                {
                    Rectangle rectangle = DrawingLogic.GetRectangle(firstPoint, lastPoint);
                    DrawingLogic.DrawTriangle(g, rectangle, currentColor, currentSize);
                }
            }
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
            //Cập nhật biến Tooltype cục bộ
            this.currentTool = toolsPanel1.currentTool;

            //Gọi CursorManager để lấy con trỏ phù hợp và gán cho pictureBox1
            pictureBox1.Cursor = CursorManager.GetCursor(this.currentTool);

            //Cập nhật lại con trỏ ngay lập tức
            pictureBox1.Invalidate();
        }

        public mainForm()
        {
            InitializeComponent();

            //khởi tạo bộ nhớ undo/redo
            historyManager = new HistoryManager();

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
                propertiesPanel1.FontChanged += propertiesPanel1_FontChanged;
            }

            // Tương tự cho ToolsPanel của Đức nếu có
            if (toolsPanel1 != null)
            {
                toolsPanel1.toolChanged += toolsPanel1_toolChanged;

                // Đấu dây sự kiện Properties Toggled
                toolsPanel1.propertiesToggled += toolsPanel1_propertiesToggled;

                //Gọi hàm xử lý sự kiện để thiết lập con trỏ dựa trên ToolType mặc định
                toolsPanel1_toolChanged(this, EventArgs.Empty);
            }
        }

        // Hàm xử lý sự kiện PropertiesPanel Toggled
        private void toolsPanel1_propertiesToggled(object sender, EventArgs e)
        {
            // Đảo ngược trạng thái Visible của propertiesPanel1
            if (propertiesPanel1 != null)
            {
                propertiesPanel1.Visible = !propertiesPanel1.Visible;
                separatorPanel.Visible = !separatorPanel.Visible;
            }
        }

        private void mainForm_Load(object sender, EventArgs e)
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

                    //giải phóng RAM bằng cách xóa sạch lịch sử bên canvas cũ
                    historyManager.ClearAll();

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
            // Nếu đang ở chế độ Paste và bấm chuột trái
            if (pastedImage != null && e.Button == MouseButtons.Left)
            {
                // 1. In thật xuống giấy
                using (Graphics g = Graphics.FromImage(_mainbitmap))
                {
                    g.DrawImage(pastedImage, pasteLocation);
                }

                // 2. Lưu lịch sử Undo (Quan trọng)
                historyManager.saveSnapshot(_mainbitmap);
                updateUnReButton();

                // 3. Dọn dẹp: Hủy ảnh tạm
                pastedImage.Dispose();
                pastedImage = null;

                // 4. Reset trạng thái
                pictureBox1.Cursor = CursorManager.GetCursor(currentTool); // Trả lại con trỏ cũ
                pictureBox1.Invalidate();
                isChanged = true;

                return; // Return để không bị vẽ chấm mực dính vào
            }
            if (e.Button == MouseButtons.Left)
            {

                if (currentTool == ToolType.Text) // Xử lý Text Tool
                {
                    // Nếu đã có TextBox đang hoạt động, không làm gì cả
                    if (activeTextBox != null) return;

                    // Bắt đầu vẽ vùng Text
                    isDrawingTextBounds = true;
                    startPoint = e.Location;
                    // Đặt lại textBounds để bắt đầu vẽ vùng mới
                    textBounds = new Rectangle(e.Location, new Size(0, 0));

                    // Đảm bảo không kích hoạt logic vẽ khác khi đang ở chế độ Text
                    isDrawing = false;
                }
                else if(currentTool == ToolType.ColorPicker) //logic nếu chọn pick màu
                {
                    //Phải đảm bảo tọa độ click nằm trong canvas
                    if(e.X >= 0 && e.X < _mainbitmap.Width && e.Y >= 0 && e.Y < _mainbitmap.Height)
                    {
                        //lấy màu tại pixel đó
                        Color pickedColor = _mainbitmap.GetPixel(e.X, e.Y);
                        //cập nhật lại màu       
                        currentColor = pickedColor;
                        //cập nhật lại giao diện của cái nút hiện màu trong properties panel
                        propertiesPanel1.UpdateColor(pickedColor);

                    }
                    return;
                }
                else // Logic cho Pencil/Brush/Khác
                {
                    // Dừng Text Tool nếu nó đang hoạt động
                    CleanupActiveTextBox();

                    isDrawing = true;
                    firstPoint = e.Location;
                    lastPoint = e.Location; // cập nhật vị trí điểm vẽ lúc đó
                }
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (pastedImage != null)
            {
                // Cập nhật vị trí ảnh (để tâm ảnh nằm ngay con chuột)
                pasteLocation = new Point(e.X - pastedImage.Width / 2, e.Y - pastedImage.Height / 2);

                pictureBox1.Invalidate(); // Vẽ lại liên tục để ảnh chạy theo
                return; // Quan trọng: Return luôn để không dính logic vẽ hình khác
            }

            //cập nhật tọa độ chuột cho status panel 
            if (statusPanel1 != null)
                statusPanel1.updateMousePosition(e.X, e.Y);

            bool isShiftDown = (Control.ModifierKeys & Keys.Shift) == Keys.Shift;

            if (isDrawingTextBounds) // Đang vẽ vùng Text (Preview)
            {
                // Cập nhật kích thước vùng chọn (vùng chữ nhật)
                int x = Math.Min(startPoint.X, e.X);
                int y = Math.Min(startPoint.Y, e.Y);
                int width = Math.Abs(startPoint.X - e.X);
                int height = Math.Abs(startPoint.Y - e.Y);
                textBounds = new Rectangle(x, y, width, height);

                // Yêu cầu PictureBox vẽ lại để hiển thị khung chữ nhật preview cho Text
                pictureBox1.Invalidate();
            }

            else if (isDrawing)
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
                        DrawingLogic.DrawPencil(g, lastPoint, e.Location, currentColor, currentSize);
                    }
                    else if (currentTool == ToolType.Brush)
                    {
                        //Brush thì áp dụng antialias để nhìn nét cho mềm
                        g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                        DrawingLogic.DrawBrush(g, lastPoint, e.Location, currentColor, currentSize);
                    }
                    else if (currentTool == ToolType.Eraser)
                    {
                        DrawingLogic.DrawEraser(g, lastPoint, e.Location, currentSize * 10);
                        //để size = 10 vì tẩy lúc nào cũng nên to hơn cọ
                    }
                    // Các hình học khác (Line, Rect) sẽ xử lý khác (vẽ preview), chưa làm ở đây
                    else if (currentTool == ToolType.Line)
                    {

                    }
                    else if (currentTool == ToolType.Rectangle)
                    {

                    }
                    else if (currentTool == ToolType.Oval)
                    {

                    }
                    else if (currentTool == ToolType.Triangle)
                    {

                    }

                }

                lastPoint = e.Location; // Cập nhật vị trí cũ
                pictureBox1.Invalidate(); // Yêu cầu PictureBox vẽ lại tờ giấy ra màn hình
                isChanged = true; // Đánh dấu là hình đã thay đổi

            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {

            if (isDrawingTextBounds)
            {
                isDrawingTextBounds = false; // Kết thúc chế độ vẽ vùng

                // Đảm bảo kích thước tối thiểu
                if (textBounds.Width >= 10 && textBounds.Height >= 10)
                {
                    // 1. Khởi tạo TextBox mới
                    activeTextBox = new TextBox();
                    activeTextBox.Multiline = true;
                    activeTextBox.Bounds = textBounds;
                    activeTextBox.BorderStyle = BorderStyle.FixedSingle;

                    // 2. Gán Font và Màu từ PropertiesPanel
                    activeTextBox.Font = propertiesPanel1.selectedFont;
                    activeTextBox.ForeColor = propertiesPanel1.selectedColor;

                    // 3. Thêm sự kiện để xử lý khi người dùng nhập xong
                    activeTextBox.LostFocus += ActiveTextBox_LostFocus;
                    activeTextBox.KeyDown += ActiveTextBox_KeyDown;

                    // 4. Thêm TextBox vào PictureBox và focus vào nó
                    pictureBox1.Controls.Add(activeTextBox);
                    activeTextBox.Focus();
                    isChanged = true; // Đánh dấu là đã thay đổi (bắt đầu nhập text)
                }
                else
                {
                    textBounds = Rectangle.Empty; // Vùng quá nhỏ, reset
                }

                // Vẽ lại để xóa khung chữ nhật preview
                pictureBox1.Invalidate();
                return;
            }
            if (isDrawing)
            {
                isDrawing = false;
                //// === THÊM ĐOẠN NÀY ĐỂ IN HÌNH CHÍNH THỨC VÀO GIẤY ===
                if (currentTool == ToolType.Line || currentTool == ToolType.Rectangle || currentTool == ToolType.Oval || currentTool == ToolType.Triangle)
                    // dùng if else ở đây là để tách hình học với pencil, brush ra riêng không bị dính vào nhau
                    using (Graphics g = Graphics.FromImage(_mainbitmap))
                    {
                        processDrawing(g, firstPoint, e.Location, currentTool);
                    }
            }
            //lưu ảnh hiện tại vào lịch sử
            historyManager.saveSnapshot(_mainbitmap);
            //cập nhật trạng thái nút undo redo
            updateUnReButton();
            // Logic chung cho các công cụ vẽ khác
            pictureBox1.Invalidate();
            isChanged = true;
        }


        private void propertiesPanel1_FontChanged(object sender, EventArgs e)
        {
            // Cập nhật Font và Màu cho TextBox đang hoạt động ngay lập tức (nếu có)
            if (activeTextBox != null)
            {
                // Lấy Font đã được cập nhật (bao gồm Bold/Italic/Underline) từ PropertiesPanel
                activeTextBox.Font = propertiesPanel1.selectedFont;
                activeTextBox.ForeColor = propertiesPanel1.selectedColor;
            }
        }

        // --- CÁC HÀM XỬ LÝ TEXTBOX ĐỘNG ---

        // Hàm dọn dẹp chung để xóa TextBox và reset trạng thái
        private void CleanupActiveTextBox()
        {
            if (activeTextBox != null)
            {
                // Gỡ các sự kiện
                activeTextBox.LostFocus -= ActiveTextBox_LostFocus;
                activeTextBox.KeyDown -= ActiveTextBox_KeyDown;

                // Gỡ và hủy đối tượng
                pictureBox1.Controls.Remove(activeTextBox);
                activeTextBox.Dispose();
                activeTextBox = null;
                textBounds = Rectangle.Empty; // Reset vùng
            }
        }

        // Xử lý khi TextBox mất focus (Người dùng click ra ngoài)
        private void ActiveTextBox_LostFocus(object sender, EventArgs e)
        {
            // Đảm bảo chỉ xử lý khi TextBox là đối tượng đang bị mất focus
            if (activeTextBox == null || activeTextBox != sender) return;

            // Nếu có văn bản, thực hiện vẽ cố định
            if (!string.IsNullOrEmpty(activeTextBox.Text))
            {
                // 1. Lấy Graphics từ tờ giấy chính (_mainbitmap)
                using (Graphics g = Graphics.FromImage(_mainbitmap))
                {
                    // Cài đặt chất lượng Text
                    g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;

                    // Tạo SolidBrush với màu văn bản
                    using (SolidBrush brush = new SolidBrush(activeTextBox.ForeColor))
                    {
                        // 2. Vẽ chuỗi văn bản lên _mainbitmap
                        g.DrawString(
                            activeTextBox.Text,
                            activeTextBox.Font,
                            brush,
                            activeTextBox.Location.X,
                            activeTextBox.Location.Y
                        );
                    }
                    historyManager.saveSnapshot(_mainbitmap);
                }
            }
            // Dọn dẹp và xóa TextBox tạm thời
            CleanupActiveTextBox();
            // Yêu cầu PictureBox vẽ lại để hiển thị văn bản cố định
            pictureBox1.Invalidate();
        }

        // Xử lý phím Enter/Esc để kết thúc nhập liệu
        private void ActiveTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            // Bấm ESC để kết thúc nhập liệu và chuyển sang trạng thái LostFocus
            if (e.KeyCode == Keys.Escape)
            {
                // Khi bấm ESC, ép PictureBox focus để kích hoạt sự kiện LostFocus
                pictureBox1.Focus();
                e.SuppressKeyPress = true; // Ngăn không cho ký tự ESC xuất hiện trong TextBox
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            // Vẽ Bitmap chính
            if (_mainbitmap != null)
            {
                e.Graphics.DrawImage(_mainbitmap, 0, 0);
            }

            // Vẽ cái ảnh đang trong clipboard vô canvas
            if(pastedImage != null)
            {
                //vẽ ảnh tại vị trí chuột
                e.Graphics.DrawImage(pastedImage, pasteLocation);

                // Vẽ thêm cái khung nét đứt bao quanh cho người dùng dễ căn chỉnh
                using (Pen dashPen = new Pen(Color.Blue, 1))
                {
                    dashPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                    e.Graphics.DrawRectangle(dashPen, pasteLocation.X, pasteLocation.Y, pastedImage.Width, pastedImage.Height);
                }
            }

            // Vẽ khung chữ nhật preview cho Text Tool khi đang kéo
            if (isDrawingTextBounds && currentTool == ToolType.Text)
            {
                using (Pen dashedPen = new Pen(Color.Gray, 1) { DashPattern = new float[] { 5, 5 } })
                {
                    e.Graphics.DrawRectangle(dashedPen, textBounds);
                }
            }

            //Thêm code logic vẽ review Line, Rectangle trong tương lai
            if (isDrawing)
            {
                processDrawing(e.Graphics, firstPoint, lastPoint, currentTool);
                // 1. Kiểm tra xem có đang dùng công cụ hình học không
                if (currentTool == ToolType.Rectangle || currentTool == ToolType.Oval ||
                    currentTool == ToolType.Triangle)
                {
                    // 2. Kiểm tra xem người dùng ĐÃ bấm Shift chưa
                    bool isShift = (Control.ModifierKeys & Keys.Shift) == Keys.Shift;

                    // Chỉ hiện thông báo nếu CHƯA bấm Shift
                    if (!isShift)
                    {
                        string hintText = "Giữ Shift để vẽ hình đều";

                        // Cài đặt font chữ và màu sắc cho thông báo
                        using (Font font = new Font("Arial", 8))
                        using (SolidBrush brush = new SolidBrush(Color.Gray))
                        using (SolidBrush bgBrush = new SolidBrush(Color.FromArgb(200, 255, 255, 255))) // Nền trắng mờ
                        {
                            // Vị trí vẽ: Lệch sang phải và xuống dưới con chuột một chút
                            // lastPoint chính là vị trí chuột hiện tại trong sự kiện Paint
                            Point textPos = new Point(lastPoint.X + 15, lastPoint.Y + 15);

                            // Vẽ nền mờ bên dưới chữ cho dễ đọc (Tùy chọn)
                            SizeF textSize = e.Graphics.MeasureString(hintText, font);
                            e.Graphics.FillRectangle(bgBrush, textPos.X, textPos.Y, textSize.Width, textSize.Height);

                            // Vẽ chữ
                            e.Graphics.DrawString(hintText, font, brush, textPos);
                        }
                    }
                }
            }


        }
        private void quickRedoButton_Click(object sender, EventArgs e)
        {
            Bitmap futureImage = historyManager.redo(_mainbitmap);
            if (futureImage != null)
            {
                if (_mainbitmap != null) _mainbitmap.Dispose();

                _mainbitmap = futureImage;
                pictureBox1.Image = _mainbitmap;
                pictureBox1.Invalidate();
                updateUnReButton();
            }

        }
        private void quickUndoButton_Click(object sender, EventArgs e)
        {
            // Gọi hàm Undo, nó sẽ trả về bức ảnh cũ (nếu có)
            Bitmap oldImage = historyManager.undo(_mainbitmap);

            if (oldImage != null)
            {
                // Thay thế ảnh hiện tại bằng ảnh cũ
                // Nhớ Dispose ảnh hiện tại để tránh rò rỉ RAM trước khi gán cái mới
                if (_mainbitmap != null) _mainbitmap.Dispose();

                _mainbitmap = oldImage;
                pictureBox1.Image = _mainbitmap; // Cập nhật lên khung tranh
                pictureBox1.Invalidate(); // Vẽ lại ngay
                updateUnReButton();
            }

            // 3. Dọn dẹp và xóa TextBox tạm thời
            CleanupActiveTextBox();

            // Yêu cầu PictureBox vẽ lại để hiển thị văn bản cố định
            pictureBox1.Invalidate();

        }
        private void mainForm_KeyDown(object sender, KeyEventArgs e)
        {
            // 1. Xử lý Paste (Ctrl + V)
            if (e.Control && e.KeyCode == Keys.V)
            {
                // Kiểm tra xem trong Clipboard có chứa ảnh không
                if (Clipboard.ContainsImage())
                {
                    // Lấy ảnh từ Clipboard ra
                    Image img = Clipboard.GetImage();

                    // Chuyển sang Bitmap để dễ xử lý (và dispose cái cũ nếu có)
                    if (pastedImage != null) pastedImage.Dispose();
                    pastedImage = new Bitmap(img);

                    // Tạm dừng việc vẽ vời linh tinh khác
                    isDrawing = false;

                    // Đổi con trỏ chuột thành hình 4 mũi tên cho dễ nhận biết
                    pictureBox1.Cursor = Cursors.SizeAll;

                    // Trigger vẽ lại để hiện ảnh lên
                    pictureBox1.Invalidate();
                }
            }

            // 2. Xử lý Copy (Ctrl + C) - Làm luôn cho đủ bộ (Bonus)
            if (e.Control && e.KeyCode == Keys.C)
            {
                if (_mainbitmap != null)
                {
                    Clipboard.SetImage(_mainbitmap);
                }
            }

            // Kiểm tra phím tắt cho Undo (Ctrl + Z)
            if (e.Control && e.KeyCode == Keys.Z)
            {
                // Gọi hàm xử lý Undo
                quickUndoButton_Click(sender, e);
            }
            // Kiểm tra phím tắt cho Redo (Ctrl + Y)
            if (e.Control && e.KeyCode == Keys.Y)
            {
                // Gọi hàm xử lý Redo
                quickRedoButton_Click(sender, e);
            }
        }

        private void resizeButton_Click(object sender, EventArgs e)
        {
            using (resizeCanvasDialog dlg = new resizeCanvasDialog())
            {
                dlg.setLabel_CurrentSize(_mainbitmap.Width, _mainbitmap.Height);
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    resizeCanvas(dlg.CanvasWidth, dlg.CanvasHeight);
                }
            }
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (currentTool == ToolType.Fill)
            {
                DrawingLogic.Fill(_mainbitmap, e.Location, currentColor, 50);
                pictureBox1.Invalidate();
            }
        }
    }
}
