namespace CSDLThu4.UI
{
    partial class frmQuanLi
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
            this.dataCongTac = new System.Windows.Forms.DataGridView();
            this.btnNhacNho = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnBoSung = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataCongTac)).BeginInit();
            this.SuspendLayout();
            // 
            // dataCongTac
            // 
            this.dataCongTac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataCongTac.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataCongTac.Location = new System.Drawing.Point(0, 0);
            this.dataCongTac.Name = "dataCongTac";
            this.dataCongTac.RowTemplate.Height = 24;
            this.dataCongTac.Size = new System.Drawing.Size(947, 182);
            this.dataCongTac.TabIndex = 0;
            // 
            // btnNhacNho
            // 
            this.btnNhacNho.Location = new System.Drawing.Point(734, 207);
            this.btnNhacNho.Name = "btnNhacNho";
            this.btnNhacNho.Size = new System.Drawing.Size(184, 50);
            this.btnNhacNho.TabIndex = 1;
            this.btnNhacNho.Text = "Nhắc nhở";
            this.btnNhacNho.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(30, 207);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(184, 50);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm mới";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnBoSung
            // 
            this.btnBoSung.Location = new System.Drawing.Point(734, 295);
            this.btnBoSung.Name = "btnBoSung";
            this.btnBoSung.Size = new System.Drawing.Size(184, 50);
            this.btnBoSung.TabIndex = 3;
            this.btnBoSung.Text = "Bổ sung";
            this.btnBoSung.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(279, 207);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(162, 22);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(279, 246);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(162, 22);
            this.textBox2.TabIndex = 5;
            // 
            // frmQuanLi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 450);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnBoSung);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnNhacNho);
            this.Controls.Add(this.dataCongTac);
            this.Name = "frmQuanLi";
            this.Text = "FormQuanLi";
            ((System.ComponentModel.ISupportInitialize)(this.dataCongTac)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataCongTac;
        private System.Windows.Forms.Button btnNhacNho;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnBoSung;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}