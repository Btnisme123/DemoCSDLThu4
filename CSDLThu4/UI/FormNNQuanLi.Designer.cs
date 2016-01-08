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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gridViewNN = new System.Windows.Forms.DataGridView();
            this.btnGui = new System.Windows.Forms.Button();
            this.rtxtbDetail = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboCT = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewNN)).BeginInit();
            this.SuspendLayout();
            // 
            // gridViewNN
            // 
            this.gridViewNN.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridViewNN.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridViewNN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridViewNN.DefaultCellStyle = dataGridViewCellStyle1;
            this.gridViewNN.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridViewNN.Location = new System.Drawing.Point(0, 0);
            this.gridViewNN.Name = "gridViewNN";
            this.gridViewNN.RowTemplate.Height = 24;
            this.gridViewNN.Size = new System.Drawing.Size(779, 173);
            this.gridViewNN.TabIndex = 1;
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
            this.rtxtbDetail.Location = new System.Drawing.Point(248, 229);
            this.rtxtbDetail.Name = "rtxtbDetail";
            this.rtxtbDetail.Size = new System.Drawing.Size(295, 169);
            this.rtxtbDetail.TabIndex = 3;
            this.rtxtbDetail.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tiêu đề";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nội dung";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(248, 189);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(295, 22);
            this.textBox1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(121, 430);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Công tác";
            // 
            // comboCT
            // 
            this.comboCT.FormattingEnabled = true;
            this.comboCT.Location = new System.Drawing.Point(248, 421);
            this.comboCT.Name = "comboCT";
            this.comboCT.Size = new System.Drawing.Size(295, 24);
            this.comboCT.TabIndex = 8;
            // 
            // FormNNQuanLi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 467);
            this.Controls.Add(this.comboCT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtxtbDetail);
            this.Controls.Add(this.btnGui);
            this.Controls.Add(this.gridViewNN);
            this.Name = "FormNNQuanLi";
            this.Text = "FormNNQuanLi";
            this.Load += new System.EventHandler(this.FormNNQuanLi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewNN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridViewNN;
        private System.Windows.Forms.Button btnGui;
        private System.Windows.Forms.RichTextBox rtxtbDetail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboCT;
    }
}