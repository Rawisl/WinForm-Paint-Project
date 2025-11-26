namespace WinForm_Paint_Gr12
{
    partial class mainForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.propertiesPanel1 = new WinForm_Paint_Gr12.PropertiesPanel();
            this.toolsPanel1 = new WinForm_Paint_Gr12.ToolsPanel();
            this.statusPanel1 = new WinForm_Paint_Gr12.StatusPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 1061);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 0);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // propertiesPanel1
            // 
            this.propertiesPanel1.AutoSize = true;
            this.propertiesPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.propertiesPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.propertiesPanel1.Location = new System.Drawing.Point(0, 1032);
            this.propertiesPanel1.Name = "propertiesPanel1";
            this.propertiesPanel1.Size = new System.Drawing.Size(800, 29);
            this.propertiesPanel1.TabIndex = 2;
            this.propertiesPanel1.Load += new System.EventHandler(this.propertiesPanel1_Load);
            // 
            // toolsPanel1
            // 
            this.toolsPanel1.AutoSize = true;
            this.toolsPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.toolsPanel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.toolsPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.toolsPanel1.Location = new System.Drawing.Point(0, 0);
            this.toolsPanel1.Name = "toolsPanel1";
            this.toolsPanel1.Size = new System.Drawing.Size(800, 1032);
            this.toolsPanel1.TabIndex = 1;
            this.toolsPanel1.Load += new System.EventHandler(this.toolsPanel1_Load);
            // 
            // statusPanel1
            // 
            this.statusPanel1.AutoSize = true;
            this.statusPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.statusPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.statusPanel1.Location = new System.Drawing.Point(0, 434);
            this.statusPanel1.Name = "statusPanel1";
            this.statusPanel1.Size = new System.Drawing.Size(800, 16);
            this.statusPanel1.TabIndex = 0;
            this.statusPanel1.Load += new System.EventHandler(this.statusPanel1_Load);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.propertiesPanel1);
            this.Controls.Add(this.toolsPanel1);
            this.Controls.Add(this.statusPanel1);
            this.DoubleBuffered = true;
            this.Name = "mainForm";
            this.Text = "Paint";
            this.Load += new System.EventHandler(this.mainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private StatusPanel statusPanel1;
        private ToolsPanel toolsPanel1;
        private PropertiesPanel propertiesPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

