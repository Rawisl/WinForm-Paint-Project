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
            this.PropertiesButton = new System.Windows.Forms.Button();
            this.colorpickerButton = new System.Windows.Forms.RadioButton();
            this.IconList = new System.Windows.Forms.ImageList(this.components);
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
            this.panel1.Controls.Add(this.PropertiesButton);
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
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(579, 61);
            this.panel1.TabIndex = 6;
            // 
            // PropertiesButton
            // 
            this.PropertiesButton.Location = new System.Drawing.Point(512, 0);
            this.PropertiesButton.Name = "PropertiesButton";
            this.PropertiesButton.Size = new System.Drawing.Size(52, 45);
            this.PropertiesButton.TabIndex = 8;
            this.PropertiesButton.UseVisualStyleBackColor = true;
            this.PropertiesButton.Click += new System.EventHandler(this.PropertiesButton_Click);
            // 
            // colorpickerButton
            // 
            this.colorpickerButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.colorpickerButton.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.colorpickerButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.colorpickerButton.ImageKey = "Color_Picker.png";
            this.colorpickerButton.ImageList = this.IconList;
            this.colorpickerButton.Location = new System.Drawing.Point(459, 0);
            this.colorpickerButton.Name = "colorpickerButton";
            this.colorpickerButton.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.colorpickerButton.Size = new System.Drawing.Size(45, 45);
            this.colorpickerButton.TabIndex = 7;
            this.colorpickerButton.UseVisualStyleBackColor = true;
            this.colorpickerButton.CheckedChanged += new System.EventHandler(this.colorpickerButton_CheckedChanged);
            // 
            // IconList
            // 
            this.IconList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("IconList.ImageStream")));
            this.IconList.TransparentColor = System.Drawing.Color.Transparent;
            this.IconList.Images.SetKeyName(0, "Eraser_Icon.png");
            this.IconList.Images.SetKeyName(1, "Brush_Icon.png");
            this.IconList.Images.SetKeyName(2, "Ellipse_Icon.png");
            this.IconList.Images.SetKeyName(3, "Fill_Bucket_Icon.png");
            this.IconList.Images.SetKeyName(4, "Line_Icon.png");
            this.IconList.Images.SetKeyName(5, "Pencil_Icon.png");
            this.IconList.Images.SetKeyName(6, "Rectangle_Icon.png");
            this.IconList.Images.SetKeyName(7, "Textbox_Icon.png");
            this.IconList.Images.SetKeyName(8, "Triangle_Icon.png");
            this.IconList.Images.SetKeyName(9, "Color_Picker.png");
            // 
            // fillButton
            // 
            this.fillButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.fillButton.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.fillButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.fillButton.ImageKey = "Fill_Bucket_Icon.png";
            this.fillButton.ImageList = this.IconList;
            this.fillButton.Location = new System.Drawing.Point(408, 0);
            this.fillButton.Name = "fillButton";
            this.fillButton.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.fillButton.Size = new System.Drawing.Size(45, 45);
            this.fillButton.TabIndex = 6;
            this.fillButton.UseVisualStyleBackColor = true;
            this.fillButton.CheckedChanged += new System.EventHandler(this.fillButton_CheckedChanged);
            // 
            // triangleButton
            // 
            this.triangleButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.triangleButton.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.triangleButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.triangleButton.ImageKey = "Triangle_Icon.png";
            this.triangleButton.ImageList = this.IconList;
            this.triangleButton.Location = new System.Drawing.Point(357, 0);
            this.triangleButton.Name = "triangleButton";
            this.triangleButton.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
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
            this.eraserButton.FlatAppearance.BorderSize = 0;
            this.eraserButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.eraserButton.ImageKey = "Eraser_Icon.png";
            this.eraserButton.ImageList = this.IconList;
            this.eraserButton.Location = new System.Drawing.Point(0, 0);
            this.eraserButton.Name = "eraserButton";
            this.eraserButton.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
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
            this.ellipseButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ellipseButton.ImageKey = "Ellipse_Icon.png";
            this.ellipseButton.ImageList = this.IconList;
            this.ellipseButton.Location = new System.Drawing.Point(306, 0);
            this.ellipseButton.Name = "ellipseButton";
            this.ellipseButton.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
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
            this.textButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.textButton.ImageKey = "Textbox_Icon.png";
            this.textButton.ImageList = this.IconList;
            this.textButton.Location = new System.Drawing.Point(153, 0);
            this.textButton.Name = "textButton";
            this.textButton.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
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
            this.rectangleButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rectangleButton.ImageIndex = 6;
            this.rectangleButton.ImageList = this.IconList;
            this.rectangleButton.Location = new System.Drawing.Point(255, 0);
            this.rectangleButton.Name = "rectangleButton";
            this.rectangleButton.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
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
            this.pencilButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.pencilButton.ImageKey = "Pencil_Icon.png";
            this.pencilButton.ImageList = this.IconList;
            this.pencilButton.Location = new System.Drawing.Point(51, 0);
            this.pencilButton.Name = "pencilButton";
            this.pencilButton.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
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
            this.lineButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lineButton.ImageKey = "Line_Icon.png";
            this.lineButton.ImageList = this.IconList;
            this.lineButton.Location = new System.Drawing.Point(204, 0);
            this.lineButton.Name = "lineButton";
            this.lineButton.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
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
            this.brushButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.brushButton.ImageIndex = 1;
            this.brushButton.ImageList = this.IconList;
            this.brushButton.Location = new System.Drawing.Point(102, 0);
            this.brushButton.Name = "brushButton";
            this.brushButton.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
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
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "ToolsPanel";
            this.Size = new System.Drawing.Size(591, 77);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton pencilButton;
        private System.Windows.Forms.RadioButton brushButton;
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
        private System.Windows.Forms.Button PropertiesButton;
    }
}
