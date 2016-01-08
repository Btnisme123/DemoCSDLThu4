namespace CSDLThu4.UI
{
    partial class frmNhanVien
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
            this.btnNhacNho = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.btnThayDoi = new System.Windows.Forms.Button();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.comboGT = new System.Windows.Forms.ComboBox();
            this.btnCongTac = new System.Windows.Forms.Button();
            this.btnDoiMK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNhacNho
            // 
            this.btnNhacNho.Location = new System.Drawing.Point(27, 297);
            this.btnNhacNho.Name = "btnNhacNho";
            this.btnNhacNho.Size = new System.Drawing.Size(163, 43);
            this.btnNhacNho.TabIndex = 1;
            this.btnNhacNho.Text = "Nhắc nhở";
            this.btnNhacNho.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Họ tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Địa chỉ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Số điện thoại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Giới tính";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(280, 44);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(183, 22);
            this.txtHoTen.TabIndex = 8;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(280, 88);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(183, 22);
            this.txtDiaChi.TabIndex = 9;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(280, 134);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(183, 22);
            this.txtSDT.TabIndex = 10;
            // 
            // btnThayDoi
            // 
            this.btnThayDoi.Location = new System.Drawing.Point(537, 44);
            this.btnThayDoi.Name = "btnThayDoi";
            this.btnThayDoi.Size = new System.Drawing.Size(163, 43);
            this.btnThayDoi.TabIndex = 12;
            this.btnThayDoi.Text = "Thay đổi";
            this.btnThayDoi.UseVisualStyleBackColor = true;
            this.btnThayDoi.Click += new System.EventHandler(this.btnThayDoi_Click);
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Location = new System.Drawing.Point(537, 121);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(163, 43);
            this.btnXacNhan.TabIndex = 13;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // comboGT
            // 
            this.comboGT.FormattingEnabled = true;
            this.comboGT.Items.AddRange(new object[] {
            "Nam ",
            "Nữ"});
            this.comboGT.Location = new System.Drawing.Point(280, 178);
            this.comboGT.Name = "comboGT";
            this.comboGT.Size = new System.Drawing.Size(121, 24);
            this.comboGT.TabIndex = 14;
            // 
            // btnCongTac
            // 
            this.btnCongTac.Location = new System.Drawing.Point(291, 297);
            this.btnCongTac.Name = "btnCongTac";
            this.btnCongTac.Size = new System.Drawing.Size(163, 43);
            this.btnCongTac.TabIndex = 15;
            this.btnCongTac.Text = "Xem lịch CT";
            this.btnCongTac.UseVisualStyleBackColor = true;
            this.btnCongTac.Click += new System.EventHandler(this.btnCongTac_Click);
            // 
            // btnDoiMK
            // 
            this.btnDoiMK.Location = new System.Drawing.Point(537, 297);
            this.btnDoiMK.Name = "btnDoiMK";
            this.btnDoiMK.Size = new System.Drawing.Size(163, 43);
            this.btnDoiMK.TabIndex = 16;
            this.btnDoiMK.Text = "Đổi mật khẩu";
            this.btnDoiMK.UseVisualStyleBackColor = true;
            this.btnDoiMK.Click += new System.EventHandler(this.btnDoiMK_Click);
            // 
            // frmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 421);
            this.Controls.Add(this.btnDoiMK);
            this.Controls.Add(this.btnCongTac);
            this.Controls.Add(this.comboGT);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.btnThayDoi);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNhacNho);
            this.Name = "frmNhanVien";
            this.Text = "FormNhanVien";
            this.Load += new System.EventHandler(this.frmNhanVien_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNhacNho;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Button btnThayDoi;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.ComboBox comboGT;
        private System.Windows.Forms.Button btnCongTac;
        private System.Windows.Forms.Button btnDoiMK;
    }
}