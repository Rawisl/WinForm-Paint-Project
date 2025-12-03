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
            this.pencilButton = new System.Windows.Forms.RadioButton();
            this.brushButton = new System.Windows.Forms.RadioButton();
            this.lineButton = new System.Windows.Forms.RadioButton();
            this.rectangleButton = new System.Windows.Forms.RadioButton();
            this.ellipseButton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // pencilButton
            // 
            this.pencilButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.pencilButton.Checked = true;
            this.pencilButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pencilButton.Image = global::WinForm_Paint_Gr12.Properties.Resources.pencil;
            this.pencilButton.Location = new System.Drawing.Point(32, 15);
            this.pencilButton.Name = "pencilButton";
            this.pencilButton.Size = new System.Drawing.Size(42, 38);
            this.pencilButton.TabIndex = 0;
            this.pencilButton.TabStop = true;
            this.pencilButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pencilButton.UseVisualStyleBackColor = true;
            this.pencilButton.CheckedChanged += new System.EventHandler(this.pencilButton_CheckedChanged);
            // 
            // brushButton
            // 
            this.brushButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.brushButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.brushButton.Image = global::WinForm_Paint_Gr12.Properties.Resources.brush;
            this.brushButton.Location = new System.Drawing.Point(80, 15);
            this.brushButton.Name = "brushButton";
            this.brushButton.Size = new System.Drawing.Size(42, 38);
            this.brushButton.TabIndex = 1;
            this.brushButton.UseVisualStyleBackColor = true;
            this.brushButton.CheckedChanged += new System.EventHandler(this.brushButton_CheckedChanged);
            // 
            // lineButton
            // 
            this.lineButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.lineButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lineButton.Image = global::WinForm_Paint_Gr12.Properties.Resources.line;
            this.lineButton.Location = new System.Drawing.Point(128, 15);
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
            this.rectangleButton.Location = new System.Drawing.Point(176, 15);
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
            this.ellipseButton.Location = new System.Drawing.Point(224, 15);
            this.ellipseButton.Name = "ellipseButton";
            this.ellipseButton.Size = new System.Drawing.Size(42, 38);
            this.ellipseButton.TabIndex = 4;
            this.ellipseButton.UseVisualStyleBackColor = true;
            this.ellipseButton.CheckedChanged += new System.EventHandler(this.ellipseButton_CheckedChanged);
            // 
            // ToolsPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.ellipseButton);
            this.Controls.Add(this.rectangleButton);
            this.Controls.Add(this.lineButton);
            this.Controls.Add(this.brushButton);
            this.Controls.Add(this.pencilButton);
            this.DoubleBuffered = true;
            this.Name = "ToolsPanel";
            this.Size = new System.Drawing.Size(299, 70);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton pencilButton;
        private System.Windows.Forms.RadioButton brushButton;
        private System.Windows.Forms.RadioButton lineButton;
        private System.Windows.Forms.RadioButton rectangleButton;
        private System.Windows.Forms.RadioButton ellipseButton;
    }
}
