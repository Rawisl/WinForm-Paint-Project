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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.file_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.open_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.new_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.save_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.canvasContainer_panel = new System.Windows.Forms.Panel();
            this.propertiesPanel1 = new WinForm_Paint_Gr12.PropertiesPanel();
            this.toolsPanel1 = new WinForm_Paint_Gr12.ToolsPanel();
            this.statusPanel1 = new WinForm_Paint_Gr12.StatusPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.canvasContainer_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 400);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.file_menu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1482, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // file_menu
            // 
            this.file_menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.open_menu,
            this.new_menu,
            this.save_menu,
            this.saveAsMenu});
            this.file_menu.Name = "file_menu";
            this.file_menu.Size = new System.Drawing.Size(46, 24);
            this.file_menu.Text = "&File";
            this.file_menu.Click += new System.EventHandler(this.file_menu_Click);
            // 
            // open_menu
            // 
            this.open_menu.Name = "open_menu";
            this.open_menu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.open_menu.Size = new System.Drawing.Size(233, 26);
            this.open_menu.Text = "&Open";
            this.open_menu.Click += new System.EventHandler(this.open_menu_Click);
            // 
            // new_menu
            // 
            this.new_menu.Name = "new_menu";
            this.new_menu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.new_menu.Size = new System.Drawing.Size(233, 26);
            this.new_menu.Text = "&New";
            this.new_menu.Click += new System.EventHandler(this.new_menu_Click);
            // 
            // save_menu
            // 
            this.save_menu.Name = "save_menu";
            this.save_menu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.save_menu.Size = new System.Drawing.Size(233, 26);
            this.save_menu.Text = "&Save";
            this.save_menu.Click += new System.EventHandler(this.save_menu_Click);
            // 
            // saveAsMenu
            // 
            this.saveAsMenu.Name = "saveAsMenu";
            this.saveAsMenu.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveAsMenu.Size = new System.Drawing.Size(233, 26);
            this.saveAsMenu.Text = "Save &As";
            this.saveAsMenu.Click += new System.EventHandler(this.saveAsMenu_Click);
            // 
            // canvasContainer_panel
            // 
            this.canvasContainer_panel.AutoScroll = true;
            this.canvasContainer_panel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.canvasContainer_panel.Controls.Add(this.pictureBox1);
            this.canvasContainer_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.canvasContainer_panel.Location = new System.Drawing.Point(0, 139);
            this.canvasContainer_panel.Name = "canvasContainer_panel";
            this.canvasContainer_panel.Size = new System.Drawing.Size(1482, 587);
            this.canvasContainer_panel.TabIndex = 5;
            this.canvasContainer_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.canvasContainer_panel_Paint);
            // 
            // propertiesPanel1
            // 
            this.propertiesPanel1.AutoSize = true;
            this.propertiesPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.propertiesPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.propertiesPanel1.Location = new System.Drawing.Point(0, 84);
            this.propertiesPanel1.Name = "propertiesPanel1";
            this.propertiesPanel1.Size = new System.Drawing.Size(1482, 55);
            this.propertiesPanel1.TabIndex = 2;
            this.propertiesPanel1.Load += new System.EventHandler(this.propertiesPanel1_Load);
            // 
            // toolsPanel1
            // 
            this.toolsPanel1.AutoScroll = true;
            this.toolsPanel1.AutoSize = true;
            this.toolsPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.toolsPanel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.toolsPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.toolsPanel1.Location = new System.Drawing.Point(0, 28);
            this.toolsPanel1.Name = "toolsPanel1";
            this.toolsPanel1.Size = new System.Drawing.Size(1482, 56);
            this.toolsPanel1.TabIndex = 1;
            this.toolsPanel1.Load += new System.EventHandler(this.toolsPanel1_Load);
            // 
            // statusPanel1
            // 
            this.statusPanel1.AutoSize = true;
            this.statusPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.statusPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.statusPanel1.Location = new System.Drawing.Point(0, 726);
            this.statusPanel1.Name = "statusPanel1";
            this.statusPanel1.Size = new System.Drawing.Size(1482, 27);
            this.statusPanel1.TabIndex = 0;
            this.statusPanel1.Load += new System.EventHandler(this.statusPanel1_Load);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 753);
            this.Controls.Add(this.canvasContainer_panel);
            this.Controls.Add(this.propertiesPanel1);
            this.Controls.Add(this.toolsPanel1);
            this.Controls.Add(this.statusPanel1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paint";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainForm_FormClosing);
            this.Load += new System.EventHandler(this.mainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.canvasContainer_panel.ResumeLayout(false);
            this.canvasContainer_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private StatusPanel statusPanel1;
        private ToolsPanel toolsPanel1;
        private PropertiesPanel propertiesPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem file_menu;
        private System.Windows.Forms.ToolStripMenuItem open_menu;
        private System.Windows.Forms.ToolStripMenuItem new_menu;
        private System.Windows.Forms.ToolStripMenuItem save_menu;
        private System.Windows.Forms.Panel canvasContainer_panel;
        private System.Windows.Forms.ToolStripMenuItem saveAsMenu;
    }
}

