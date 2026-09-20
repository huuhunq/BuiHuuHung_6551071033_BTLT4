namespace UngDungMDI
{
    public partial class frmDocument : Form
    {
        public frmDocument()
        {
            InitializeComponent();
        }

        public void MoTapTin(string tenTapTin)
        {
            if (tenTapTin.ToLower().EndsWith(".rtf"))
                rtfNoiDung.LoadFile(tenTapTin);
            else
                rtfNoiDung.Text = File.ReadAllText(tenTapTin);
        }

        public Font LayFont()
        {
            return rtfNoiDung.SelectionFont == null ? rtfNoiDung.Font : rtfNoiDung.SelectionFont;
        }

        public void DatFont(Font f)
        {
            if (rtfNoiDung.SelectionLength > 0)
                rtfNoiDung.SelectionFont = f;
            else
                rtfNoiDung.Font = f;
        }
    }
}
