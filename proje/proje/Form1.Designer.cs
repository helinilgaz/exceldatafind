namespace proje
{
    partial class Form1
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
            this.excel_btnAc = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.kıyafetSecınız = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // excel_btnAc
            // 
            this.excel_btnAc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.excel_btnAc.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.excel_btnAc.ForeColor = System.Drawing.Color.Yellow;
            this.excel_btnAc.Location = new System.Drawing.Point(26, 14);
            this.excel_btnAc.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.excel_btnAc.Name = "excel_btnAc";
            this.excel_btnAc.Size = new System.Drawing.Size(263, 36);
            this.excel_btnAc.TabIndex = 0;
            this.excel_btnAc.Text = "SORGULA\r\n\r\n";
            this.excel_btnAc.UseVisualStyleBackColor = false;
            this.excel_btnAc.Click += new System.EventHandler(this.excel_btnAc_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // kıyafetSecınız
            // 
            this.kıyafetSecınız.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.kıyafetSecınız.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kıyafetSecınız.ForeColor = System.Drawing.Color.Yellow;
            this.kıyafetSecınız.FormattingEnabled = true;
            this.kıyafetSecınız.Items.AddRange(new object[] {
            "triko",
            "uzun elbise",
            "etek",
            "şort",
            "elbise",
            "mont",
            "kazak",
            "boyfriend jean",
            "şapka",
            "eldiven",
            "spor ayakkabı",
            "topuklu ayakkabı"});
            this.kıyafetSecınız.Location = new System.Drawing.Point(26, 77);
            this.kıyafetSecınız.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.kıyafetSecınız.Name = "kıyafetSecınız";
            this.kıyafetSecınız.Size = new System.Drawing.Size(263, 33);
            this.kıyafetSecınız.TabIndex = 1;
            this.kıyafetSecınız.SelectedIndexChanged += new System.EventHandler(this.kıyafetSecınız_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.pictureBox1.Location = new System.Drawing.Point(319, 14);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(316, 305);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkMagenta;
            this.ClientSize = new System.Drawing.Size(650, 325);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.kıyafetSecınız);
            this.Controls.Add(this.excel_btnAc);
            this.Font = new System.Drawing.Font("News701 BT", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.Text = "excel_arama";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button excel_btnAc;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ComboBox kıyafetSecınız;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

