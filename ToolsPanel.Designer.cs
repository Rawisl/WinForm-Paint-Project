namespace WinForm_Paint_Gr12
{
    partial class ToolsPanel
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToolsPanel));
            this.panel1 = new System.Windows.Forms.Panel();
            this.IconList = new System.Windows.Forms.ImageList(this.components);
            this.PropertiesButton = new System.Windows.Forms.Button();
            this.colorpickerButton = new System.Windows.Forms.RadioButton();
            this.fillButton = new System.Windows.Forms.RadioButton();
            this.triangleButton = new System.Windows.Forms.RadioButton();
            this.eraserButton = new System.Windows.Forms.RadioButton();
            this.ellipseButton = new System.Windows.Forms.RadioButton();
            this.textButton = new System.Windows.Forms.RadioButton();
            this.rectangleButton = new System.Windows.Forms.RadioButton();
            this.pencilButton = new System.Windows.Forms.RadioButton();
            this.lineButton = new System.Windows.Forms.RadioButton();
            this.brushButton = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.colorpickerButton);
            this.panel1.Controls.Add(this.fillButton);
            this.panel1.Controls.Add(this.triangleButton);
            this.panel1.Controls.Add(this.eraserButton);
            this.panel1.Controls.Add(this.ellipseButton);
            this.panel1.Controls.Add(this.textButton);
            this.panel1.Controls.Add(this.rectangleButton);
            this.panel1.Controls.Add(this.pencilButton);
            this.panel1.Controls.Add(this.lineButton);
            this.panel1.Controls.Add(this.brushButton);
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(533, 49);
            this.panel1.TabIndex = 6;
            // 
            // IconList
            // 
            this.IconList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("IconList.ImageStream")));
            this.IconList.TransparentColor = System.Drawing.Color.Transparent;
            this.IconList.Images.SetKeyName(0, "Color_Picker_Icon.png");
            this.IconList.Images.SetKeyName(1, "Fill_Bucket_Icon.png");
            this.IconList.Images.SetKeyName(2, "Triangle_Icon.png");
            this.IconList.Images.SetKeyName(3, "Ellipse_Icon.png");
            this.IconList.Images.SetKeyName(4, "Rectangle_Icon.png");
            this.IconList.Images.SetKeyName(5, "Straight_Line_Icon.png");
            this.IconList.Images.SetKeyName(6, "TextBox_Icon.png");
            this.IconList.Images.SetKeyName(7, "Brush_Icon.png");
            this.IconList.Images.SetKeyName(8, "Pencil_Icon.png");
            this.IconList.Images.SetKeyName(9, "Eraser_Icon.png");
            // 
            // PropertiesButton
            // 
            this.PropertiesButton.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.PropertiesButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(230)))), ((int)(((byte)(247)))));
            this.PropertiesButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.PropertiesButton.Image = global::WinForm_Paint_Gr12.Properties.Resources.right_double_arrows;
            this.PropertiesButton.Location = new System.Drawing.Point(541, 44);
            this.PropertiesButton.Margin = new System.Windows.Forms.Padding(4);
            this.PropertiesButton.Name = "PropertiesButton";
            this.PropertiesButton.Padding = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.PropertiesButton.Size = new System.Drawing.Size(28, 35);
            this.PropertiesButton.TabIndex = 8;
            this.PropertiesButton.UseVisualStyleBackColor = true;
            this.PropertiesButton.Click += new System.EventHandler(this.PropertiesButton_Click);
            // 
            // colorpickerButton
            // 
            this.colorpickerButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.colorpickerButton.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.colorpickerButton.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.colorpickerButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(230)))), ((int)(((byte)(247)))));
            this.colorpickerButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.colorpickerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colorpickerButton.ImageKey = "Color_Picker_Icon.png";
            this.colorpickerButton.ImageList = this.IconList;
            this.colorpickerButton.Location = new System.Drawing.Point(477, 0);
            this.colorpickerButton.Margin = new System.Windows.Forms.Padding(4);
            this.colorpickerButton.Name = "colorpickerButton";
            this.colorpickerButton.Padding = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.colorpickerButton.Size = new System.Drawing.Size(45, 45);
            this.colorpickerButton.TabIndex = 7;
            this.colorpickerButton.UseVisualStyleBackColor = true;
            this.colorpickerButton.CheckedChanged += new System.EventHandler(this.colorpickerButton_CheckedChanged);
            // 
            // fillButton
            // 
            this.fillButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.fillButton.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.fillButton.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.fillButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(230)))), ((int)(((byte)(247)))));
            this.fillButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.fillButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fillButton.ImageKey = "Fill_Bucket_Icon.png";
            this.fillButton.ImageList = this.IconList;
            this.fillButton.Location = new System.Drawing.Point(424, 0);
            this.fillButton.Margin = new System.Windows.Forms.Padding(4);
            this.fillButton.Name = "fillButton";
            this.fillButton.Padding = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.fillButton.Size = new System.Drawing.Size(45, 45);
            this.fillButton.TabIndex = 6;
            this.fillButton.UseVisualStyleBackColor = true;
            this.fillButton.CheckedChanged += new System.EventHandler(this.fillButton_CheckedChanged);
            // 
            // triangleButton
            // 
            this.triangleButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.triangleButton.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.triangleButton.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.triangleButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(230)))), ((int)(((byte)(247)))));
            this.triangleButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.triangleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.triangleButton.ImageKey = "Triangle_Icon.png";
            this.triangleButton.ImageList = this.IconList;
            this.triangleButton.Location = new System.Drawing.Point(371, 0);
            this.triangleButton.Margin = new System.Windows.Forms.Padding(4);
            this.triangleButton.Name = "triangleButton";
            this.triangleButton.Padding = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.triangleButton.Size = new System.Drawing.Size(45, 45);
            this.triangleButton.TabIndex = 6;
            this.triangleButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.triangleButton.UseVisualStyleBackColor = true;
            this.triangleButton.CheckedChanged += new System.EventHandler(this.triangleButton_CheckedChanged);
            // 
            // eraserButton
            // 
            this.eraserButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.eraserButton.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.eraserButton.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.eraserButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(230)))), ((int)(((byte)(247)))));
            this.eraserButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.eraserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eraserButton.ImageKey = "Eraser_Icon.png";
            this.eraserButton.ImageList = this.IconList;
            this.eraserButton.Location = new System.Drawing.Point(0, 0);
            this.eraserButton.Margin = new System.Windows.Forms.Padding(4);
            this.eraserButton.Name = "eraserButton";
            this.eraserButton.Padding = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.eraserButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.eraserButton.Size = new System.Drawing.Size(45, 45);
            this.eraserButton.TabIndex = 5;
            this.eraserButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.eraserButton.UseVisualStyleBackColor = true;
            this.eraserButton.CheckedChanged += new System.EventHandler(this.eraserButton_CheckedChanged);
            // 
            // ellipseButton
            // 
            this.ellipseButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.ellipseButton.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ellipseButton.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.ellipseButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(230)))), ((int)(((byte)(247)))));
            this.ellipseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ellipseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ellipseButton.ImageKey = "Ellipse_Icon.png";
            this.ellipseButton.ImageList = this.IconList;
            this.ellipseButton.Location = new System.Drawing.Point(318, 0);
            this.ellipseButton.Margin = new System.Windows.Forms.Padding(4);
            this.ellipseButton.Name = "ellipseButton";
            this.ellipseButton.Padding = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.ellipseButton.Size = new System.Drawing.Size(45, 45);
            this.ellipseButton.TabIndex = 4;
            this.ellipseButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ellipseButton.UseVisualStyleBackColor = true;
            this.ellipseButton.CheckedChanged += new System.EventHandler(this.ellipseButton_CheckedChanged);
            // 
            // textButton
            // 
            this.textButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.textButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.textButton.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.textButton.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.textButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(230)))), ((int)(((byte)(247)))));
            this.textButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.textButton.ImageKey = "Textbox_Icon.png";
            this.textButton.ImageList = this.IconList;
            this.textButton.Location = new System.Drawing.Point(159, 0);
            this.textButton.Margin = new System.Windows.Forms.Padding(4);
            this.textButton.Name = "textButton";
            this.textButton.Padding = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.textButton.Size = new System.Drawing.Size(45, 45);
            this.textButton.TabIndex = 2;
            this.textButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.textButton.UseVisualStyleBackColor = true;
            this.textButton.CheckedChanged += new System.EventHandler(this.textButton_CheckedChanged);
            // 
            // rectangleButton
            // 
            this.rectangleButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.rectangleButton.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rectangleButton.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.rectangleButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(230)))), ((int)(((byte)(247)))));
            this.rectangleButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.rectangleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rectangleButton.ImageKey = "Rectangle_Icon.png";
            this.rectangleButton.ImageList = this.IconList;
            this.rectangleButton.Location = new System.Drawing.Point(265, 0);
            this.rectangleButton.Margin = new System.Windows.Forms.Padding(4);
            this.rectangleButton.Name = "rectangleButton";
            this.rectangleButton.Padding = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.rectangleButton.Size = new System.Drawing.Size(45, 45);
            this.rectangleButton.TabIndex = 3;
            this.rectangleButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rectangleButton.UseVisualStyleBackColor = true;
            this.rectangleButton.CheckedChanged += new System.EventHandler(this.rectangleButton_CheckedChanged);
            // 
            // pencilButton
            // 
            this.pencilButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.pencilButton.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pencilButton.Checked = true;
            this.pencilButton.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.pencilButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(230)))), ((int)(((byte)(247)))));
            this.pencilButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pencilButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pencilButton.ImageKey = "Pencil_Icon.png";
            this.pencilButton.ImageList = this.IconList;
            this.pencilButton.Location = new System.Drawing.Point(53, 0);
            this.pencilButton.Margin = new System.Windows.Forms.Padding(4);
            this.pencilButton.Name = "pencilButton";
            this.pencilButton.Padding = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.pencilButton.Size = new System.Drawing.Size(45, 45);
            this.pencilButton.TabIndex = 0;
            this.pencilButton.TabStop = true;
            this.pencilButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pencilButton.UseVisualStyleBackColor = true;
            this.pencilButton.CheckedChanged += new System.EventHandler(this.pencilButton_CheckedChanged);
            // 
            // lineButton
            // 
            this.lineButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.lineButton.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lineButton.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.lineButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(230)))), ((int)(((byte)(247)))));
            this.lineButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lineButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lineButton.ImageKey = "Straight_Line_Icon.png";
            this.lineButton.ImageList = this.IconList;
            this.lineButton.Location = new System.Drawing.Point(212, 0);
            this.lineButton.Margin = new System.Windows.Forms.Padding(4);
            this.lineButton.Name = "lineButton";
            this.lineButton.Padding = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.lineButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lineButton.Size = new System.Drawing.Size(45, 45);
            this.lineButton.TabIndex = 2;
            this.lineButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lineButton.UseVisualStyleBackColor = true;
            this.lineButton.CheckedChanged += new System.EventHandler(this.lineButton_CheckedChanged);
            // 
            // brushButton
            // 
            this.brushButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.brushButton.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.brushButton.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.brushButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(230)))), ((int)(((byte)(247)))));
            this.brushButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.brushButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.brushButton.ImageKey = "Brush_Icon.png";
            this.brushButton.ImageList = this.IconList;
            this.brushButton.Location = new System.Drawing.Point(106, 0);
            this.brushButton.Margin = new System.Windows.Forms.Padding(4);
            this.brushButton.Name = "brushButton";
            this.brushButton.Padding = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.brushButton.Size = new System.Drawing.Size(45, 45);
            this.brushButton.TabIndex = 1;
            this.brushButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.brushButton.UseVisualStyleBackColor = true;
            this.brushButton.CheckedChanged += new System.EventHandler(this.brushButton_CheckedChanged);
            // 
            // ToolsPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Controls.Add(this.PropertiesButton);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "ToolsPanel";
            this.Size = new System.Drawing.Size(588, 92);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RadioButton textButton;
        private System.Windows.Forms.RadioButton lineButton;
        private System.Windows.Forms.RadioButton rectangleButton;
        private System.Windows.Forms.RadioButton ellipseButton;
        private System.Windows.Forms.RadioButton eraserButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ImageList IconList;
        private System.Windows.Forms.RadioButton triangleButton;
        private System.Windows.Forms.RadioButton fillButton;
        private System.Windows.Forms.RadioButton colorpickerButton;
        private System.Windows.Forms.RadioButton brushButton;
        private System.Windows.Forms.RadioButton pencilButton;
        private System.Windows.Forms.Button PropertiesButton;
    }
}
