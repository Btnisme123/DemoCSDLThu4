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
            this.gridViewTTNhanVien = new System.Windows.Forms.DataGridView();
            this.btnNhacNho = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTTNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // gridViewTTNhanVien
            // 
            this.gridViewTTNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewTTNhanVien.Location = new System.Drawing.Point(59, 22);
            this.gridViewTTNhanVien.Name = "gridViewTTNhanVien";
            this.gridViewTTNhanVien.RowTemplate.Height = 24;
            this.gridViewTTNhanVien.Size = new System.Drawing.Size(659, 175);
            this.gridViewTTNhanVien.TabIndex = 0;
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
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(222, 297);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(163, 43);
            this.btnLoad.TabIndex = 2;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // frmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 421);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnNhacNho);
            this.Controls.Add(this.gridViewTTNhanVien);
            this.Name = "frmNhanVien";
            this.Text = "FormNhanVien";
            this.Load += new System.EventHandler(this.frmNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTTNhanVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridViewTTNhanVien;
        private System.Windows.Forms.Button btnNhacNho;
        private System.Windows.Forms.Button btnLoad;
    }
}