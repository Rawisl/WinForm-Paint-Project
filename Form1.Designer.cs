using System;
using System.Windows.Forms;

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
            this.canvasContainer_panel = new System.Windows.Forms.Panel();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.fileButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.openFileButton = new System.Windows.Forms.ToolStripMenuItem();
            this.newFileButton = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileButton = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsFileButton = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.quickSaveButton = new System.Windows.Forms.ToolStripButton();
            this.quickUndoButton = new System.Windows.Forms.ToolStripButton();
            this.quickRedoButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.resizeButton = new System.Windows.Forms.ToolStripButton();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.separatorPanel = new System.Windows.Forms.Panel();
            this.propertiesPanel1 = new WinForm_Paint_Gr12.PropertiesPanel();
            this.toolsPanel1 = new WinForm_Paint_Gr12.ToolsPanel();
            this.statusPanel1 = new WinForm_Paint_Gr12.StatusPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.canvasContainer_panel.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.headerPanel.SuspendLayout();
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
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // canvasContainer_panel
            // 
            this.canvasContainer_panel.AutoScroll = true;
            this.canvasContainer_panel.BackColor = System.Drawing.Color.LightGray;
            this.canvasContainer_panel.Controls.Add(this.pictureBox1);
            this.canvasContainer_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.canvasContainer_panel.Location = new System.Drawing.Point(0, 152);
            this.canvasContainer_panel.Name = "canvasContainer_panel";
            this.canvasContainer_panel.Size = new System.Drawing.Size(1482, 574);
            this.canvasContainer_panel.TabIndex = 5;
            // 
            // toolStrip
            // 
            this.toolStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileButton,
            this.toolStripSeparator1,
            this.quickSaveButton,
            this.quickUndoButton,
            this.quickRedoButton,
            this.toolStripSeparator2,
            this.resizeButton});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(1482, 30);
            this.toolStrip.TabIndex = 6;
            this.toolStrip.Text = "toolStrip1";
            // 
            // fileButton
            // 
            this.fileButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fileButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileButton,
            this.newFileButton,
            this.saveFileButton,
            this.saveAsFileButton});
            this.fileButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileButton.Image = ((System.Drawing.Image)(resources.GetObject("fileButton.Image")));
            this.fileButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fileButton.Name = "fileButton";
            this.fileButton.Size = new System.Drawing.Size(49, 27);
            this.fileButton.Text = "&File";
            this.fileButton.Click += new System.EventHandler(this.file_menu_Click);
            // 
            // openFileButton
            // 
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openFileButton.Size = new System.Drawing.Size(243, 28);
            this.openFileButton.Text = "&Open";
            this.openFileButton.Click += new System.EventHandler(this.open_menu_Click);
            // 
            // newFileButton
            // 
            this.newFileButton.Name = "newFileButton";
            this.newFileButton.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newFileButton.Size = new System.Drawing.Size(243, 28);
            this.newFileButton.Text = "&New";
            this.newFileButton.Click += new System.EventHandler(this.new_menu_Click);
            // 
            // saveFileButton
            // 
            this.saveFileButton.Name = "saveFileButton";
            this.saveFileButton.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveFileButton.Size = new System.Drawing.Size(243, 28);
            this.saveFileButton.Text = "&Save";
            this.saveFileButton.Click += new System.EventHandler(this.save_menu_Click);
            // 
            // saveAsFileButton
            // 
            this.saveAsFileButton.Name = "saveAsFileButton";
            this.saveAsFileButton.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.S)));
            this.saveAsFileButton.Size = new System.Drawing.Size(243, 28);
            this.saveAsFileButton.Text = "Save &As";
            this.saveAsFileButton.Click += new System.EventHandler(this.saveAsMenu_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 30);
            // 
            // quickSaveButton
            // 
            this.quickSaveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.quickSaveButton.Image = ((System.Drawing.Image)(resources.GetObject("quickSaveButton.Image")));
            this.quickSaveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.quickSaveButton.Name = "quickSaveButton";
            this.quickSaveButton.Size = new System.Drawing.Size(29, 27);
            this.quickSaveButton.Text = "Quick save";
            this.quickSaveButton.Click += new System.EventHandler(this.save_menu_Click);
            // 
            // quickUndoButton
            // 
            this.quickUndoButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.quickUndoButton.Enabled = false;
            this.quickUndoButton.Image = ((System.Drawing.Image)(resources.GetObject("quickUndoButton.Image")));
            this.quickUndoButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.quickUndoButton.Name = "quickUndoButton";
            this.quickUndoButton.Size = new System.Drawing.Size(29, 27);
            this.quickUndoButton.Text = "Undo";
            this.quickUndoButton.Click += new System.EventHandler(this.quickUndoButton_Click);
            // 
            // quickRedoButton
            // 
            this.quickRedoButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.quickRedoButton.Enabled = false;
            this.quickRedoButton.Image = ((System.Drawing.Image)(resources.GetObject("quickRedoButton.Image")));
            this.quickRedoButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.quickRedoButton.Name = "quickRedoButton";
            this.quickRedoButton.Size = new System.Drawing.Size(29, 27);
            this.quickRedoButton.Text = "Redo";
            this.quickRedoButton.Click += new System.EventHandler(this.quickRedoButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 30);
            // 
            // resizeButton
            // 
            this.resizeButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.resizeButton.Image = global::WinForm_Paint_Gr12.Properties.Resources.Resize_Icon;
            this.resizeButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.resizeButton.Name = "resizeButton";
            this.resizeButton.Size = new System.Drawing.Size(29, 27);
            this.resizeButton.Text = "Resize";
            this.resizeButton.Click += new System.EventHandler(this.resizeButton_Click);
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.headerPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.headerPanel.Controls.Add(this.separatorPanel);
            this.headerPanel.Controls.Add(this.propertiesPanel1);
            this.headerPanel.Controls.Add(this.toolsPanel1);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 30);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(1482, 122);
            this.headerPanel.TabIndex = 4;
            // 
            // separatorPanel
            // 
            this.separatorPanel.BackColor = System.Drawing.Color.Silver;
            this.separatorPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.separatorPanel.Location = new System.Drawing.Point(598, 0);
            this.separatorPanel.Name = "separatorPanel";
            this.separatorPanel.Size = new System.Drawing.Size(2, 120);
            this.separatorPanel.TabIndex = 2;
            this.separatorPanel.Visible = false;
            // 
            // propertiesPanel1
            // 
            this.propertiesPanel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.propertiesPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertiesPanel1.Location = new System.Drawing.Point(598, 0);
            this.propertiesPanel1.Name = "propertiesPanel1";
            this.propertiesPanel1.Size = new System.Drawing.Size(882, 120);
            this.propertiesPanel1.TabIndex = 1;
            this.propertiesPanel1.Visible = false;
            // 
            // toolsPanel1
            // 
            this.toolsPanel1.AutoScroll = true;
            this.toolsPanel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.toolsPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolsPanel1.Location = new System.Drawing.Point(0, 0);
            this.toolsPanel1.Name = "toolsPanel1";
            this.toolsPanel1.Size = new System.Drawing.Size(598, 120);
            this.toolsPanel1.TabIndex = 0;
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
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1482, 753);
            this.Controls.Add(this.canvasContainer_panel);
            this.Controls.Add(this.statusPanel1);
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.toolStrip);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paint";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainForm_FormClosing);
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mainForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.canvasContainer_panel.ResumeLayout(false);
            this.canvasContainer_panel.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.headerPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private StatusPanel statusPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel canvasContainer_panel;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripDropDownButton fileButton;
        private System.Windows.Forms.ToolStripMenuItem openFileButton;
        private System.Windows.Forms.ToolStripMenuItem newFileButton;
        private System.Windows.Forms.ToolStripMenuItem saveFileButton;
        private System.Windows.Forms.ToolStripMenuItem saveAsFileButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton quickSaveButton;
        private System.Windows.Forms.ToolStripButton quickUndoButton;
        private System.Windows.Forms.ToolStripButton quickRedoButton;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton resizeButton;
        private Panel headerPanel;
        private PropertiesPanel propertiesPanel1;
        private ToolsPanel toolsPanel1;
        private Panel separatorPanel;
        //private EventHandler quickRedoButton_Click;
        //private KeyEventHandler mainForm_KeyDown;
        //private PaintEventHandler pictureBox1_Paint;
    }
}

