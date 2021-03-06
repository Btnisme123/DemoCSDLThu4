﻿namespace CSDLThu4.UI
{
    partial class FormCapPhanHoi
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
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNhacLan1 = new System.Windows.Forms.Button();
            this.labelHang = new System.Windows.Forms.Label();
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
            this.Column4,
            this.Column6,
            this.Column7,
            this.Column3});
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
            this.gridViewNV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridViewNV.Size = new System.Drawing.Size(803, 205);
            this.gridViewNV.TabIndex = 10;
            this.gridViewNV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridViewNV_CellClick_1);
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
            // Column4
            // 
            this.Column4.HeaderText = "ID";
            this.Column4.Name = "Column4";
            this.Column4.Width = 46;
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
            // Column3
            // 
            this.Column3.HeaderText = "Cấp độ nhắc";
            this.Column3.Name = "Column3";
            this.Column3.Width = 104;
            // 
            // btnNhacLan1
            // 
            this.btnNhacLan1.Location = new System.Drawing.Point(290, 262);
            this.btnNhacLan1.Name = "btnNhacLan1";
            this.btnNhacLan1.Size = new System.Drawing.Size(126, 46);
            this.btnNhacLan1.TabIndex = 11;
            this.btnNhacLan1.Text = "Nhắc nhở ";
            this.btnNhacLan1.UseVisualStyleBackColor = true;
            this.btnNhacLan1.Click += new System.EventHandler(this.btnNhacLan1_Click);
            // 
            // labelHang
            // 
            this.labelHang.AutoSize = true;
            this.labelHang.Location = new System.Drawing.Point(595, 262);
            this.labelHang.Name = "labelHang";
            this.labelHang.Size = new System.Drawing.Size(42, 17);
            this.labelHang.TabIndex = 12;
            this.labelHang.Text = "Hàng";
            // 
            // FormCapPhanHoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 476);
            this.Controls.Add(this.labelHang);
            this.Controls.Add(this.btnNhacLan1);
            this.Controls.Add(this.gridViewNV);
            this.Name = "FormCapPhanHoi";
            this.Text = "Thông báo các cấp";
            this.Load += new System.EventHandler(this.FormCapPhanHoi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewNV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridViewNV;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button btnNhacLan1;
        private System.Windows.Forms.Label labelHang;

    }
}