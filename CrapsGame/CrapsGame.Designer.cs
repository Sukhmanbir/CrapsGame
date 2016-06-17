namespace CrapsGame
{
    partial class CrapsGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pointGroupBox = new System.Windows.Forms.GroupBox();
            this.pointFirstDiePictureBox = new System.Windows.Forms.PictureBox();
            this.pointSecondDiePictureBox = new System.Windows.Forms.PictureBox();
            this.rollFirstDiePictureBox = new System.Windows.Forms.PictureBox();
            this.rollSecondDiePictureBox = new System.Windows.Forms.PictureBox();
            this.playButton = new System.Windows.Forms.Button();
            this.rollButton = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.pointGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pointFirstDiePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointSecondDiePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rollFirstDiePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rollSecondDiePictureBox)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pointGroupBox
            // 
            this.pointGroupBox.Controls.Add(this.pointFirstDiePictureBox);
            this.pointGroupBox.Controls.Add(this.pointSecondDiePictureBox);
            this.pointGroupBox.Location = new System.Drawing.Point(43, 62);
            this.pointGroupBox.Name = "pointGroupBox";
            this.pointGroupBox.Size = new System.Drawing.Size(239, 155);
            this.pointGroupBox.TabIndex = 0;
            this.pointGroupBox.TabStop = false;
            this.pointGroupBox.Text = "Point";
            // 
            // pointFirstDiePictureBox
            // 
            this.pointFirstDiePictureBox.Location = new System.Drawing.Point(17, 36);
            this.pointFirstDiePictureBox.Name = "pointFirstDiePictureBox";
            this.pointFirstDiePictureBox.Size = new System.Drawing.Size(93, 84);
            this.pointFirstDiePictureBox.TabIndex = 0;
            this.pointFirstDiePictureBox.TabStop = false;
            // 
            // pointSecondDiePictureBox
            // 
            this.pointSecondDiePictureBox.Location = new System.Drawing.Point(129, 36);
            this.pointSecondDiePictureBox.Name = "pointSecondDiePictureBox";
            this.pointSecondDiePictureBox.Size = new System.Drawing.Size(93, 84);
            this.pointSecondDiePictureBox.TabIndex = 1;
            this.pointSecondDiePictureBox.TabStop = false;
            // 
            // rollFirstDiePictureBox
            // 
            this.rollFirstDiePictureBox.Location = new System.Drawing.Point(60, 292);
            this.rollFirstDiePictureBox.Name = "rollFirstDiePictureBox";
            this.rollFirstDiePictureBox.Size = new System.Drawing.Size(93, 84);
            this.rollFirstDiePictureBox.TabIndex = 2;
            this.rollFirstDiePictureBox.TabStop = false;
            this.rollFirstDiePictureBox.Click += new System.EventHandler(this.rollButton_Click);
            // 
            // rollSecondDiePictureBox
            // 
            this.rollSecondDiePictureBox.Location = new System.Drawing.Point(172, 292);
            this.rollSecondDiePictureBox.Name = "rollSecondDiePictureBox";
            this.rollSecondDiePictureBox.Size = new System.Drawing.Size(93, 84);
            this.rollSecondDiePictureBox.TabIndex = 3;
            this.rollSecondDiePictureBox.TabStop = false;
            this.rollSecondDiePictureBox.Click += new System.EventHandler(this.rollButton_Click);
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(330, 98);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(75, 23);
            this.playButton.TabIndex = 4;
            this.playButton.Text = "&Play";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // rollButton
            // 
            this.rollButton.Location = new System.Drawing.Point(330, 292);
            this.rollButton.Name = "rollButton";
            this.rollButton.Size = new System.Drawing.Size(75, 23);
            this.rollButton.TabIndex = 5;
            this.rollButton.Text = "&Roll";
            this.rollButton.UseVisualStyleBackColor = true;
            this.rollButton.Click += new System.EventHandler(this.rollButton_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.Location = new System.Drawing.Point(327, 334);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(195, 116);
            this.statusLabel.TabIndex = 6;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(568, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontToolStripMenuItem,
            this.colourToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.fontToolStripMenuItem.Text = "&Font";
            this.fontToolStripMenuItem.Click += new System.EventHandler(this.fontToolStripMenuItem_Click);
            // 
            // colourToolStripMenuItem
            // 
            this.colourToolStripMenuItem.Name = "colourToolStripMenuItem";
            this.colourToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.colourToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.colourToolStripMenuItem.Text = "Colou&r";
            this.colourToolStripMenuItem.Click += new System.EventHandler(this.colourToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // CrapsGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 501);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.rollButton);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.rollSecondDiePictureBox);
            this.Controls.Add(this.rollFirstDiePictureBox);
            this.Controls.Add(this.pointGroupBox);
            this.Controls.Add(this.menuStrip1);
            this.Name = "CrapsGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Craps Game";
            this.pointGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pointFirstDiePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointSecondDiePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rollFirstDiePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rollSecondDiePictureBox)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox pointGroupBox;
        private System.Windows.Forms.PictureBox pointFirstDiePictureBox;
        private System.Windows.Forms.PictureBox pointSecondDiePictureBox;
        private System.Windows.Forms.PictureBox rollFirstDiePictureBox;
        private System.Windows.Forms.PictureBox rollSecondDiePictureBox;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button rollButton;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colourToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
    }
}

