namespace WinForm_Paint_Gr12
{
    partial class resizeCanvasDialog
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
            this.cancel_button = new System.Windows.Forms.Button();
            this.OK_Button = new System.Windows.Forms.Button();
            this.height_num = new System.Windows.Forms.NumericUpDown();
            this.width_num = new System.Windows.Forms.NumericUpDown();
            this.height_label = new System.Windows.Forms.Label();
            this.width_label = new System.Windows.Forms.Label();
            this.currentSize_label = new System.Windows.Forms.Label();
            this.requestLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.height_num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.width_num)).BeginInit();
            this.SuspendLayout();
            // 
            // cancel_button
            // 
            this.cancel_button.AutoSize = true;
            this.cancel_button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel_button.Location = new System.Drawing.Point(182, 204);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(70, 30);
            this.cancel_button.TabIndex = 11;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = false;
            // 
            // OK_Button
            // 
            this.OK_Button.AutoSize = true;
            this.OK_Button.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OK_Button.Location = new System.Drawing.Point(79, 204);
            this.OK_Button.Name = "OK_Button";
            this.OK_Button.Size = new System.Drawing.Size(70, 30);
            this.OK_Button.TabIndex = 10;
            this.OK_Button.Text = "OK";
            this.OK_Button.UseVisualStyleBackColor = false;
            // 
            // height_num
            // 
            this.height_num.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.height_num.Location = new System.Drawing.Point(192, 153);
            this.height_num.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.height_num.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.height_num.Name = "height_num";
            this.height_num.Size = new System.Drawing.Size(120, 27);
            this.height_num.TabIndex = 9;
            this.height_num.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // width_num
            // 
            this.width_num.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.width_num.Location = new System.Drawing.Point(192, 95);
            this.width_num.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.width_num.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.width_num.Name = "width_num";
            this.width_num.Size = new System.Drawing.Size(120, 27);
            this.width_num.TabIndex = 8;
            this.width_num.Value = new decimal(new int[] {
            800,
            0,
            0,
            0});
            // 
            // height_label
            // 
            this.height_label.AutoSize = true;
            this.height_label.Font = new System.Drawing.Font("Sans Serif Collection", 10.2F, System.Drawing.FontStyle.Bold);
            this.height_label.Location = new System.Drawing.Point(23, 143);
            this.height_label.Name = "height_label";
            this.height_label.Size = new System.Drawing.Size(153, 58);
            this.height_label.TabIndex = 7;
            this.height_label.Text = "Chiều cao (px):";
            // 
            // width_label
            // 
            this.width_label.AutoSize = true;
            this.width_label.Font = new System.Drawing.Font("Sans Serif Collection", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.width_label.Location = new System.Drawing.Point(12, 85);
            this.width_label.Name = "width_label";
            this.width_label.Size = new System.Drawing.Size(164, 58);
            this.width_label.TabIndex = 6;
            this.width_label.Text = "Chiều rộng (px):";
            // 
            // currentSize_label
            // 
            this.currentSize_label.Font = new System.Drawing.Font("Sans Serif Collection", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentSize_label.Location = new System.Drawing.Point(-2, 9);
            this.currentSize_label.Name = "currentSize_label";
            this.currentSize_label.Size = new System.Drawing.Size(337, 49);
            this.currentSize_label.TabIndex = 12;
            this.currentSize_label.Text = "label1";
            this.currentSize_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // requestLabel
            // 
            this.requestLabel.Font = new System.Drawing.Font("Sans Serif Collection", 10.2F, System.Drawing.FontStyle.Bold);
            this.requestLabel.Location = new System.Drawing.Point(-2, 43);
            this.requestLabel.Name = "requestLabel";
            this.requestLabel.Size = new System.Drawing.Size(337, 42);
            this.requestLabel.TabIndex = 13;
            this.requestLabel.Text = "Nhập kích thước mới";
            this.requestLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // resizeCanvasDialog
            // 
            this.AcceptButton = this.OK_Button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancel_button;
            this.ClientSize = new System.Drawing.Size(334, 253);
            this.Controls.Add(this.requestLabel);
            this.Controls.Add(this.currentSize_label);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.OK_Button);
            this.Controls.Add(this.height_num);
            this.Controls.Add(this.width_num);
            this.Controls.Add(this.height_label);
            this.Controls.Add(this.width_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Name = "resizeCanvasDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Resize canvas";
            ((System.ComponentModel.ISupportInitialize)(this.height_num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.width_num)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Button OK_Button;
        private System.Windows.Forms.NumericUpDown height_num;
        private System.Windows.Forms.NumericUpDown width_num;
        private System.Windows.Forms.Label height_label;
        private System.Windows.Forms.Label width_label;
        private System.Windows.Forms.Label currentSize_label;
        private System.Windows.Forms.Label requestLabel;
    }
}