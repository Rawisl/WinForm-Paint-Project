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
            this.eraserButton = new System.Windows.Forms.RadioButton();
            this.ellipseButton = new System.Windows.Forms.RadioButton();
            this.textButton = new System.Windows.Forms.RadioButton();
            this.rectangleButton = new System.Windows.Forms.RadioButton();
            this.pencilButton = new System.Windows.Forms.RadioButton();
            this.lineButton = new System.Windows.Forms.RadioButton();
            this.brushButton = new System.Windows.Forms.RadioButton();
            this.IconList = new System.Windows.Forms.ImageList(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.eraserButton);
            this.panel1.Controls.Add(this.ellipseButton);
            this.panel1.Controls.Add(this.textButton);
            this.panel1.Controls.Add(this.rectangleButton);
            this.panel1.Controls.Add(this.pencilButton);
            this.panel1.Controls.Add(this.lineButton);
            this.panel1.Controls.Add(this.brushButton);
            this.panel1.Location = new System.Drawing.Point(14, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(356, 61);
            this.panel1.TabIndex = 6;
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
            this.ellipseButton.Location = new System.Drawing.Point(288, 0);
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
            this.textButton.Location = new System.Drawing.Point(144, 0);
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
            this.rectangleButton.Location = new System.Drawing.Point(240, 0);
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
            this.pencilButton.Location = new System.Drawing.Point(48, 0);
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
            this.lineButton.Location = new System.Drawing.Point(192, 0);
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
            this.brushButton.Location = new System.Drawing.Point(96, 0);
            this.brushButton.Name = "brushButton";
            this.brushButton.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.brushButton.Size = new System.Drawing.Size(45, 45);
            this.brushButton.TabIndex = 1;
            this.brushButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.brushButton.UseVisualStyleBackColor = true;
            this.brushButton.CheckedChanged += new System.EventHandler(this.brushButton_CheckedChanged);
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
            this.Size = new System.Drawing.Size(398, 77);
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
    }
}
