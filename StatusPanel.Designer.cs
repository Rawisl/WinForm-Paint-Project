namespace WinForm_Paint_Gr12
{
    partial class StatusPanel
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
            this.components = new System.ComponentModel.Container();
            this.lblMousePosition = new System.Windows.Forms.Label();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // lblMousePosition
            // 
            this.lblMousePosition.AutoSize = true;
            this.lblMousePosition.Location = new System.Drawing.Point(34, 6);
            this.lblMousePosition.Name = "lblMousePosition";
            this.lblMousePosition.Size = new System.Drawing.Size(44, 16);
            this.lblMousePosition.TabIndex = 1;
            this.lblMousePosition.Text = "label1";
            this.toolTip1.SetToolTip(this.lblMousePosition, "Tọa độ");
            // 
            // StatusLabel
            // 
            this.StatusLabel.Image = global::WinForm_Paint_Gr12.Properties.Resources.cursor_PNG111;
            this.StatusLabel.Location = new System.Drawing.Point(3, 1);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(25, 26);
            this.StatusLabel.TabIndex = 0;
            this.StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // StatusPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblMousePosition);
            this.Controls.Add(this.StatusLabel);
            this.Name = "StatusPanel";
            this.Size = new System.Drawing.Size(87, 29);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.StatusPanel_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Label lblMousePosition;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
