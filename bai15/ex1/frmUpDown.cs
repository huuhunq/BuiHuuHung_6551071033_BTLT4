namespace UpDownControl
{
    public partial class frmUpDown : Form
    {
        public frmUpDown()
        {
            InitializeComponent();
        }

        private void frmUpDown_Load(object sender, EventArgs e)
        {
            dudColor.Items.Add("Black");
            dudColor.Items.Add("Red");
            dudColor.Items.Add("Blue");
            dudColor.Items.Add("Green");
            dudColor.SelectedIndex = 0;
            lblSampleText.Font = new Font(lblSampleText.Font.FontFamily, (float)nudSize.Value);
        }

        private void dudColor_SelectedItemChanged(object sender, EventArgs e)
        {
            DomainUpDown dudColor = (DomainUpDown)sender;
            lblSampleText.ForeColor = Color.FromName(dudColor.Text);
        }

        private void nudSize_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown nudSize = (NumericUpDown)sender;
            lblSampleText.Font = new Font(lblSampleText.Font.FontFamily, (float)nudSize.Value);
        }
    }
}
