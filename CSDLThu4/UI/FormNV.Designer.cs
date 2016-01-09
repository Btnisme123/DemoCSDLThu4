namespace CSDLThu4.UI
{
    partial class FormNV
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gridViewNV = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThemNVvaoCT = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboGT = new System.Windows.Forms.ComboBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPASS = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboCapQL = new System.Windows.Forms.ComboBox();
            this.btnThemNV = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.comboMaQl = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.labelSelect = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewNV)).BeginInit();
            this.SuspendLayout();
            // 
            // gridViewNV
            // 
            this.gridViewNV.AllowUserToAddRows = false;
            this.gridViewNV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridViewNV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridViewNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewNV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridViewNV.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridViewNV.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridViewNV.Location = new System.Drawing.Point(0, 0);
            this.gridViewNV.Name = "gridViewNV";
            this.gridViewNV.RowTemplate.Height = 24;
            this.gridViewNV.Size = new System.Drawing.Size(782, 205);
            this.gridViewNV.TabIndex = 1;
            this.gridViewNV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridViewNV_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Check";
            this.Column1.Name = "Column1";
            this.Column1.Width = 53;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Mã nhân viên";
            this.Column2.Name = "Column2";
            this.Column2.Width = 108;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Họ tên";
            this.Column3.Name = "Column3";
            this.Column3.Width = 69;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "ID";
            this.Column4.Name = "Column4";
            this.Column4.Width = 46;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Giới tính";
            this.Column5.Name = "Column5";
            this.Column5.Width = 58;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Mã cấp quản lí";
            this.Column6.Name = "Column6";
            this.Column6.Width = 114;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Mã người quản lí";
            this.Column7.Name = "Column7";
            this.Column7.Width = 125;
            // 
            // btnThemNVvaoCT
            // 
            this.btnThemNVvaoCT.Location = new System.Drawing.Point(369, 211);
            this.btnThemNVvaoCT.Name = "btnThemNVvaoCT";
            this.btnThemNVvaoCT.Size = new System.Drawing.Size(150, 50);
            this.btnThemNVvaoCT.TabIndex = 2;
            this.btnThemNVvaoCT.Text = "Thêm nhân viên vào công việc";
            this.btnThemNVvaoCT.UseVisualStyleBackColor = true;
            this.btnThemNVvaoCT.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(105, 211);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(137, 50);
            this.btnShow.TabIndex = 3;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 451);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Giới tính";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 399);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Số điện thoại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 350);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Địa chỉ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 298);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Họ tên";
            // 
            // comboGT
            // 
            this.comboGT.FormattingEnabled = true;
            this.comboGT.Items.AddRange(new object[] {
            "Nam ",
            "Nữ"});
            this.comboGT.Location = new System.Drawing.Point(169, 448);
            this.comboGT.Name = "comboGT";
            this.comboGT.Size = new System.Drawing.Size(121, 24);
            this.comboGT.TabIndex = 18;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(169, 399);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(183, 22);
            this.txtSDT.TabIndex = 17;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(169, 347);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(183, 22);
            this.txtDiaChi.TabIndex = 16;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(169, 293);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(183, 22);
            this.txtHoTen.TabIndex = 15;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(522, 293);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(205, 22);
            this.txtEmail.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(419, 298);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(419, 348);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 17);
            this.label6.TabIndex = 21;
            this.label6.Text = "ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(419, 402);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 17);
            this.label7.TabIndex = 22;
            this.label7.Text = "Password";
            // 
            // txtPASS
            // 
            this.txtPASS.Location = new System.Drawing.Point(522, 402);
            this.txtPASS.Name = "txtPASS";
            this.txtPASS.Size = new System.Drawing.Size(203, 22);
            this.txtPASS.TabIndex = 24;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(522, 345);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(205, 22);
            this.txtId.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(419, 455);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 17);
            this.label8.TabIndex = 25;
            this.label8.Text = "Mã cấp quản lí";
            // 
            // comboCapQL
            // 
            this.comboCapQL.FormattingEnabled = true;
            this.comboCapQL.Items.AddRange(new object[] {
            "Cấp 1",
            "Cấp 2",
            "Cấp 3"});
            this.comboCapQL.Location = new System.Drawing.Point(526, 448);
            this.comboCapQL.Name = "comboCapQL";
            this.comboCapQL.Size = new System.Drawing.Size(121, 24);
            this.comboCapQL.TabIndex = 26;
            // 
            // btnThemNV
            // 
            this.btnThemNV.Location = new System.Drawing.Point(410, 515);
            this.btnThemNV.Name = "btnThemNV";
            this.btnThemNV.Size = new System.Drawing.Size(109, 38);
            this.btnThemNV.TabIndex = 29;
            this.btnThemNV.Text = "Thêm";
            this.btnThemNV.UseVisualStyleBackColor = true;
            this.btnThemNV.Click += new System.EventHandler(this.btnThemNV_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(574, 515);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(109, 38);
            this.btnXoa.TabIndex = 30;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(50, 501);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 17);
            this.label9.TabIndex = 27;
            this.label9.Text = "Mã người quản lí";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // comboMaQl
            // 
            this.comboMaQl.FormattingEnabled = true;
            this.comboMaQl.Location = new System.Drawing.Point(169, 498);
            this.comboMaQl.Name = "comboMaQl";
            this.comboMaQl.Size = new System.Drawing.Size(121, 24);
            this.comboMaQl.TabIndex = 28;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(643, 244);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 17);
            this.label10.TabIndex = 32;
            this.label10.Text = "Hàng hiện tại :";
            // 
            // labelSelect
            // 
            this.labelSelect.AutoSize = true;
            this.labelSelect.Location = new System.Drawing.Point(754, 244);
            this.labelSelect.Name = "labelSelect";
            this.labelSelect.Size = new System.Drawing.Size(16, 17);
            this.labelSelect.TabIndex = 31;
            this.labelSelect.Text = "1";
            // 
            // FormNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 565);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.labelSelect);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThemNV);
            this.Controls.Add(this.comboMaQl);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboCapQL);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtPASS);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboGT);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnThemNVvaoCT);
            this.Controls.Add(this.gridViewNV);
            this.Name = "FormNV";
            this.Text = "â";
            this.Load += new System.EventHandler(this.FormNV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewNV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridViewNV;
        private System.Windows.Forms.Button btnThemNVvaoCT;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboGT;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPASS;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboCapQL;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Button btnThemNV;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboMaQl;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelSelect;
    }
}