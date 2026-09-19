namespace CalendarControl
{
    partial class frmCalendar
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
            this.lblChon = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.lblStartCap = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Label();
            this.lblEndCap = new System.Windows.Forms.Label();
            this.lblEnd = new System.Windows.Forms.Label();
            this.lblLaunch = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.radLongDate = new System.Windows.Forms.RadioButton();
            this.radShortDate = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();

            this.lblChon.AutoSize = true;
            this.lblChon.Location = new System.Drawing.Point(15, 12);
            this.lblChon.Name = "lblChon";
            this.lblChon.Text = "Select the days you will travel:";

            this.monthCalendar1.Location = new System.Drawing.Point(15, 42);
            this.monthCalendar1.MaxSelectionCount = 14;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);

            this.lblStartCap.AutoSize = true;
            this.lblStartCap.Location = new System.Drawing.Point(275, 42);
            this.lblStartCap.Name = "lblStartCap";
            this.lblStartCap.Text = "StartDate:";

            this.lblStart.AutoSize = true;
            this.lblStart.Location = new System.Drawing.Point(275, 67);
            this.lblStart.Name = "lblStart";
            this.lblStart.Text = "";

            this.lblEndCap.AutoSize = true;
            this.lblEndCap.Location = new System.Drawing.Point(275, 102);
            this.lblEndCap.Name = "lblEndCap";
            this.lblEndCap.Text = "End Date:";

            this.lblEnd.AutoSize = true;
            this.lblEnd.Location = new System.Drawing.Point(275, 127);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Text = "";

            this.lblLaunch.AutoSize = true;
            this.lblLaunch.Location = new System.Drawing.Point(15, 245);
            this.lblLaunch.Name = "lblLaunch";
            this.lblLaunch.Text = "Product Launch Date:";

            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateTimePicker1.Location = new System.Drawing.Point(15, 272);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(300, 27);
            this.dateTimePicker1.TabIndex = 1;

            this.radLongDate.AutoSize = true;
            this.radLongDate.Checked = true;
            this.radLongDate.Location = new System.Drawing.Point(18, 312);
            this.radLongDate.Name = "radLongDate";
            this.radLongDate.TabIndex = 2;
            this.radLongDate.TabStop = true;
            this.radLongDate.Text = "Long Date";
            this.radLongDate.CheckedChanged += new System.EventHandler(this.radDate_CheckedChanged);

            this.radShortDate.AutoSize = true;
            this.radShortDate.Location = new System.Drawing.Point(180, 312);
            this.radShortDate.Name = "radShortDate";
            this.radShortDate.TabIndex = 3;
            this.radShortDate.Text = "Short Date";
            this.radShortDate.CheckedChanged += new System.EventHandler(this.radDate_CheckedChanged);

            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 350);
            this.Controls.Add(this.lblChon);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.lblStartCap);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.lblEndCap);
            this.Controls.Add(this.lblEnd);
            this.Controls.Add(this.lblLaunch);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.radLongDate);
            this.Controls.Add(this.radShortDate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmCalendar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StepByStep2_13";
            this.Load += new System.EventHandler(this.frmCalendar_Load);
        }

        #endregion

        private System.Windows.Forms.Label lblChon;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label lblStartCap;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblEndCap;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.Label lblLaunch;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RadioButton radLongDate;
        private System.Windows.Forms.RadioButton radShortDate;
    }
}
