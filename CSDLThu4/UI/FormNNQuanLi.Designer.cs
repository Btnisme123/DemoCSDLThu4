namespace CSDLThu4.UI
{
    partial class FormNNQuanLi
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
            this.btnGui = new System.Windows.Forms.Button();
            this.rtxtbDetail = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboCT = new System.Windows.Forms.ComboBox();
            this.gridViewNV = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewNV)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGui
            // 
            this.btnGui.Location = new System.Drawing.Point(631, 250);
            this.btnGui.Name = "btnGui";
            this.btnGui.Size = new System.Drawing.Size(111, 47);
            this.btnGui.TabIndex = 2;
            this.btnGui.Text = "Gửi";
            this.btnGui.UseVisualStyleBackColor = true;
            // 
            // rtxtbDetail
            // 
            this.rtxtbDetail.Location = new System.Drawing.Point(248, 246);
            this.rtxtbDetail.Name = "rtxtbDetail";
            this.rtxtbDetail.Size = new System.Drawing.Size(295, 169);
            this.rtxtbDetail.TabIndex = 3;
            this.rtxtbDetail.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tiêu đề";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nội dung";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(248, 211);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(295, 22);
            this.textBox1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(121, 448);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Công tác";
            // 
            // comboCT
            // 
            this.comboCT.FormattingEnabled = true;
            this.comboCT.Location = new System.Drawing.Point(248, 445);
            this.comboCT.Name = "comboCT";
            this.comboCT.Size = new System.Drawing.Size(295, 24);
            this.comboCT.TabIndex = 8;
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
            this.gridViewNV.Size = new System.Drawing.Size(779, 205);
            this.gridViewNV.TabIndex = 9;
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
            // FormNNQuanLi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 492);
            this.Controls.Add(this.gridViewNV);
            this.Controls.Add(this.comboCT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtxtbDetail);
            this.Controls.Add(this.btnGui);
            this.Name = "FormNNQuanLi";
            this.Text = "FormNNQuanLi";
            this.Load += new System.EventHandler(this.FormNNQuanLi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewNV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGui;
        private System.Windows.Forms.RichTextBox rtxtbDetail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboCT;
        private System.Windows.Forms.DataGridView gridViewNV;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}