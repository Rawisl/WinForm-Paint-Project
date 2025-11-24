namespace WinForm_Paint_Gr12
{
    partial class NewCanvasDialog
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
            this.width_label = new System.Windows.Forms.Label();
            this.height_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // width_label
            // 
            this.width_label.AutoSize = true;
            this.width_label.Font = new System.Drawing.Font("Sans Serif Collection", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.width_label.Location = new System.Drawing.Point(12, 18);
            this.width_label.Name = "width_label";
            this.width_label.Size = new System.Drawing.Size(164, 58);
            this.width_label.TabIndex = 0;
            this.width_label.Text = "Chiều rộng (px):";
            // 
            // height_label
            // 
            this.height_label.AutoSize = true;
            this.height_label.Font = new System.Drawing.Font("Sans Serif Collection", 10.2F, System.Drawing.FontStyle.Bold);
            this.height_label.Location = new System.Drawing.Point(12, 76);
            this.height_label.Name = "height_label";
            this.height_label.Size = new System.Drawing.Size(153, 58);
            this.height_label.TabIndex = 1;
            this.height_label.Text = "Chiều cao (px):";
            this.height_label.Click += new System.EventHandler(this.height_label_Click);
            // 
            // NewCanvasDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 150);
            this.Controls.Add(this.height_label);
            this.Controls.Add(this.width_label);
            this.Name = "NewCanvasDialog";
            this.Text = "NewCanvasDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label width_label;
        private System.Windows.Forms.Label height_label;
    }
}