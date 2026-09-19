namespace UpDownControl
{
    partial class frmUpDown
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
            this.lblColor = new System.Windows.Forms.Label();
            this.dudColor = new System.Windows.Forms.DomainUpDown();
            this.lblSize = new System.Windows.Forms.Label();
            this.nudSize = new System.Windows.Forms.NumericUpDown();
            this.lblSampleText = new System.Windows.Forms.Label();
            this.SuspendLayout();

            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(30, 40);
            this.lblColor.Name = "lblColor";
            this.lblColor.Text = "Color:";

            this.dudColor.Location = new System.Drawing.Point(200, 37);
            this.dudColor.Name = "dudColor";
            this.dudColor.Size = new System.Drawing.Size(170, 27);
            this.dudColor.TabIndex = 0;
            this.dudColor.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.dudColor.SelectedItemChanged += new System.EventHandler(this.dudColor_SelectedItemChanged);

            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(30, 95);
            this.lblSize.Name = "lblSize";
            this.lblSize.Text = "Size:";

            this.nudSize.Location = new System.Drawing.Point(200, 92);
            this.nudSize.Maximum = new decimal(new int[] { 72, 0, 0, 0 });
            this.nudSize.Minimum = new decimal(new int[] { 8, 0, 0, 0 });
            this.nudSize.Name = "nudSize";
            this.nudSize.Size = new System.Drawing.Size(170, 27);
            this.nudSize.TabIndex = 1;
            this.nudSize.Value = new decimal(new int[] { 16, 0, 0, 0 });
            this.nudSize.ValueChanged += new System.EventHandler(this.nudSize_ValueChanged);

            this.lblSampleText.Location = new System.Drawing.Point(30, 150);
            this.lblSampleText.Name = "lblSampleText";
            this.lblSampleText.Size = new System.Drawing.Size(340, 50);
            this.lblSampleText.Text = "Sample Text";
            this.lblSampleText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 220);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.dudColor);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.nudSize);
            this.Controls.Add(this.lblSampleText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmUpDown";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StepByStep2_12";
            this.Load += new System.EventHandler(this.frmUpDown_Load);
        }

        #endregion

        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.DomainUpDown dudColor;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.NumericUpDown nudSize;
        private System.Windows.Forms.Label lblSampleText;
    }
}
