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
            this.SuspendLayout();
            // 
            // textButton
            // 
            this.textButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.textButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.textButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.textButton.Image = ((System.Drawing.Image)(resources.GetObject("textButton.Image")));
            this.textButton.Location = new System.Drawing.Point(128, 15);
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
            this.brushButton.Location = new System.Drawing.Point(80, 15);
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
            this.pencilButton.Location = new System.Drawing.Point(32, 15);
            this.pencilButton.Name = "pencilButton";
            this.pencilButton.Size = new System.Drawing.Size(42, 38);
            this.pencilButton.TabIndex = 0;
            this.pencilButton.TabStop = true;
            this.pencilButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pencilButton.UseVisualStyleBackColor = true;
            this.pencilButton.CheckedChanged += new System.EventHandler(this.pencilButton_CheckedChanged);
            // 
            // ToolsPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.textButton);
            this.Controls.Add(this.brushButton);
            this.Controls.Add(this.pencilButton);
            this.DoubleBuffered = true;
            this.Name = "ToolsPanel";
            this.Size = new System.Drawing.Size(209, 61);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton pencilButton;
        private System.Windows.Forms.RadioButton brushButton;
        private System.Windows.Forms.RadioButton textButton;
    }
}
