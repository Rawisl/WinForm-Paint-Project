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
            this.drawArea = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.drawArea)).BeginInit();
            this.SuspendLayout();
            // 
            // pencilButton
            // 
            this.pencilButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.pencilButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pencilButton.Image = global::WinForm_Paint_Gr12.Properties.Resources.pencil;
            this.pencilButton.Location = new System.Drawing.Point(4, 3);
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
            this.brushButton.Location = new System.Drawing.Point(52, 3);
            this.brushButton.Name = "brushButton";
            this.brushButton.Size = new System.Drawing.Size(42, 38);
            this.brushButton.TabIndex = 1;
            this.brushButton.TabStop = true;
            this.brushButton.UseVisualStyleBackColor = true;
            this.brushButton.CheckedChanged += new System.EventHandler(this.brushButton_CheckedChanged);
            // 
            // drawArea
            // 
            this.drawArea.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.drawArea.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.drawArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.drawArea.Location = new System.Drawing.Point(15, 117);
            this.drawArea.Name = "drawArea";
            this.drawArea.Size = new System.Drawing.Size(1450, 600);
            this.drawArea.TabIndex = 2;
            this.drawArea.TabStop = false;
            this.drawArea.Click += new System.EventHandler(this.pictureBox1_Click);
            this.drawArea.MouseDown += new System.Windows.Forms.MouseEventHandler(this.drawArea_MouseDown);
            this.drawArea.MouseMove += new System.Windows.Forms.MouseEventHandler(this.drawArea_MouseMove);
            this.drawArea.MouseUp += new System.Windows.Forms.MouseEventHandler(this.drawArea_MouseUp);
            // 
            // ToolsPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.drawArea);
            this.Controls.Add(this.brushButton);
            this.Controls.Add(this.pencilButton);
            this.DoubleBuffered = true;
            this.Name = "ToolsPanel";
            this.Size = new System.Drawing.Size(1233, 712);
            this.Load += new System.EventHandler(this.ToolsPanel_Load);
            this.Resize += new System.EventHandler(this.ToolsPanel_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.drawArea)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton pencilButton;
        private System.Windows.Forms.RadioButton brushButton;
        private System.Windows.Forms.PictureBox drawArea;
    }
}
