
namespace Ez_M3U_Player
{
    partial class Form1
    {
        private const string V = "Form1";

        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.fileDialog = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listLimitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maxItemBox = new System.Windows.Forms.ToolStripTextBox();
            this.vLCPathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vlcPathBox = new System.Windows.Forms.ToolStripTextBox();
            this.helpBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.findLabel = new System.Windows.Forms.Label();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.listView = new System.Windows.Forms.ListView();
            this.cname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.link = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.infoLabel = new System.Windows.Forms.Label();
            this.versLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileDialog
            // 
            this.fileDialog.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(519, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(121, 24);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listLimitToolStripMenuItem,
            this.vLCPathToolStripMenuItem,
            this.helpBtn});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // listLimitToolStripMenuItem
            // 
            this.listLimitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.maxItemBox});
            this.listLimitToolStripMenuItem.Name = "listLimitToolStripMenuItem";
            this.listLimitToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.listLimitToolStripMenuItem.Text = "List Limit";
            // 
            // maxItemBox
            // 
            this.maxItemBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.maxItemBox.Name = "maxItemBox";
            this.maxItemBox.Size = new System.Drawing.Size(100, 23);
            this.maxItemBox.Text = "100";
            // 
            // vLCPathToolStripMenuItem
            // 
            this.vLCPathToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vlcPathBox});
            this.vLCPathToolStripMenuItem.Name = "vLCPathToolStripMenuItem";
            this.vLCPathToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.vLCPathToolStripMenuItem.Text = "VLC Path";
            // 
            // vlcPathBox
            // 
            this.vlcPathBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.vlcPathBox.Name = "vlcPathBox";
            this.vlcPathBox.Size = new System.Drawing.Size(100, 23);
            // 
            // helpBtn
            // 
            this.helpBtn.Name = "helpBtn";
            this.helpBtn.Size = new System.Drawing.Size(180, 24);
            this.helpBtn.Text = "Help";
            this.helpBtn.Click += new System.EventHandler(this.helpBtn_Click);
            // 
            // findLabel
            // 
            this.findLabel.AutoSize = true;
            this.findLabel.Font = new System.Drawing.Font("Ubuntu", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findLabel.Location = new System.Drawing.Point(18, 43);
            this.findLabel.Name = "findLabel";
            this.findLabel.Size = new System.Drawing.Size(87, 26);
            this.findLabel.TabIndex = 1;
            this.findLabel.Text = "Search: ";
            // 
            // searchBox
            // 
            this.searchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBox.Location = new System.Drawing.Point(101, 43);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(100, 26);
            this.searchBox.TabIndex = 2;
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.Transparent;
            this.btnPlay.Font = new System.Drawing.Font("Ubuntu Light", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.ForeColor = System.Drawing.Color.DarkRed;
            this.btnPlay.Location = new System.Drawing.Point(374, 37);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(133, 39);
            this.btnPlay.TabIndex = 5;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cname,
            this.link});
            this.listView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(12, 85);
            this.listView.MultiSelect = false;
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(495, 484);
            this.listView.TabIndex = 6;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // cname
            // 
            this.cname.Tag = "cname";
            this.cname.Text = "Name";
            this.cname.Width = 177;
            // 
            // link
            // 
            this.link.Tag = "link";
            this.link.Text = "Link";
            this.link.Width = 306;
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Font = new System.Drawing.Font("Ubuntu", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoLabel.Location = new System.Drawing.Point(13, 576);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(0, 16);
            this.infoLabel.TabIndex = 7;
            // 
            // versLabel
            // 
            this.versLabel.AutoSize = true;
            this.versLabel.Font = new System.Drawing.Font("Ubuntu", 8.999999F);
            this.versLabel.Location = new System.Drawing.Point(439, 576);
            this.versLabel.Name = "versLabel";
            this.versLabel.Size = new System.Drawing.Size(69, 16);
            this.versLabel.TabIndex = 9;
            this.versLabel.Text = "Version 1.2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(519, 603);
            this.Controls.Add(this.versLabel);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.findLabel);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ez M3U Player";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.formClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog fileDialog;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.Label findLabel;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader cname;
        private System.Windows.Forms.ColumnHeader link;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.ToolStripMenuItem vLCPathToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox vlcPathBox;
        private System.Windows.Forms.ToolStripMenuItem helpBtn;
        private System.Windows.Forms.ToolStripMenuItem listLimitToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox maxItemBox;
        private System.Windows.Forms.Label versLabel;
    }
}

