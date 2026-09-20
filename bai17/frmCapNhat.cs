namespace DanhSachMenu
{
    public partial class frmCapNhat : Form
    {
        public frmCapNhat()
        {
            InitializeComponent();
        }

        private void frmCapNhat_Load(object sender, EventArgs e)
        {
            lblNgay.Text = DateTime.Now.ToShortDateString();
            lblGio.Text = DateTime.Now.ToLongTimeString();
            txtTen.Focus();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblNgay.Text = DateTime.Now.ToShortDateString();
            lblGio.Text = DateTime.Now.ToLongTimeString();
        }

        void chuyenDuLieu(ListBox lst1, ListBox lst2)
        {
            int i = 0;
            while (i < lst1.Items.Count)
                if (lst1.GetSelected(i))
                {
                    string stDuLieu = lst1.Items[i].ToString();
                    lst2.Items.Add(stDuLieu);
                    lst1.Items.RemoveAt(i);
                }
                else
                    i++;
        }

        void chuyenToanBo(ListBox lst1, ListBox lst2)
        {
            while (lst1.Items.Count != 0)
            {
                string stDuLieu = lst1.Items[0].ToString();
                lst2.Items.Add(stDuLieu);
                lst1.Items.RemoveAt(0);
            }
        }

        void xoaDuLieu(ListBox lst)
        {
            int i = 0;
            while (i < lst.Items.Count)
                if (lst.GetSelected(i))
                    lst.Items.RemoveAt(i);
                else
                    i++;
        }

        void themVaoLop(ListBox lst)
        {
            if (txtTen.Text == "")
            {
                MessageBox.Show("Bạn ko được phép nhập dữ liệu rỗng!", "Thông Báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTen.Focus();
            }
            else
            {
                string strDuLieu = txtTen.Text;
                lst.Items.Add(strDuLieu);
                txtTen.Clear();
                txtTen.Focus();
            }
        }

        void hoiChuyenChon(ListBox lst1, ListBox lst2)
        {
            DialogResult hoiChuyen;
            if (lst1.Items.Count > 0)
            {
                hoiChuyen = MessageBox.Show("Bạn có chắc chuyển những dữ liệu đang chọn ko?", "Thông Báo",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (hoiChuyen == DialogResult.Yes)
                    chuyenDuLieu(lst1, lst2);
            }
            else
                MessageBox.Show("Danh sách hiện đang rỗng!", "Chú ý");
        }

        void hoiChuyenHet(ListBox lst1, ListBox lst2)
        {
            DialogResult hoiChuyen;
            if (lst1.Items.Count > 0)
            {
                hoiChuyen = MessageBox.Show("Bạn có chắc chuyển toàn bộ dữ liệu ko?", "Thông Báo",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (hoiChuyen == DialogResult.Yes)
                    chuyenToanBo(lst1, lst2);
            }
            else
                MessageBox.Show("Danh sách hiện đang rỗng!", "Chú ý");
        }

        void hoiXoa(ListBox lst)
        {
            DialogResult traLoi;
            if (lst.Items.Count > 0)
            {
                traLoi = MessageBox.Show("Bạn có chắc xóa những phần tử này?", "Chú ý",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (traLoi == DialogResult.Yes)
                    xoaDuLieu(lst);
            }
            else
                MessageBox.Show("Hiện danh sách đang rỗng!", "Chú ý");
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            themVaoLop(lstLopA);
        }

        private void btnPhai1_Click(object sender, EventArgs e)
        {
            hoiChuyenChon(lstLopA, lstLopB);
        }

        private void btnTrai1_Click(object sender, EventArgs e)
        {
            hoiChuyenChon(lstLopB, lstLopA);
        }

        private void btnPhaiTatCa_Click(object sender, EventArgs e)
        {
            hoiChuyenHet(lstLopA, lstLopB);
        }

        private void btnTraiTatCa_Click(object sender, EventArgs e)
        {
            hoiChuyenHet(lstLopB, lstLopA);
        }

        private void btnXoaLopA_Click(object sender, EventArgs e)
        {
            hoiXoa(lstLopA);
        }

        private void btnXoaLopB_Click(object sender, EventArgs e)
        {
            hoiXoa(lstLopB);
        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCapNhat_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dl;
            dl = MessageBox.Show("Có chắc bạn muốn đóng ứng dụng?", "Thông báo!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (dl == DialogResult.No)
                e.Cancel = true;
        }

        private void mnuCapNhatLopA_Click(object sender, EventArgs e)
        {
            themVaoLop(lstLopA);
        }

        private void mnuCapNhatLopB_Click(object sender, EventArgs e)
        {
            themVaoLop(lstLopB);
        }

        private void mnuChuyenChonA_Click(object sender, EventArgs e)
        {
            btnTrai1_Click(sender, e);
        }

        private void mnuChuyenChonB_Click(object sender, EventArgs e)
        {
            btnPhai1_Click(sender, e);
        }

        private void mnuChuyenHetA_Click(object sender, EventArgs e)
        {
            btnTraiTatCa_Click(sender, e);
        }

        private void mnuChuyenHetB_Click(object sender, EventArgs e)
        {
            btnPhaiTatCa_Click(sender, e);
        }

        private void mnuXoaDsLopA_Click(object sender, EventArgs e)
        {
            btnXoaLopA_Click(sender, e);
        }

        private void mnuXoaDsLopB_Click(object sender, EventArgs e)
        {
            btnXoaLopB_Click(sender, e);
        }

        private void mnuThongTin_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Họ tên: Võ Hồng Thiên\nMSSV: 6551071078\nLớp: Lập trình trực quan",
                "Thông Tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void mnuKetThuc_Click(object sender, EventArgs e)
        {
            btnKetThuc_Click(sender, e);
        }
    }
}
