namespace UngDungMDI
{
    partial class frmDocument
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
            this.rtfNoiDung = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();

            this.rtfNoiDung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtfNoiDung.Name = "rtfNoiDung";
            this.rtfNoiDung.TabIndex = 0;
            this.rtfNoiDung.Text = "";

            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 280);
            this.Controls.Add(this.rtfNoiDung);
            this.Name = "frmDocument";
            this.Text = "New Document";
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.RichTextBox rtfNoiDung;
    }
}
