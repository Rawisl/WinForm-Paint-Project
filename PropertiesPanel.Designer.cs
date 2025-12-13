namespace WinForm_Paint_Gr12
{
    partial class PropertiesPanel
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
            this.btnPickColor = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.btnTrackbarSize = new System.Windows.Forms.Button();
            this.showSize_Label = new System.Windows.Forms.Label();
            this.pnlPreviewColor = new System.Windows.Forms.Panel();
            this.btnFont = new System.Windows.Forms.Button();
            this.lblFontPreview = new System.Windows.Forms.Label();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.btnBold = new System.Windows.Forms.Button();
            this.btnItalic = new System.Windows.Forms.Button();
            this.btnUnderline = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPickColor
            // 
            this.btnPickColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPickColor.Location = new System.Drawing.Point(3, 3);
            this.btnPickColor.Name = "btnPickColor";
            this.btnPickColor.Size = new System.Drawing.Size(130, 49);
            this.btnPickColor.TabIndex = 0;
            this.btnPickColor.Text = "Chọn màu";
            this.btnPickColor.UseVisualStyleBackColor = true;
            this.btnPickColor.Click += new System.EventHandler(this.btnPickColor_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(0, 58);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(547, 56);
            this.trackBar1.TabIndex = 1;
            this.trackBar1.Visible = false;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            this.trackBar1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trackBar1_MouseUp);
            // 
            // btnTrackbarSize
            // 
            this.btnTrackbarSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrackbarSize.Location = new System.Drawing.Point(190, 3);
            this.btnTrackbarSize.Name = "btnTrackbarSize";
            this.btnTrackbarSize.Size = new System.Drawing.Size(178, 49);
            this.btnTrackbarSize.TabIndex = 2;
            this.btnTrackbarSize.Text = "Chọn độ dày";
            this.btnTrackbarSize.UseVisualStyleBackColor = true;
            this.btnTrackbarSize.Click += new System.EventHandler(this.btnTrackbarSize_Click);
            // 
            // showSize_Label
            // 
            this.showSize_Label.AutoSize = true;
            this.showSize_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showSize_Label.Location = new System.Drawing.Point(553, 68);
            this.showSize_Label.Name = "showSize_Label";
            this.showSize_Label.Size = new System.Drawing.Size(41, 18);
            this.showSize_Label.TabIndex = 3;
            this.showSize_Label.Text = "Size:";
            this.showSize_Label.Visible = false;
            // 
            // pnlPreviewColor
            // 
            this.pnlPreviewColor.Location = new System.Drawing.Point(139, 3);
            this.pnlPreviewColor.Name = "pnlPreviewColor";
            this.pnlPreviewColor.Size = new System.Drawing.Size(45, 45);
            this.pnlPreviewColor.TabIndex = 4;
            // 
            // btnFont
            // 
            this.btnFont.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFont.Location = new System.Drawing.Point(374, 3);
            this.btnFont.Name = "btnFont";
            this.btnFont.Size = new System.Drawing.Size(118, 49);
            this.btnFont.TabIndex = 5;
            this.btnFont.Text = "Font";
            this.btnFont.UseVisualStyleBackColor = true;
            this.btnFont.Click += new System.EventHandler(this.btnFont_Click);
            // 
            // lblFontPreview
            // 
            this.lblFontPreview.AutoSize = true;
            this.lblFontPreview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFontPreview.Location = new System.Drawing.Point(498, 6);
            this.lblFontPreview.Name = "lblFontPreview";
            this.lblFontPreview.Size = new System.Drawing.Size(35, 18);
            this.lblFontPreview.TabIndex = 6;
            this.lblFontPreview.Text = "Font";
            // 
            // btnBold
            // 
            this.btnBold.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBold.Location = new System.Drawing.Point(724, 3);
            this.btnBold.Name = "btnBold";
            this.btnBold.Size = new System.Drawing.Size(32, 26);
            this.btnBold.TabIndex = 7;
            this.btnBold.Text = "&B";
            this.btnBold.UseVisualStyleBackColor = true;
            this.btnBold.Click += new System.EventHandler(this.btnBold_Click);
            // 
            // btnItalic
            // 
            this.btnItalic.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItalic.Location = new System.Drawing.Point(762, 3);
            this.btnItalic.Name = "btnItalic";
            this.btnItalic.Size = new System.Drawing.Size(32, 26);
            this.btnItalic.TabIndex = 8;
            this.btnItalic.Text = "&I";
            this.btnItalic.UseVisualStyleBackColor = true;
            this.btnItalic.Click += new System.EventHandler(this.btnItalic_Click);
            // 
            // btnUnderline
            // 
            this.btnUnderline.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnderline.Location = new System.Drawing.Point(800, 3);
            this.btnUnderline.Name = "btnUnderline";
            this.btnUnderline.Size = new System.Drawing.Size(32, 26);
            this.btnUnderline.TabIndex = 9;
            this.btnUnderline.Text = "&U";
            this.btnUnderline.UseVisualStyleBackColor = true;
            this.btnUnderline.Click += new System.EventHandler(this.btnUnderline_Click);
            // 
            // PropertiesPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnUnderline);
            this.Controls.Add(this.btnItalic);
            this.Controls.Add(this.btnBold);
            this.Controls.Add(this.lblFontPreview);
            this.Controls.Add(this.btnFont);
            this.Controls.Add(this.pnlPreviewColor);
            this.Controls.Add(this.showSize_Label);
            this.Controls.Add(this.btnTrackbarSize);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.btnPickColor);
            this.Name = "PropertiesPanel";
            this.Size = new System.Drawing.Size(883, 110);
            this.Load += new System.EventHandler(this.PropertiesPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPickColor;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button btnTrackbarSize;
        private System.Windows.Forms.Label showSize_Label;
        private System.Windows.Forms.Panel pnlPreviewColor;
        private System.Windows.Forms.Button btnFont;
        private System.Windows.Forms.Label lblFontPreview;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Button btnBold;
        private System.Windows.Forms.Button btnItalic;
        private System.Windows.Forms.Button btnUnderline;
    }
}
