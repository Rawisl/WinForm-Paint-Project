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
            this.SuspendLayout();
            // 
            // toolsPanel1
            // 
            this.toolsPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toolsPanel1.AutoScroll = true;
            this.toolsPanel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.toolsPanel1.Location = new System.Drawing.Point(2, 1);
            this.toolsPanel1.Name = "toolsPanel1";
            this.toolsPanel1.Size = new System.Drawing.Size(1211, 662);
            this.toolsPanel1.TabIndex = 0;
            // 
            // Form_Test_ToolsPanel
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1215, 665);
            this.Controls.Add(this.toolsPanel1);
            this.DoubleBuffered = true;
            this.Name = "Form_Test_ToolsPanel";
            this.Text = "Form_Test_ToolsPanel";
            this.ResumeLayout(false);

        }

        #endregion

        private ToolsPanel toolsPanel1;
    }
}