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
            this.btnThem = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.txtTenCT = new System.Windows.Forms.TextBox();
            this.txtDiaDiem = new System.Windows.Forms.TextBox();
            this.TenCongTac = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimeNgayKT = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboLoaiCT = new System.Windows.Forms.ComboBox();
            this.txtNoiDung = new System.Windows.Forms.TextBox();
            this.dateTimeNgayBD = new System.Windows.Forms.DateTimePicker();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThayDoi = new System.Windows.Forms.Button();
            this.btnThemNVvaoCT = new System.Windows.Forms.Button();
            this.labelSelect = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnHienThiNV = new System.Windows.Forms.Button();
            this.dataNV = new System.Windows.Forms.DataGridView();
            this.btnNN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataCongTac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataNV)).BeginInit();
            this.SuspendLayout();
            // 
            // dataCongTac
            // 
            this.dataCongTac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataCongTac.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataCongTac.Location = new System.Drawing.Point(0, 0);
            this.dataCongTac.Name = "dataCongTac";
            this.dataCongTac.RowTemplate.Height = 24;
            this.dataCongTac.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataCongTac.Size = new System.Drawing.Size(947, 182);
            this.dataCongTac.TabIndex = 0;
            this.dataCongTac.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataCongTac_CellClick);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(54, 378);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(84, 50);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm mới";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(209, 378);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(85, 50);
            this.btnCapNhat.TabIndex = 3;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // txtTenCT
            // 
            this.txtTenCT.Location = new System.Drawing.Point(141, 202);
            this.txtTenCT.Name = "txtTenCT";
            this.txtTenCT.Size = new System.Drawing.Size(162, 22);
            this.txtTenCT.TabIndex = 4;
            // 
            // txtDiaDiem
            // 
            this.txtDiaDiem.Location = new System.Drawing.Point(141, 247);
            this.txtDiaDiem.Name = "txtDiaDiem";
            this.txtDiaDiem.Size = new System.Drawing.Size(162, 22);
            this.txtDiaDiem.TabIndex = 5;
            // 
            // TenCongTac
            // 
            this.TenCongTac.AutoSize = true;
            this.TenCongTac.Location = new System.Drawing.Point(12, 207);
            this.TenCongTac.Name = "TenCongTac";
            this.TenCongTac.Size = new System.Drawing.Size(98, 17);
            this.TenCongTac.TabIndex = 6;
            this.TenCongTac.Text = "Tên Công Tác";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 252);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Quản lí";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(402, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Ngày kết thúc";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(404, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Ngày bắt đầu";
            // 
            // dateTimeNgayKT
            // 
            this.dateTimeNgayKT.Location = new System.Drawing.Point(550, 245);
            this.dateTimeNgayKT.Name = "dateTimeNgayKT";
            this.dateTimeNgayKT.Size = new System.Drawing.Size(200, 22);
            this.dateTimeNgayKT.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(402, 313);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Loại công tác";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 316);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Nội dung";
            // 
            // comboLoaiCT
            // 
            this.comboLoaiCT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboLoaiCT.FormattingEnabled = true;
            this.comboLoaiCT.Items.AddRange(new object[] {
            "Công tác mức 1",
            "Công tác mức 2",
            "Công tác mức 3"});
            this.comboLoaiCT.Location = new System.Drawing.Point(550, 311);
            this.comboLoaiCT.Name = "comboLoaiCT";
            this.comboLoaiCT.Size = new System.Drawing.Size(200, 24);
            this.comboLoaiCT.TabIndex = 15;
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.Location = new System.Drawing.Point(141, 311);
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.Size = new System.Drawing.Size(162, 22);
            this.txtNoiDung.TabIndex = 14;
            // 
            // dateTimeNgayBD
            // 
            this.dateTimeNgayBD.Location = new System.Drawing.Point(550, 200);
            this.dateTimeNgayBD.Name = "dateTimeNgayBD";
            this.dateTimeNgayBD.Size = new System.Drawing.Size(200, 22);
            this.dateTimeNgayBD.TabIndex = 16;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(358, 378);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(85, 50);
            this.btnXoa.TabIndex = 17;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThayDoi
            // 
            this.btnThayDoi.Location = new System.Drawing.Point(501, 378);
            this.btnThayDoi.Name = "btnThayDoi";
            this.btnThayDoi.Size = new System.Drawing.Size(109, 50);
            this.btnThayDoi.TabIndex = 18;
            this.btnThayDoi.Text = "Kiểm tra thay đổi";
            this.btnThayDoi.UseVisualStyleBackColor = true;
            this.btnThayDoi.Click += new System.EventHandler(this.btnThayDoi_Click);
            // 
            // btnThemNVvaoCT
            // 
            this.btnThemNVvaoCT.Location = new System.Drawing.Point(673, 378);
            this.btnThemNVvaoCT.Name = "btnThemNVvaoCT";
            this.btnThemNVvaoCT.Size = new System.Drawing.Size(109, 50);
            this.btnThemNVvaoCT.TabIndex = 19;
            this.btnThemNVvaoCT.Text = "Thêm nhân viên vào CT";
            this.btnThemNVvaoCT.UseVisualStyleBackColor = true;
            this.btnThemNVvaoCT.Click += new System.EventHandler(this.btnThemNVvaoCT_Click);
            // 
            // labelSelect
            // 
            this.labelSelect.AutoSize = true;
            this.labelSelect.Location = new System.Drawing.Point(881, 247);
            this.labelSelect.Name = "labelSelect";
            this.labelSelect.Size = new System.Drawing.Size(16, 17);
            this.labelSelect.TabIndex = 20;
            this.labelSelect.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(775, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Hàng hiện tại :";
            // 
            // btnHienThiNV
            // 
            this.btnHienThiNV.Location = new System.Drawing.Point(571, 500);
            this.btnHienThiNV.Name = "btnHienThiNV";
            this.btnHienThiNV.Size = new System.Drawing.Size(85, 50);
            this.btnHienThiNV.TabIndex = 23;
            this.btnHienThiNV.Text = "Hiển thị nhân viên";
            this.btnHienThiNV.UseVisualStyleBackColor = true;
            this.btnHienThiNV.Click += new System.EventHandler(this.btnHienThiNV_Click);
            // 
            // dataNV
            // 
            this.dataNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataNV.Location = new System.Drawing.Point(161, 442);
            this.dataNV.Name = "dataNV";
            this.dataNV.RowTemplate.Height = 24;
            this.dataNV.Size = new System.Drawing.Size(317, 174);
            this.dataNV.TabIndex = 24;
            // 
            // btnNN
            // 
            this.btnNN.Location = new System.Drawing.Point(822, 378);
            this.btnNN.Name = "btnNN";
            this.btnNN.Size = new System.Drawing.Size(96, 50);
            this.btnNN.TabIndex = 25;
            this.btnNN.Text = "Nhắc nhở";
            this.btnNN.UseVisualStyleBackColor = true;
            this.btnNN.Click += new System.EventHandler(this.btnNN_Click);
            // 
            // frmQuanLi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 620);
            this.Controls.Add(this.btnNN);
            this.Controls.Add(this.dataNV);
            this.Controls.Add(this.btnHienThiNV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelSelect);
            this.Controls.Add(this.btnThemNVvaoCT);
            this.Controls.Add(this.btnThayDoi);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.dateTimeNgayBD);
            this.Controls.Add(this.comboLoaiCT);
            this.Controls.Add(this.txtNoiDung);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimeNgayKT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TenCongTac);
            this.Controls.Add(this.txtDiaDiem);
            this.Controls.Add(this.txtTenCT);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dataCongTac);
            this.Name = "frmQuanLi";
            this.Text = "FormQuanLi";
            this.Load += new System.EventHandler(this.frmQuanLi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataCongTac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataNV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataCongTac;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.TextBox txtTenCT;
        private System.Windows.Forms.TextBox txtDiaDiem;
        private System.Windows.Forms.Label TenCongTac;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimeNgayKT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboLoaiCT;
        private System.Windows.Forms.TextBox txtNoiDung;
        private System.Windows.Forms.DateTimePicker dateTimeNgayBD;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThayDoi;
        private System.Windows.Forms.Button btnThemNVvaoCT;
        private System.Windows.Forms.Label labelSelect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnHienThiNV;
        private System.Windows.Forms.DataGridView dataNV;
        private System.Windows.Forms.Button btnNN;
    }
}