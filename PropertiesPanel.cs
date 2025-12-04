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
    public partial class PropertiesPanel : UserControl
    {
        // --- 1. SỰ KIỆN (EVENTS) ---
        public event EventHandler colorChanged;
        public event EventHandler sizeChanged;
        public event EventHandler FontChanged;

        // --- 2. THUỘC TÍNH PUBLIC (DATA) ---
        public Color selectedColor { get; private set; } = Color.Black;
        public float selectedSize { get; private set; } = 2.0f;
        public Font selectedFont { get; private set; } = new Font("Times New Roman", 12f, FontStyle.Regular);

        // Thêm các thuộc tính mới để kiểm soát kiểu chữ
        public bool IsBold { get; private set; } = false;
        public bool IsItalic { get; private set; } = false;
        public bool IsUnderline { get; private set; } = false;
        public PropertiesPanel()
        {
            InitializeComponent();
        }
        
        private void PropertiesPanel_Load(object sender, EventArgs e)
        {
            //btnPickColor.BackColor = this.SelectedColor;

            //Panel hiển thị màu mặc định
            pnlPreviewColor.BackColor = this.selectedColor;

            //label hiển thị font mặc định
            lblFontPreview.Text = "Font: " + this.selectedFont.Name + "\n" + "Font Size: " + this.selectedFont.Size + "\n" + "FontStyle: " + this.selectedFont.Style;
        }

        //Nút chọn màu
        private void btnPickColor_Click(object sender, EventArgs e)
        {
            // Mở bảng màu
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                // Cập nhật dữ liệu
                this.selectedColor = colorDialog1.Color;

                // Cập nhật giao diện panel preview
                pnlPreviewColor.BackColor = this.selectedColor;

                // Bắn tin hiệu ra ngoài cho mainForm biết
                colorChanged?.Invoke(this, EventArgs.Empty);
            }


        }

        //Hàm bắt sự kiện thả chuột khi kéo trên trackBar
        private void trackBar1_MouseUp(object sender, MouseEventArgs e)
        {
            showSize_Label.Text = "Size: " + this.selectedSize;
        }

        //Nút ẩn hiện trackBar
        private void btnTrackbarSize_Click(object sender, EventArgs e)
        {
            //Đảo ngược trạng thái ẩn hiện của trackBar
            trackBar1.Visible = !trackBar1.Visible;
            showSize_Label.Visible = !showSize_Label.Visible;

            if(showSize_Label.Visible)
            {
                showSize_Label.Text = "Size: " + trackBar1.Value;
            }    
        }

        //Chỉnh sửa Size cọ bằng cách kéo trackbar 
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            // 1. Cập nhật dữ liệu
            this.selectedSize = (float)trackBar1.Value;

            // 2. BẮN SỰ KIỆN RA NGOÀI
            sizeChanged?.Invoke(this, EventArgs.Empty);
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            //Gán Font hiện tại vào dialog để khi mở hộp thoại ra thì nó sẽ hiển thị font đang được chọn
            fontDialog1.Font = this.selectedFont;

            //Mở hộp thoại chọn Font
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                //Cập nhật Font được chọn từ hộp thoại
                this.selectedFont = fontDialog1.Font;

                //Cập nhật trạng thái IsBold, IsItalic và IsUnderline
                this.IsBold = this.selectedFont.Bold;
                this.IsItalic = this.selectedFont.Italic;
                this.IsUnderline = this.selectedFont.Underline;

                //Hiển thị Font được chọn lên lblPreviewFont
                lblFontPreview.Text = "Font: " + this.selectedFont.Name + "\n" + "Font Size: " + this.selectedFont.Size + "\n" + "FontStyle: " + this.selectedFont.Style;

                //Bắn tín hiệu ra ngoài để cho Main bắn được tín hiệu
                FontChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        // Xử lý nút BOLD

        private void btnBold_Click(object sender, EventArgs e)
        {
            // Đảo ngược trạng thái
            this.IsBold = !this.IsBold;

            // Cập nhật FontStyle dựa trên các trạng thái IsBold, IsItalic, IsUnderline
            UpdateFontStyle();
        }

        // Xử lý nút ITALIC 

        private void btnItalic_Click(object sender, EventArgs e)
        {
            this.IsItalic = !this.IsItalic;
            UpdateFontStyle();
        }

        // Xử lý nút UNDERLINE

        private void btnUnderline_Click(object sender, EventArgs e)
        {
            this.IsUnderline = !this.IsUnderline;
            UpdateFontStyle();
        }


        // Hàm gộp các trạng thái kiểu chữ để tạo Font mới
        private void UpdateFontStyle()
        {
            FontStyle style = FontStyle.Regular;

            if (this.IsBold)
            {
                style |= FontStyle.Bold;
            }
            if (this.IsItalic)
            {
                style |= FontStyle.Italic;
            }
            if (this.IsUnderline)
            {
                style |= FontStyle.Underline;
            }

            // Tạo Font mới với kiểu đã cập nhật, giữ nguyên Tên và Kích thước
            this.selectedFont = new Font(this.selectedFont.FontFamily, this.selectedFont.Size, style);

            // Cập nhật Label hiển thị Font
            lblFontPreview.Text = "Font: " + this.selectedFont.Name + "\n" + "Font Size: " + this.selectedFont.Size + "\n" + "FontStyle: " + this.selectedFont.Style;

            // Bắn tín hiệu ra ngoài
            FontChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}

