namespace UngDungMDI
{
    partial class frmMain
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
            this.mnuMainMenu = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileNew = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileSep = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFormat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFormatFont = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuWindowTileH = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuWindowTileV = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuWindowCascade = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuWindowSep = new System.Windows.Forms.ToolStripSeparator();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMainMenu.SuspendLayout();
            this.SuspendLayout();

            this.mnuMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.mnuFile,
                this.mnuFormat,
                this.mnuWindow,
                this.mnuHelp});
            this.mnuMainMenu.Location = new System.Drawing.Point(0, 0);
            this.mnuMainMenu.MdiWindowListItem = this.mnuWindow;
            this.mnuMainMenu.Name = "mnuMainMenu";
            this.mnuMainMenu.Size = new System.Drawing.Size(784, 28);
            this.mnuMainMenu.TabIndex = 0;

            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.mnuFileNew,
                this.mnuFileOpen,
                this.mnuFileSep,
                this.mnuFileExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Text = "&File";

            this.mnuFileNew.Name = "mnuFileNew";
            this.mnuFileNew.Text = "&New";
            this.mnuFileNew.ShortcutKeys = ((System.Windows.Forms.Keys)(
                (System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.mnuFileNew.Click += new System.EventHandler(this.mnuFileNew_Click);

            this.mnuFileOpen.Name = "mnuFileOpen";
            this.mnuFileOpen.Text = "&Open...";
            this.mnuFileOpen.ShortcutKeys = ((System.Windows.Forms.Keys)(
                (System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.mnuFileOpen.Click += new System.EventHandler(this.mnuFileOpen_Click);

            this.mnuFileSep.Name = "mnuFileSep";

            this.mnuFileExit.Name = "mnuFileExit";
            this.mnuFileExit.Text = "E&xit";
            this.mnuFileExit.Click += new System.EventHandler(this.mnuFileExit_Click);

            this.mnuFormat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.mnuFormatFont});
            this.mnuFormat.Name = "mnuFormat";
            this.mnuFormat.Text = "F&ormat";

            this.mnuFormatFont.Name = "mnuFormatFont";
            this.mnuFormatFont.Text = "&Font...";
            this.mnuFormatFont.Click += new System.EventHandler(this.mnuFormatFont_Click);

            this.mnuWindow.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.mnuWindowTileH,
                this.mnuWindowTileV,
                this.mnuWindowCascade,
                this.mnuWindowSep});
            this.mnuWindow.Name = "mnuWindow";
            this.mnuWindow.Text = "&Window";

            this.mnuWindowTileH.Name = "mnuWindowTileH";
            this.mnuWindowTileH.Text = "Tile Horizontally";
            this.mnuWindowTileH.Click += new System.EventHandler(this.mnuWindowTileH_Click);

            this.mnuWindowTileV.Name = "mnuWindowTileV";
            this.mnuWindowTileV.Text = "Tile Vertically";
            this.mnuWindowTileV.Click += new System.EventHandler(this.mnuWindowTileV_Click);

            this.mnuWindowCascade.Name = "mnuWindowCascade";
            this.mnuWindowCascade.Text = "Cascade";
            this.mnuWindowCascade.Click += new System.EventHandler(this.mnuWindowCascade_Click);

            this.mnuWindowSep.Name = "mnuWindowSep";

            this.mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.mnuHelpAbout});
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Text = "&Help";

            this.mnuHelpAbout.Name = "mnuHelpAbout";
            this.mnuHelpAbout.Text = "&About...";
            this.mnuHelpAbout.Click += new System.EventHandler(this.mnuHelpAbout_Click);

            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 480);
            this.Controls.Add(this.mnuMainMenu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnuMainMenu;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StepByStep2_22";

            this.mnuMainMenu.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMainMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuFileNew;
        private System.Windows.Forms.ToolStripMenuItem mnuFileOpen;
        private System.Windows.Forms.ToolStripSeparator mnuFileSep;
        private System.Windows.Forms.ToolStripMenuItem mnuFileExit;
        private System.Windows.Forms.ToolStripMenuItem mnuFormat;
        private System.Windows.Forms.ToolStripMenuItem mnuFormatFont;
        private System.Windows.Forms.ToolStripMenuItem mnuWindow;
        private System.Windows.Forms.ToolStripMenuItem mnuWindowTileH;
        private System.Windows.Forms.ToolStripMenuItem mnuWindowTileV;
        private System.Windows.Forms.ToolStripMenuItem mnuWindowCascade;
        private System.Windows.Forms.ToolStripSeparator mnuWindowSep;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.ToolStripMenuItem mnuHelpAbout;
    }
}
