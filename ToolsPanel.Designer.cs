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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToolsPanel));
            this.textButton = new System.Windows.Forms.RadioButton();
            this.brushButton = new System.Windows.Forms.RadioButton();
            this.pencilButton = new System.Windows.Forms.RadioButton();
            this.lineButton = new System.Windows.Forms.RadioButton();
            this.rectangleButton = new System.Windows.Forms.RadioButton();
            this.ellipseButton = new System.Windows.Forms.RadioButton();
            this.eraserButton = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.fillButton = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textButton
            // 
            this.textButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.textButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.textButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.textButton.Image = ((System.Drawing.Image)(resources.GetObject("textButton.Image")));
            this.textButton.Location = new System.Drawing.Point(144, 0);
            this.textButton.Name = "textButton";
            this.textButton.Size = new System.Drawing.Size(42, 38);
            this.textButton.TabIndex = 2;
            this.textButton.UseVisualStyleBackColor = true;
            this.textButton.CheckedChanged += new System.EventHandler(this.textButton_CheckedChanged);
            // 
            // brushButton
            // 
            this.brushButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.brushButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.brushButton.Image = global::WinForm_Paint_Gr12.Properties.Resources.brush;
            this.brushButton.Location = new System.Drawing.Point(96, 0);
            this.brushButton.Name = "brushButton";
            this.brushButton.Size = new System.Drawing.Size(42, 38);
            this.brushButton.TabIndex = 1;
            this.brushButton.UseVisualStyleBackColor = true;
            this.brushButton.CheckedChanged += new System.EventHandler(this.brushButton_CheckedChanged);
            // 
            // pencilButton
            // 
            this.pencilButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.pencilButton.Checked = true;
            this.pencilButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pencilButton.Image = global::WinForm_Paint_Gr12.Properties.Resources.pencil;
            this.pencilButton.Location = new System.Drawing.Point(48, 0);
            this.pencilButton.Name = "pencilButton";
            this.pencilButton.Size = new System.Drawing.Size(42, 38);
            this.pencilButton.TabIndex = 0;
            this.pencilButton.TabStop = true;
            this.pencilButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pencilButton.UseVisualStyleBackColor = true;
            this.pencilButton.CheckedChanged += new System.EventHandler(this.pencilButton_CheckedChanged);
            // 
            // lineButton
            // 
            this.lineButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.lineButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lineButton.Image = global::WinForm_Paint_Gr12.Properties.Resources.line;
            this.lineButton.Location = new System.Drawing.Point(192, 0);
            this.lineButton.Name = "lineButton";
            this.lineButton.Size = new System.Drawing.Size(42, 38);
            this.lineButton.TabIndex = 2;
            this.lineButton.UseVisualStyleBackColor = true;
            this.lineButton.CheckedChanged += new System.EventHandler(this.lineButton_CheckedChanged);
            // 
            // rectangleButton
            // 
            this.rectangleButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.rectangleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rectangleButton.Image = global::WinForm_Paint_Gr12.Properties.Resources.rectangle;
            this.rectangleButton.Location = new System.Drawing.Point(240, 0);
            this.rectangleButton.Name = "rectangleButton";
            this.rectangleButton.Size = new System.Drawing.Size(42, 38);
            this.rectangleButton.TabIndex = 3;
            this.rectangleButton.UseVisualStyleBackColor = true;
            this.rectangleButton.CheckedChanged += new System.EventHandler(this.rectangleButton_CheckedChanged);
            // 
            // ellipseButton
            // 
            this.ellipseButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.ellipseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ellipseButton.Image = global::WinForm_Paint_Gr12.Properties.Resources.elips;
            this.ellipseButton.Location = new System.Drawing.Point(288, 0);
            this.ellipseButton.Name = "ellipseButton";
            this.ellipseButton.Size = new System.Drawing.Size(42, 38);
            this.ellipseButton.TabIndex = 4;
            this.ellipseButton.UseVisualStyleBackColor = true;
            this.ellipseButton.CheckedChanged += new System.EventHandler(this.ellipseButton_CheckedChanged);
            // 
            // eraserButton
            // 
            this.eraserButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.eraserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eraserButton.Image = ((System.Drawing.Image)(resources.GetObject("eraserButton.Image")));
            this.eraserButton.Location = new System.Drawing.Point(0, 0);
            this.eraserButton.Name = "eraserButton";
            this.eraserButton.Size = new System.Drawing.Size(42, 38);
            this.eraserButton.TabIndex = 5;
            this.eraserButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.eraserButton.UseVisualStyleBackColor = true;
            this.eraserButton.CheckedChanged += new System.EventHandler(this.eraserButton_CheckedChanged);
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
            this.panel1.Location = new System.Drawing.Point(19, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(351, 44);
            this.panel1.TabIndex = 6;
            // 
            // fillButton
            // 
            this.fillButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.fillButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fillButton.Image = global::WinForm_Paint_Gr12.Properties.Resources.fill;
            this.fillButton.Location = new System.Drawing.Point(463, 3);
            this.fillButton.Name = "fillButton";
            this.fillButton.Size = new System.Drawing.Size(42, 38);
            this.fillButton.TabIndex = 6;
            this.fillButton.UseVisualStyleBackColor = true;
            this.fillButton.CheckedChanged += new System.EventHandler(this.fillButton_CheckedChanged);
            // 
            // ToolsPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.fillButton);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "ToolsPanel";
            this.Size = new System.Drawing.Size(535, 59);
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
        private System.Windows.Forms.RadioButton fillButton;
    }
}
