namespace ThanhTrangThai
{
    public partial class frmTrangThai : Form
    {
        public frmTrangThai()
        {
            InitializeComponent();
        }

        private void frmTrangThai_Load(object sender, EventArgs e)
        {
            capNhatGio();
        }

        void capNhatGio()
        {
            pnlNgay.Text = DateTime.Now.ToLongDateString();
            pnlGio.Text = DateTime.Now.ToShortTimeString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            capNhatGio();
        }

        private void mnuFileNew_Click(object sender, EventArgs e)
        {
            rtfNoiDung.Clear();
            pnlTrangThai.Text = "New";
        }

        private void mnuFileExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnuEditCut_Click(object sender, EventArgs e)
        {
            rtfNoiDung.Cut();
            pnlTrangThai.Text = "Cut";
        }

        private void mnuEditCopy_Click(object sender, EventArgs e)
        {
            rtfNoiDung.Copy();
            pnlTrangThai.Text = "Copy";
        }

        private void mnuEditPaste_Click(object sender, EventArgs e)
        {
            rtfNoiDung.Paste();
            pnlTrangThai.Text = "Paste";
        }

        private void mnuFormatFont_Click(object sender, EventArgs e)
        {
            FontDialog dlgFont = new FontDialog();
            dlgFont.Font = rtfNoiDung.Font;
            if (dlgFont.ShowDialog() == DialogResult.OK)
                rtfNoiDung.Font = dlgFont.Font;
            pnlTrangThai.Text = "Font";
        }

        private void mnuHelpAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Creating a Status Bar for a Form", "About",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpenFile = new OpenFileDialog();
            dlgOpenFile.Filter = "Rich Text Files (*.rtf)|*.rtf|Text Files (*.txt)|*.txt";
            if (dlgOpenFile.ShowDialog() == DialogResult.OK)
            {
                if (dlgOpenFile.FileName.ToLower().EndsWith(".rtf"))
                    rtfNoiDung.LoadFile(dlgOpenFile.FileName);
                else
                    rtfNoiDung.Text = File.ReadAllText(dlgOpenFile.FileName);
                pnlTrangThai.Text = "Open";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlgSaveFile = new SaveFileDialog();
            dlgSaveFile.Filter = "Rich Text Files (*.rtf)|*.rtf|Text Files (*.txt)|*.txt";
            if (dlgSaveFile.ShowDialog() == DialogResult.OK)
            {
                if (dlgSaveFile.FileName.ToLower().EndsWith(".rtf"))
                    rtfNoiDung.SaveFile(dlgSaveFile.FileName);
                else
                    File.WriteAllText(dlgSaveFile.FileName, rtfNoiDung.Text);
                pnlTrangThai.Text = "Save";
            }
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            rtfNoiDung.Undo();
            pnlTrangThai.Text = "Undo";
        }

        private void btnRedo_Click(object sender, EventArgs e)
        {
            rtfNoiDung.Redo();
            pnlTrangThai.Text = "Redo";
        }
    }
}
