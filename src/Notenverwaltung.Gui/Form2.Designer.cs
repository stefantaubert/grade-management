namespace GradeManagement.Gui
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.labelGroßeNotenschnitt = new System.Windows.Forms.Label();
            this.labelFächer = new System.Windows.Forms.Label();
            this.contextMenuEditFach = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ändernToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.löschenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelKleineNotenschnitt = new System.Windows.Forms.Label();
            this.textBoxGroßeNoten = new System.Windows.Forms.TextBox();
            this.contextMenuHalbjahre = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxKleineNoten = new System.Windows.Forms.TextBox();
            this.contextMenuFächer = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.matheToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deutschToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englischToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.französischToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.contextMenuHalbjahr = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.contextMenuEditFach.SuspendLayout();
            this.contextMenuHalbjahre.SuspendLayout();
            this.contextMenuFächer.SuspendLayout();
            this.contextMenuHalbjahr.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelGroßeNotenschnitt
            // 
            this.labelGroßeNotenschnitt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelGroßeNotenschnitt.BackColor = System.Drawing.Color.White;
            this.labelGroßeNotenschnitt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGroßeNotenschnitt.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelGroßeNotenschnitt.Location = new System.Drawing.Point(148, 39);
            this.labelGroßeNotenschnitt.Name = "labelGroßeNotenschnitt";
            this.labelGroßeNotenschnitt.Size = new System.Drawing.Size(41, 18);
            this.labelGroßeNotenschnitt.TabIndex = 6;
            this.labelGroßeNotenschnitt.Text = "6,25";
            this.labelGroßeNotenschnitt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelGroßeNotenschnitt.MouseClick += new System.Windows.Forms.MouseEventHandler(this.label5_MouseClick);
            this.labelGroßeNotenschnitt.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            // 
            // labelFächer
            // 
            this.labelFächer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelFächer.BackColor = System.Drawing.Color.Silver;
            this.labelFächer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelFächer.ContextMenuStrip = this.contextMenuEditFach;
            this.labelFächer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFächer.ForeColor = System.Drawing.Color.Black;
            this.labelFächer.Location = new System.Drawing.Point(0, 0);
            this.labelFächer.Name = "labelFächer";
            this.labelFächer.Size = new System.Drawing.Size(190, 20);
            this.labelFächer.TabIndex = 3;
            this.labelFächer.Text = "Mathe";
            this.labelFächer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelFächer.MouseClick += new System.Windows.Forms.MouseEventHandler(this.label3_MouseClick);
            // 
            // contextMenuEditFach
            // 
            this.contextMenuEditFach.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testToolStripMenuItem,
            this.ändernToolStripMenuItem,
            this.löschenToolStripMenuItem});
            this.contextMenuEditFach.Name = "contextMenuStrip1";
            this.contextMenuEditFach.ShowImageMargin = false;
            this.contextMenuEditFach.Size = new System.Drawing.Size(94, 70);
            this.contextMenuEditFach.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.testToolStripMenuItem.Text = "Neu";
            this.testToolStripMenuItem.Click += new System.EventHandler(this.testToolStripMenuItem_Click);
            // 
            // ändernToolStripMenuItem
            // 
            this.ändernToolStripMenuItem.Name = "ändernToolStripMenuItem";
            this.ändernToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.ändernToolStripMenuItem.Text = "Ändern";
            this.ändernToolStripMenuItem.Click += new System.EventHandler(this.ändernToolStripMenuItem_Click);
            // 
            // löschenToolStripMenuItem
            // 
            this.löschenToolStripMenuItem.Name = "löschenToolStripMenuItem";
            this.löschenToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.löschenToolStripMenuItem.Text = "Löschen";
            this.löschenToolStripMenuItem.Click += new System.EventHandler(this.löschenToolStripMenuItem_Click);
            // 
            // labelKleineNotenschnitt
            // 
            this.labelKleineNotenschnitt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelKleineNotenschnitt.BackColor = System.Drawing.Color.White;
            this.labelKleineNotenschnitt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKleineNotenschnitt.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelKleineNotenschnitt.Location = new System.Drawing.Point(148, 20);
            this.labelKleineNotenschnitt.Name = "labelKleineNotenschnitt";
            this.labelKleineNotenschnitt.Size = new System.Drawing.Size(41, 18);
            this.labelKleineNotenschnitt.TabIndex = 5;
            this.labelKleineNotenschnitt.Text = "10,25";
            this.labelKleineNotenschnitt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelKleineNotenschnitt.MouseClick += new System.Windows.Forms.MouseEventHandler(this.label1_MouseClick);
            this.labelKleineNotenschnitt.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            // 
            // textBoxGroßeNoten
            // 
            this.textBoxGroßeNoten.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxGroßeNoten.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxGroßeNoten.Location = new System.Drawing.Point(0, 38);
            this.textBoxGroßeNoten.Name = "textBoxGroßeNoten";
            this.textBoxGroßeNoten.Size = new System.Drawing.Size(190, 20);
            this.textBoxGroßeNoten.TabIndex = 1;
            this.textBoxGroßeNoten.Text = "15,12,5,2";
            this.toolTip1.SetToolTip(this.textBoxGroßeNoten, "doppelwertige Noten");
            this.textBoxGroßeNoten.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // contextMenuHalbjahre
            // 
            this.contextMenuHalbjahre.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6});
            this.contextMenuHalbjahre.Name = "contextMenuStrip4";
            this.contextMenuHalbjahre.ShowImageMargin = false;
            this.contextMenuHalbjahre.Size = new System.Drawing.Size(107, 92);
            this.contextMenuHalbjahre.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStrip4_ItemClicked);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(106, 22);
            this.toolStripMenuItem3.Text = "1. Halbjahr";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(106, 22);
            this.toolStripMenuItem4.Text = "2. Halbjahr";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(106, 22);
            this.toolStripMenuItem5.Text = "3. Halbjahr";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(106, 22);
            this.toolStripMenuItem6.Text = "4. Halbjahr";
            // 
            // textBoxKleineNoten
            // 
            this.textBoxKleineNoten.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxKleineNoten.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxKleineNoten.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxKleineNoten.Location = new System.Drawing.Point(0, 19);
            this.textBoxKleineNoten.Name = "textBoxKleineNoten";
            this.textBoxKleineNoten.ShortcutsEnabled = false;
            this.textBoxKleineNoten.Size = new System.Drawing.Size(190, 20);
            this.textBoxKleineNoten.TabIndex = 0;
            this.textBoxKleineNoten.Text = "2,12,6,8,12";
            this.toolTip1.SetToolTip(this.textBoxKleineNoten, "einwertige Noten");
            this.textBoxKleineNoten.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // contextMenuFächer
            // 
            this.contextMenuFächer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.matheToolStripMenuItem,
            this.deutschToolStripMenuItem,
            this.englischToolStripMenuItem,
            this.französischToolStripMenuItem});
            this.contextMenuFächer.Name = "contextMenuStrip3";
            this.contextMenuFächer.ShowImageMargin = false;
            this.contextMenuFächer.Size = new System.Drawing.Size(135, 92);
            this.contextMenuFächer.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip3_Opening);
            this.contextMenuFächer.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStrip3_ItemClicked);
            // 
            // matheToolStripMenuItem
            // 
            this.matheToolStripMenuItem.Name = "matheToolStripMenuItem";
            this.matheToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.matheToolStripMenuItem.Text = "Mathe";
            // 
            // deutschToolStripMenuItem
            // 
            this.deutschToolStripMenuItem.Name = "deutschToolStripMenuItem";
            this.deutschToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.deutschToolStripMenuItem.Text = "Deutsch";
            // 
            // englischToolStripMenuItem
            // 
            this.englischToolStripMenuItem.Name = "englischToolStripMenuItem";
            this.englischToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.englischToolStripMenuItem.Text = "Englisch";
            // 
            // französischToolStripMenuItem
            // 
            this.französischToolStripMenuItem.Name = "französischToolStripMenuItem";
            this.französischToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.französischToolStripMenuItem.Text = "12 :: Französisch";
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 30000;
            this.toolTip1.InitialDelay = 500;
            this.toolTip1.ReshowDelay = 100;
            // 
            // contextMenuHalbjahr
            // 
            this.contextMenuHalbjahr.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem7});
            this.contextMenuHalbjahr.Name = "contextMenuStrip4";
            this.contextMenuHalbjahr.ShowImageMargin = false;
            this.contextMenuHalbjahr.Size = new System.Drawing.Size(109, 48);
            this.contextMenuHalbjahr.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip5_Opening);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(108, 22);
            this.toolStripMenuItem1.Text = "Statistik";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(108, 22);
            this.toolStripMenuItem7.Text = "Exportieren";
            this.toolStripMenuItem7.Click += new System.EventHandler(this.toolStripMenuItem7_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "txt";
            this.saveFileDialog1.Filter = "Textdateien|*.txt";
            this.saveFileDialog1.RestoreDirectory = true;
            this.saveFileDialog1.Title = "Exportieren";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.ContextMenuStrip = this.contextMenuHalbjahr;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(0, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "12,8";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.labelGroßeNotenschnitt);
            this.panel1.Controls.Add(this.labelKleineNotenschnitt);
            this.panel1.Controls.Add(this.labelFächer);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBoxGroßeNoten);
            this.panel1.Controls.Add(this.textBoxKleineNoten);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(190, 77);
            this.panel1.TabIndex = 9;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 102);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 140);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(0, 140);
            this.Name = "Form2";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "1. Halbjahr";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.contextMenuEditFach.ResumeLayout(false);
            this.contextMenuHalbjahre.ResumeLayout(false);
            this.contextMenuFächer.ResumeLayout(false);
            this.contextMenuHalbjahr.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelFächer;
        private System.Windows.Forms.TextBox textBoxGroßeNoten;
        private System.Windows.Forms.Label labelGroßeNotenschnitt;
        private System.Windows.Forms.ContextMenuStrip contextMenuEditFach;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ändernToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem löschenToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuFächer;
        private System.Windows.Forms.ToolStripMenuItem matheToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deutschToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englischToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuHalbjahre;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripMenuItem französischToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuHalbjahr;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.Label labelKleineNotenschnitt;
        private System.Windows.Forms.TextBox textBoxKleineNoten;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}