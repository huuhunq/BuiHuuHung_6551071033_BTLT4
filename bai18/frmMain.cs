namespace UngDungMDI
{
    public partial class frmMain : Form
    {
        int soCuaSo = 0;

        public frmMain()
        {
            InitializeComponent();
        }

        frmDocument taoCuaSoMoi()
        {
            soCuaSo = soCuaSo + 1;
            frmDocument f = new frmDocument();
            f.Text = "New Document " + soCuaSo;
            f.MdiParent = this;
            f.Show();
            return f;
        }

        private void mnuFileNew_Click(object sender, EventArgs e)
        {
            taoCuaSoMoi();
        }

        private void mnuFileOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpenFile = new OpenFileDialog();
            dlgOpenFile.Filter = "Rich Text Files (*.rtf)|*.rtf|Text Files (*.txt)|*.txt";
            if (dlgOpenFile.ShowDialog() == DialogResult.OK)
            {
                frmDocument f = taoCuaSoMoi();
                f.Text = dlgOpenFile.FileName;
                f.MoTapTin(dlgOpenFile.FileName);
            }
        }

        private void mnuFileExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnuFormatFont_Click(object sender, EventArgs e)
        {
            frmDocument f = (frmDocument)this.ActiveMdiChild;
            if (f == null)
            {
                MessageBox.Show("Chua co cua so nao duoc mo!", "Chu y");
                return;
            }

            FontDialog dlgFont = new FontDialog();
            dlgFont.Font = f.LayFont();
            if (dlgFont.ShowDialog() == DialogResult.OK)
                f.DatFont(dlgFont.Font);
        }

        private void mnuWindowTileH_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void mnuWindowTileV_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void mnuWindowCascade_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void mnuHelpAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Creating an MDI Application", "About",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
