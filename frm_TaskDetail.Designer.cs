namespace QUANLYCONGVIEC
{
    partial class frm_TaskDetail : System.Windows.Forms.Form
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTenCongViec = new System.Windows.Forms.Label();
            this.lblMoTa = new System.Windows.Forms.Label();
            this.lblNgayTao = new System.Windows.Forms.Label();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtTenCongViec = new System.Windows.Forms.TextBox();
            this.lblNgayTaoValue = new System.Windows.Forms.Label();
            this.lblTrangThaiValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTenCongViec
            // 
            this.lblTenCongViec.AutoSize = true;
            this.lblTenCongViec.Location = new System.Drawing.Point(38, 41);
            this.lblTenCongViec.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTenCongViec.Name = "lblTenCongViec";
            this.lblTenCongViec.Size = new System.Drawing.Size(79, 13);
            this.lblTenCongViec.TabIndex = 0;
            this.lblTenCongViec.Text = "Tên công việc:";
            // 
            // lblMoTa
            // 
            this.lblMoTa.AutoSize = true;
            this.lblMoTa.Location = new System.Drawing.Point(38, 65);
            this.lblMoTa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMoTa.Name = "lblMoTa";
            this.lblMoTa.Size = new System.Drawing.Size(37, 13);
            this.lblMoTa.TabIndex = 1;
            this.lblMoTa.Text = "Mô tả:";
            // 
            // lblNgayTao
            // 
            this.lblNgayTao.AutoSize = true;
            this.lblNgayTao.Location = new System.Drawing.Point(38, 162);
            this.lblNgayTao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNgayTao.Name = "lblNgayTao";
            this.lblNgayTao.Size = new System.Drawing.Size(53, 13);
            this.lblNgayTao.TabIndex = 2;
            this.lblNgayTao.Text = "Ngày tạo:";
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Location = new System.Drawing.Point(38, 187);
            this.lblTrangThai.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(58, 13);
            this.lblTrangThai.TabIndex = 3;
            this.lblTrangThai.Text = "Trạng thái:";
            // 
            // txtMoTa
            // 
            this.txtMoTa.Location = new System.Drawing.Point(112, 65);
            this.txtMoTa.Margin = new System.Windows.Forms.Padding(2);
            this.txtMoTa.Multiline = true;
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.ReadOnly = true;
            this.txtMoTa.Size = new System.Drawing.Size(226, 82);
            this.txtMoTa.TabIndex = 4;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(150, 228);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(56, 24);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Đóng";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtTenCongViec
            // 
            this.txtTenCongViec.Location = new System.Drawing.Point(122, 40);
            this.txtTenCongViec.Name = "txtTenCongViec";
            this.txtTenCongViec.Size = new System.Drawing.Size(176, 20);
            this.txtTenCongViec.TabIndex = 6;
            // 
            // lblNgayTaoValue
            // 
            this.lblNgayTaoValue.AutoSize = true;
            this.lblNgayTaoValue.Location = new System.Drawing.Point(112, 162);
            this.lblNgayTaoValue.Name = "lblNgayTaoValue";
            this.lblNgayTaoValue.Size = new System.Drawing.Size(86, 13);
            this.lblNgayTaoValue.TabIndex = 7;
            this.lblNgayTaoValue.Text = "lbNgayTaoValue";
            // 
            // lblTrangThaiValue
            // 
            this.lblTrangThaiValue.AutoSize = true;
            this.lblTrangThaiValue.Location = new System.Drawing.Point(112, 187);
            this.lblTrangThaiValue.Name = "lblTrangThaiValue";
            this.lblTrangThaiValue.Size = new System.Drawing.Size(91, 13);
            this.lblTrangThaiValue.TabIndex = 8;
            this.lblTrangThaiValue.Text = "lbTrangThaiValue";
            this.lblTrangThaiValue.Click += new System.EventHandler(this.lbTrangThaiValue_Click);
            // 
            // frm_TaskDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 284);
            this.Controls.Add(this.lblTrangThaiValue);
            this.Controls.Add(this.lblNgayTaoValue);
            this.Controls.Add(this.txtTenCongViec);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtMoTa);
            this.Controls.Add(this.lblTrangThai);
            this.Controls.Add(this.lblNgayTao);
            this.Controls.Add(this.lblMoTa);
            this.Controls.Add(this.lblTenCongViec);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frm_TaskDetail";
            this.Text = "Thông Tin Công Việc";
            this.Load += new System.EventHandler(this.DetailForm_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblTenCongViec;
        private System.Windows.Forms.Label lblMoTa;
        private System.Windows.Forms.Label lblNgayTao;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtTenCongViec;
        private System.Windows.Forms.Label lblNgayTaoValue;
        private System.Windows.Forms.Label lblTrangThaiValue;
    }
}
