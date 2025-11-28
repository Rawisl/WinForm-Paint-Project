namespace WinForm_Paint_Gr12
{
    partial class Form_Test_StatusPanel
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
            this.propertiesPanel1 = new WinForm_Paint_Gr12.PropertiesPanel();
            this.statusPanel1 = new WinForm_Paint_Gr12.StatusPanel();
            this.SuspendLayout();
            // 
            // propertiesPanel1
            // 
            this.propertiesPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.propertiesPanel1.Location = new System.Drawing.Point(0, 0);
            this.propertiesPanel1.Name = "propertiesPanel1";
            this.propertiesPanel1.Size = new System.Drawing.Size(562, 450);
            this.propertiesPanel1.TabIndex = 1;
            // 
            // statusPanel1
            // 
            this.statusPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.statusPanel1.Location = new System.Drawing.Point(689, 0);
            this.statusPanel1.Name = "statusPanel1";
            this.statusPanel1.Size = new System.Drawing.Size(111, 450);
            this.statusPanel1.TabIndex = 0;
            // 
            // Form_Test_StatusPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.propertiesPanel1);
            this.Controls.Add(this.statusPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Test_StatusPanel";
            this.Text = "Form_Test_StatusPanel";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_Test_StatusPanel_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion

        private StatusPanel statusPanel1;
        private PropertiesPanel propertiesPanel1;
    }
}