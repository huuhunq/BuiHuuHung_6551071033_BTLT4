namespace DanhSachMenu
{
    partial class frmCapNhat
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            mnuCapNhat = new ToolStripMenuItem();
            mnuCapNhatLopA = new ToolStripMenuItem();
            mnuCapNhatLopB = new ToolStripMenuItem();
            mnuChuyenChonA = new ToolStripMenuItem();
            mnuChuyenChonB = new ToolStripMenuItem();
            mnuChuyenHetA = new ToolStripMenuItem();
            mnuChuyenHetB = new ToolStripMenuItem();
            mnuSepCapNhat = new ToolStripSeparator();
            mnuXoaDsLopA = new ToolStripMenuItem();
            mnuXoaDsLopB = new ToolStripMenuItem();
            mnuHeThong = new ToolStripMenuItem();
            mnuThongTin = new ToolStripMenuItem();
            mnuKetThuc = new ToolStripMenuItem();
            lblTenSV = new Label();
            txtTen = new TextBox();
            btnCapNhat = new Button();
            lstLopA = new ListBox();
            lstLopB = new ListBox();
            btnPhai1 = new Button();
            btnPhaiTatCa = new Button();
            btnTrai1 = new Button();
            btnTraiTatCa = new Button();
            btnXoaLopA = new Button();
            btnKetThuc = new Button();
            btnXoaLopB = new Button();
            statusStrip1 = new StatusStrip();
            lblNgay = new ToolStripStatusLabel();
            lblGio = new ToolStripStatusLabel();
            lblNguoiThietKe = new ToolStripStatusLabel();
            timer1 = new System.Windows.Forms.Timer(components);
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Cyan;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuCapNhat, mnuHeThong });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(504, 28);
            menuStrip1.TabIndex = 12;
            // 
            // mnuCapNhat
            // 
            mnuCapNhat.DropDownItems.AddRange(new ToolStripItem[] { mnuCapNhatLopA, mnuCapNhatLopB, mnuChuyenChonA, mnuChuyenChonB, mnuChuyenHetA, mnuChuyenHetB, mnuSepCapNhat, mnuXoaDsLopA, mnuXoaDsLopB });
            mnuCapNhat.Name = "mnuCapNhat";
            mnuCapNhat.Size = new Size(85, 24);
            mnuCapNhat.Text = "Cập Nhật";
            // 
            // mnuCapNhatLopA
            // 
            mnuCapNhatLopA.Name = "mnuCapNhatLopA";
            mnuCapNhatLopA.Size = new Size(314, 26);
            mnuCapNhatLopA.Text = "Cập Nhật Lớp A";
            mnuCapNhatLopA.Click += mnuCapNhatLopA_Click;
            // 
            // mnuCapNhatLopB
            // 
            mnuCapNhatLopB.Name = "mnuCapNhatLopB";
            mnuCapNhatLopB.Size = new Size(314, 26);
            mnuCapNhatLopB.Text = "Cập Nhật Lớp B";
            mnuCapNhatLopB.Click += mnuCapNhatLopB_Click;
            // 
            // mnuChuyenChonA
            // 
            mnuChuyenChonA.Name = "mnuChuyenChonA";
            mnuChuyenChonA.Size = new Size(314, 26);
            mnuChuyenChonA.Text = "Chuyển phần tử chọn sang lớp A";
            mnuChuyenChonA.Click += mnuChuyenChonA_Click;
            // 
            // mnuChuyenChonB
            // 
            mnuChuyenChonB.Name = "mnuChuyenChonB";
            mnuChuyenChonB.Size = new Size(314, 26);
            mnuChuyenChonB.Text = "Chuyển Phần Tử Chọn Sang Lớp B";
            mnuChuyenChonB.Click += mnuChuyenChonB_Click;
            // 
            // mnuChuyenHetA
            // 
            mnuChuyenHetA.Name = "mnuChuyenHetA";
            mnuChuyenHetA.Size = new Size(314, 26);
            mnuChuyenHetA.Text = "Chuyển hết ds sang lớp A";
            mnuChuyenHetA.Click += mnuChuyenHetA_Click;
            // 
            // mnuChuyenHetB
            // 
            mnuChuyenHetB.Name = "mnuChuyenHetB";
            mnuChuyenHetB.Size = new Size(314, 26);
            mnuChuyenHetB.Text = "Chuyển Hết ds Sang lớp B";
            mnuChuyenHetB.Click += mnuChuyenHetB_Click;
            // 
            // mnuSepCapNhat
            // 
            mnuSepCapNhat.Name = "mnuSepCapNhat";
            mnuSepCapNhat.Size = new Size(311, 6);
            // 
            // mnuXoaDsLopA
            // 
            mnuXoaDsLopA.Name = "mnuXoaDsLopA";
            mnuXoaDsLopA.Size = new Size(314, 26);
            mnuXoaDsLopA.Text = "Xóa Danh Sách Lớp A";
            mnuXoaDsLopA.Click += mnuXoaDsLopA_Click;
            // 
            // mnuXoaDsLopB
            // 
            mnuXoaDsLopB.Name = "mnuXoaDsLopB";
            mnuXoaDsLopB.Size = new Size(314, 26);
            mnuXoaDsLopB.Text = "Xóa Danh Sách Lớp B";
            mnuXoaDsLopB.Click += mnuXoaDsLopB_Click;
            // 
            // mnuHeThong
            // 
            mnuHeThong.DropDownItems.AddRange(new ToolStripItem[] { mnuThongTin, mnuKetThuc });
            mnuHeThong.Name = "mnuHeThong";
            mnuHeThong.Size = new Size(88, 24);
            mnuHeThong.Text = "Hệ Thống";
            // 
            // mnuThongTin
            // 
            mnuThongTin.Name = "mnuThongTin";
            mnuThongTin.Size = new Size(158, 26);
            mnuThongTin.Text = "Thông Tin";
            mnuThongTin.Click += mnuThongTin_Click;
            // 
            // mnuKetThuc
            // 
            mnuKetThuc.Name = "mnuKetThuc";
            mnuKetThuc.Size = new Size(158, 26);
            mnuKetThuc.Text = "Kết Thúc";
            mnuKetThuc.Click += mnuKetThuc_Click;
            // 
            // lblTenSV
            // 
            lblTenSV.AutoSize = true;
            lblTenSV.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblTenSV.Location = new Point(22, 48);
            lblTenSV.Name = "lblTenSV";
            lblTenSV.Size = new Size(68, 23);
            lblTenSV.TabIndex = 0;
            lblTenSV.Text = "Tên SV:";
            // 
            // txtTen
            // 
            txtTen.Location = new Point(95, 45);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(265, 27);
            txtTen.TabIndex = 0;
            // 
            // btnCapNhat
            // 
            btnCapNhat.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnCapNhat.Location = new Point(375, 43);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(105, 32);
            btnCapNhat.TabIndex = 1;
            btnCapNhat.Text = "Cập Nhật";
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // lstLopA
            // 
            lstLopA.Location = new Point(22, 90);
            lstLopA.Name = "lstLopA";
            lstLopA.SelectionMode = SelectionMode.MultiExtended;
            lstLopA.Size = new Size(170, 204);
            lstLopA.TabIndex = 2;
            // 
            // lstLopB
            // 
            lstLopB.Location = new Point(290, 90);
            lstLopB.Name = "lstLopB";
            lstLopB.SelectionMode = SelectionMode.MultiExtended;
            lstLopB.Size = new Size(190, 204);
            lstLopB.TabIndex = 7;
            // 
            // btnPhai1
            // 
            btnPhai1.Location = new Point(210, 95);
            btnPhai1.Name = "btnPhai1";
            btnPhai1.Size = new Size(62, 32);
            btnPhai1.TabIndex = 3;
            btnPhai1.Text = ">";
            btnPhai1.Click += btnPhai1_Click;
            // 
            // btnPhaiTatCa
            // 
            btnPhaiTatCa.Location = new Point(210, 135);
            btnPhaiTatCa.Name = "btnPhaiTatCa";
            btnPhaiTatCa.Size = new Size(62, 32);
            btnPhaiTatCa.TabIndex = 4;
            btnPhaiTatCa.Text = ">>";
            btnPhaiTatCa.Click += btnPhaiTatCa_Click;
            // 
            // btnTrai1
            // 
            btnTrai1.Location = new Point(210, 200);
            btnTrai1.Name = "btnTrai1";
            btnTrai1.Size = new Size(62, 32);
            btnTrai1.TabIndex = 5;
            btnTrai1.Text = "<";
            btnTrai1.Click += btnTrai1_Click;
            // 
            // btnTraiTatCa
            // 
            btnTraiTatCa.Location = new Point(210, 240);
            btnTraiTatCa.Name = "btnTraiTatCa";
            btnTraiTatCa.Size = new Size(62, 32);
            btnTraiTatCa.TabIndex = 6;
            btnTraiTatCa.Text = "<<";
            btnTraiTatCa.Click += btnTraiTatCa_Click;
            // 
            // btnXoaLopA
            // 
            btnXoaLopA.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnXoaLopA.Location = new Point(22, 310);
            btnXoaLopA.Name = "btnXoaLopA";
            btnXoaLopA.Size = new Size(145, 35);
            btnXoaLopA.TabIndex = 8;
            btnXoaLopA.Text = "Xóa Lớp A";
            btnXoaLopA.Click += btnXoaLopA_Click;
            // 
            // btnKetThuc
            // 
            btnKetThuc.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnKetThuc.Location = new Point(182, 310);
            btnKetThuc.Name = "btnKetThuc";
            btnKetThuc.Size = new Size(130, 35);
            btnKetThuc.TabIndex = 9;
            btnKetThuc.Text = "Kết Thúc";
            btnKetThuc.Click += btnKetThuc_Click;
            // 
            // btnXoaLopB
            // 
            btnXoaLopB.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnXoaLopB.Location = new Point(335, 310);
            btnXoaLopB.Name = "btnXoaLopB";
            btnXoaLopB.Size = new Size(145, 35);
            btnXoaLopB.TabIndex = 10;
            btnXoaLopB.Text = "Xóa Lớp B";
            btnXoaLopB.Click += btnXoaLopB_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.BackColor = Color.Cyan;
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblNgay, lblGio, lblNguoiThietKe });
            statusStrip1.Location = new Point(0, 359);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(504, 26);
            statusStrip1.TabIndex = 11;
            // 
            // lblNgay
            // 
            lblNgay.Name = "lblNgay";
            lblNgay.Size = new Size(0, 20);
            // 
            // lblGio
            // 
            lblGio.Name = "lblGio";
            lblGio.Size = new Size(0, 20);
            // 
            // lblNguoiThietKe
            // 
            lblNguoiThietKe.Name = "lblNguoiThietKe";
            lblNguoiThietKe.Size = new Size(189, 20);
            lblNguoiThietKe.Text = "Designed by Bùi Hữu Hùng";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // frmCapNhat
            // 
            AcceptButton = btnCapNhat;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(504, 385);
            Controls.Add(lblTenSV);
            Controls.Add(txtTen);
            Controls.Add(btnCapNhat);
            Controls.Add(lstLopA);
            Controls.Add(btnPhai1);
            Controls.Add(btnPhaiTatCa);
            Controls.Add(btnTrai1);
            Controls.Add(btnTraiTatCa);
            Controls.Add(lstLopB);
            Controls.Add(btnXoaLopA);
            Controls.Add(btnKetThuc);
            Controls.Add(btnXoaLopB);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "frmCapNhat";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form Cập Nhật 2 ListBox";
            FormClosing += frmCapNhat_FormClosing;
            Load += frmCapNhat_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuCapNhat;
        private System.Windows.Forms.ToolStripMenuItem mnuCapNhatLopA;
        private System.Windows.Forms.ToolStripMenuItem mnuCapNhatLopB;
        private System.Windows.Forms.ToolStripMenuItem mnuChuyenChonA;
        private System.Windows.Forms.ToolStripMenuItem mnuChuyenChonB;
        private System.Windows.Forms.ToolStripMenuItem mnuChuyenHetA;
        private System.Windows.Forms.ToolStripMenuItem mnuChuyenHetB;
        private System.Windows.Forms.ToolStripMenuItem mnuXoaDsLopA;
        private System.Windows.Forms.ToolStripMenuItem mnuXoaDsLopB;
        private System.Windows.Forms.ToolStripSeparator mnuSepCapNhat;
        private System.Windows.Forms.ToolStripMenuItem mnuHeThong;
        private System.Windows.Forms.ToolStripMenuItem mnuThongTin;
        private System.Windows.Forms.ToolStripMenuItem mnuKetThuc;
        private System.Windows.Forms.Label lblTenSV;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.ListBox lstLopA;
        private System.Windows.Forms.ListBox lstLopB;
        private System.Windows.Forms.Button btnPhai1;
        private System.Windows.Forms.Button btnPhaiTatCa;
        private System.Windows.Forms.Button btnTrai1;
        private System.Windows.Forms.Button btnTraiTatCa;
        private System.Windows.Forms.Button btnXoaLopA;
        private System.Windows.Forms.Button btnKetThuc;
        private System.Windows.Forms.Button btnXoaLopB;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblNgay;
        private System.Windows.Forms.ToolStripStatusLabel lblGio;
        private System.Windows.Forms.ToolStripStatusLabel lblNguoiThietKe;
        private System.Windows.Forms.Timer timer1;
    }
}
