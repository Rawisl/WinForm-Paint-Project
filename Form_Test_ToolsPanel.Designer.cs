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
            this.toolsPanel1.Location = new System.Drawing.Point(42, 103);
            this.toolsPanel1.Name = "toolsPanel1";
            this.toolsPanel1.Size = new System.Drawing.Size(746, 232);
            this.toolsPanel1.TabIndex = 0;
            // 
            // Form_Test_ToolsPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolsPanel1);
            this.Name = "Form_Test_ToolsPanel";
            this.Text = "Form_Test_ToolsPanel";
            this.ResumeLayout(false);

        }

        #endregion

        private ToolsPanel toolsPanel1;
    }
}