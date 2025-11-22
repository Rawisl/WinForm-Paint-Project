namespace WinForm_Paint_Gr12
{
    partial class Form_Test_ToolsPanel
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.toolsPanel1 = new WinForm_Paint_Gr12.ToolsPanel();
            this.test_Canvas = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.test_Canvas)).BeginInit();
            this.SuspendLayout();
            // 
            // toolsPanel1
            // 
            this.toolsPanel1.Location = new System.Drawing.Point(3, 1);
            this.toolsPanel1.Name = "toolsPanel1";
            this.toolsPanel1.Size = new System.Drawing.Size(746, 47);
            this.toolsPanel1.TabIndex = 0;
            // 
            // test_Canvas
            // 
            this.test_Canvas.BackColor = System.Drawing.Color.White;
            this.test_Canvas.Location = new System.Drawing.Point(12, 54);
            this.test_Canvas.Name = "test_Canvas";
            this.test_Canvas.Size = new System.Drawing.Size(634, 308);
            this.test_Canvas.TabIndex = 1;
            this.test_Canvas.TabStop = false;
            this.test_Canvas.Click += new System.EventHandler(this.test_Canvas_Click);
            // 
            // Form_Test_ToolsPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.test_Canvas);
            this.Controls.Add(this.toolsPanel1);
            this.DoubleBuffered = true;
            this.Name = "Form_Test_ToolsPanel";
            this.Text = "Form_Test_ToolsPanel";
            ((System.ComponentModel.ISupportInitialize)(this.test_Canvas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ToolsPanel toolsPanel1;
        private System.Windows.Forms.PictureBox test_Canvas;
    }
}