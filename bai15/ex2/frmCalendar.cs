namespace CalendarControl
{
    public partial class frmCalendar : Form
    {
        public frmCalendar()
        {
            InitializeComponent();
        }

        private void frmCalendar_Load(object sender, EventArgs e)
        {
            lblStart.Text = monthCalendar1.SelectionStart.ToShortDateString();
            lblEnd.Text = monthCalendar1.SelectionEnd.ToShortDateString();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            lblStart.Text = monthCalendar1.SelectionStart.ToShortDateString();
            lblEnd.Text = monthCalendar1.SelectionEnd.ToShortDateString();
        }

        private void radDate_CheckedChanged(object sender, EventArgs e)
        {
            if (radLongDate.Checked)
                dateTimePicker1.Format = DateTimePickerFormat.Long;
            else
                dateTimePicker1.Format = DateTimePickerFormat.Short;
        }
    }
}
