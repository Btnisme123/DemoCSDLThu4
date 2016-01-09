namespace CSDLThu4.UI
{
    partial class FormThayDoi
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
            this.btnDong = new System.Windows.Forms.Button();
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
            this.dataCongTac.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataCongTac.Size = new System.Drawing.Size(750, 185);
            this.dataCongTac.TabIndex = 1;
            this.dataCongTac.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataCongTac_CellContentClick);
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(274, 258);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(137, 55);
            this.btnDong.TabIndex = 2;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // FormThayDoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 375);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.dataCongTac);
            this.Name = "FormThayDoi";
            this.Text = "Thay đổi";
            this.Load += new System.EventHandler(this.FormThayDoi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataCongTac)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataCongTac;
        private System.Windows.Forms.Button btnDong;
    }
}