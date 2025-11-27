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
    public enum ToolType
    {
        Pencil, Brush
    }
    public partial class ToolsPanel : UserControl
    {
        bool isDrawing = false;
        Point lastPoint;
        Bitmap drawingSurface;

        ToolType currentTool = ToolType.Pencil;
        Color color = Color.Black;
        float sizeBrush = 2.0f;

        public ToolsPanel()
        {
            InitializeComponent();
            //Thiết kế nút, chức năng nút,...
        }

        private void ToolsPanel_Load(object sender, EventArgs e)
        {
            // Tạo bitmap
            drawingSurface = new Bitmap(drawArea.Width, drawArea.Height);
            drawArea.Image = drawingSurface;
        }

        private void pencilButton_CheckedChanged(object sender, EventArgs e)
        {
            currentTool = ToolType.Pencil; // Chọn công cụ pencil
        }

        private void brushButton_CheckedChanged(object sender, EventArgs e)
        {
            currentTool = ToolType.Brush; // Chọn công cụ brush
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void drawArea_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDrawing = true;
                lastPoint = e.Location; // cập nhật vị trí điểm vẽ lúc đó
            }
        }

        private void drawArea_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                Graphics g = Graphics.FromImage(drawingSurface);

                if (currentTool == ToolType.Pencil)
                    DrawingLogic.DrawPencil(g, lastPoint, e.Location, color); // Hàm từ class DrawingLogic
                else if (currentTool == ToolType.Brush)
                    DrawingLogic.DrawBrush(g, lastPoint, e.Location, color, sizeBrush); // Hàm từ class DrawingLogic
                g.Dispose();

                lastPoint = e.Location; // Cập nhật ví trí điểm vẽ lúc cuối
                drawArea.Invalidate(); // Vẽ lại
            }
        }

        private void drawArea_MouseUp(object sender, MouseEventArgs e)
        {
            isDrawing = false;
        }

        private void ToolsPanel_Resize(object sender, EventArgs e)
        {
            DrawingLogic.CenterPictureBox(drawArea, this);
        }
    }
}
