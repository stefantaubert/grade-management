namespace NeueNotenverwaltung
{
    partial class FormNeu
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
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.neuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ändernToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.löschenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.halbjahrAuswählenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.alleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.statistikToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cBFächer = new System.Windows.Forms.ComboBox();
            this.textBoxKA = new System.Windows.Forms.TextBox();
            this.textBoxLK = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lLK = new System.Windows.Forms.TextBox();
            this.lKA = new System.Windows.Forms.TextBox();
            this.lGes = new System.Windows.Forms.TextBox();
            this.tB1 = new System.Windows.Forms.TextBox();
            this.tB3 = new System.Windows.Forms.TextBox();
            this.tB2 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.neuToolStripMenuItem,
            this.ändernToolStripMenuItem,
            this.löschenToolStripMenuItem,
            this.toolStripSeparator1,
            this.halbjahrAuswählenToolStripMenuItem,
            this.toolStripSeparator2,
            this.statistikToolStripMenuItem1});
            this.contextMenuStrip.Name = "contextMenuStrip2";
            this.contextMenuStrip.Size = new System.Drawing.Size(179, 126);
            // 
            // neuToolStripMenuItem
            // 
            this.neuToolStripMenuItem.Name = "neuToolStripMenuItem";
            this.neuToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.neuToolStripMenuItem.Text = "Fach hinzufügen";
            this.neuToolStripMenuItem.Click += new System.EventHandler(this.neuToolStripMenuItem_Click);
            // 
            // ändernToolStripMenuItem
            // 
            this.ändernToolStripMenuItem.Name = "ändernToolStripMenuItem";
            this.ändernToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.ändernToolStripMenuItem.Text = "Fach ändern";
            this.ändernToolStripMenuItem.Click += new System.EventHandler(this.ändernToolStripMenuItem_Click);
            // 
            // löschenToolStripMenuItem
            // 
            this.löschenToolStripMenuItem.Name = "löschenToolStripMenuItem";
            this.löschenToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.löschenToolStripMenuItem.Text = "Fach löschen";
            this.löschenToolStripMenuItem.Click += new System.EventHandler(this.löschenToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(175, 6);
            // 
            // halbjahrAuswählenToolStripMenuItem
            // 
            this.halbjahrAuswählenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.alleToolStripMenuItem});
            this.halbjahrAuswählenToolStripMenuItem.Name = "halbjahrAuswählenToolStripMenuItem";
            this.halbjahrAuswählenToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.halbjahrAuswählenToolStripMenuItem.Text = "Halbjahr auswählen";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(92, 22);
            this.toolStripMenuItem2.Text = "1";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(92, 22);
            this.toolStripMenuItem3.Text = "2";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(92, 22);
            this.toolStripMenuItem4.Text = "3";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(92, 22);
            this.toolStripMenuItem5.Text = "4";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // alleToolStripMenuItem
            // 
            this.alleToolStripMenuItem.Name = "alleToolStripMenuItem";
            this.alleToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.alleToolStripMenuItem.Text = "alle";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(175, 6);
            // 
            // statistikToolStripMenuItem1
            // 
            this.statistikToolStripMenuItem1.Name = "statistikToolStripMenuItem1";
            this.statistikToolStripMenuItem1.Size = new System.Drawing.Size(178, 22);
            this.statistikToolStripMenuItem1.Text = "Statistik";
            this.statistikToolStripMenuItem1.Click += new System.EventHandler(this.statistikToolStripMenuItem1_Click);
            // 
            // cBFächer
            // 
            this.cBFächer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cBFächer.ContextMenuStrip = this.contextMenuStrip;
            this.cBFächer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBFächer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.6F, System.Drawing.FontStyle.Bold);
            this.cBFächer.Items.AddRange(new object[] {
            "12/I",
            "12/II",
            "13/I",
            "13/II"});
            this.cBFächer.Location = new System.Drawing.Point(9, 10);
            this.cBFächer.Margin = new System.Windows.Forms.Padding(2);
            this.cBFächer.Name = "cBFächer";
            this.cBFächer.Size = new System.Drawing.Size(406, 28);
            this.cBFächer.TabIndex = 23;
            this.toolTip1.SetToolTip(this.cBFächer, "Fächer");
            this.cBFächer.SelectedIndexChanged += new System.EventHandler(this.cB1_SelectedIndexChanged);
            // 
            // textBoxKA
            // 
            this.textBoxKA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxKA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxKA.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.7F);
            this.textBoxKA.Location = new System.Drawing.Point(9, 64);
            this.textBoxKA.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxKA.Name = "textBoxKA";
            this.textBoxKA.ShortcutsEnabled = false;
            this.textBoxKA.Size = new System.Drawing.Size(406, 28);
            this.textBoxKA.TabIndex = 38;
            this.toolTip1.SetToolTip(this.textBoxKA, "Klausuren");
            this.textBoxKA.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxLK
            // 
            this.textBoxLK.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxLK.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.7F);
            this.textBoxLK.Location = new System.Drawing.Point(9, 37);
            this.textBoxLK.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxLK.Name = "textBoxLK";
            this.textBoxLK.ShortcutsEnabled = false;
            this.textBoxLK.Size = new System.Drawing.Size(406, 28);
            this.textBoxLK.TabIndex = 35;
            this.toolTip1.SetToolTip(this.textBoxLK, "einwertiges");
            this.textBoxLK.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(189, 105);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 128);
            this.label5.TabIndex = 47;
            this.label5.Text = "nächste LK:\r\n0-5 KMK -> 13 KMK\r\n6-10 KMK -> 14 KMK\r\n\r\nnächste KA:\r\n0-5 KMK -> 9 K" +
                "MK\r\n5-10 KMK -> 13 KMK\r\n10-15 KMK -> 14 KMK\r\n";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lLK
            // 
            this.lLK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lLK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lLK.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.7F);
            this.lLK.Location = new System.Drawing.Point(414, 37);
            this.lLK.Margin = new System.Windows.Forms.Padding(2);
            this.lLK.Name = "lLK";
            this.lLK.ReadOnly = true;
            this.lLK.ShortcutsEnabled = false;
            this.lLK.Size = new System.Drawing.Size(55, 28);
            this.lLK.TabIndex = 49;
            this.lLK.Text = "12,21";
            this.lLK.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.lLK, "einwertiges");
            // 
            // lKA
            // 
            this.lKA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lKA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lKA.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.7F);
            this.lKA.Location = new System.Drawing.Point(414, 64);
            this.lKA.Margin = new System.Windows.Forms.Padding(2);
            this.lKA.Name = "lKA";
            this.lKA.ReadOnly = true;
            this.lKA.ShortcutsEnabled = false;
            this.lKA.Size = new System.Drawing.Size(55, 28);
            this.lKA.TabIndex = 50;
            this.lKA.Text = "12,21";
            this.lKA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.lKA, "einwertiges");
            // 
            // lGes
            // 
            this.lGes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lGes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lGes.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.7F, System.Drawing.FontStyle.Bold);
            this.lGes.ForeColor = System.Drawing.Color.Red;
            this.lGes.Location = new System.Drawing.Point(414, 10);
            this.lGes.Margin = new System.Windows.Forms.Padding(2);
            this.lGes.Name = "lGes";
            this.lGes.ReadOnly = true;
            this.lGes.ShortcutsEnabled = false;
            this.lGes.Size = new System.Drawing.Size(55, 28);
            this.lGes.TabIndex = 51;
            this.lGes.Text = "12,21";
            this.lGes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.lGes, "Gesamt Schnitt des Faches");
            // 
            // tB1
            // 
            this.tB1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tB1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tB1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.7F, System.Drawing.FontStyle.Bold);
            this.tB1.Location = new System.Drawing.Point(468, 10);
            this.tB1.Margin = new System.Windows.Forms.Padding(2);
            this.tB1.Name = "tB1";
            this.tB1.ReadOnly = true;
            this.tB1.ShortcutsEnabled = false;
            this.tB1.Size = new System.Drawing.Size(55, 28);
            this.tB1.TabIndex = 54;
            this.tB1.Text = "2,24";
            this.tB1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.tB1, "Gesamt Schnitt des Faches");
            // 
            // tB3
            // 
            this.tB3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tB3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tB3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.7F);
            this.tB3.Location = new System.Drawing.Point(468, 64);
            this.tB3.Margin = new System.Windows.Forms.Padding(2);
            this.tB3.Name = "tB3";
            this.tB3.ReadOnly = true;
            this.tB3.ShortcutsEnabled = false;
            this.tB3.Size = new System.Drawing.Size(55, 28);
            this.tB3.TabIndex = 53;
            this.tB3.Text = "2,24";
            this.tB3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.tB3, "einwertiges");
            // 
            // tB2
            // 
            this.tB2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tB2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tB2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.7F);
            this.tB2.Location = new System.Drawing.Point(468, 37);
            this.tB2.Margin = new System.Windows.Forms.Padding(2);
            this.tB2.Name = "tB2";
            this.tB2.ReadOnly = true;
            this.tB2.ShortcutsEnabled = false;
            this.tB2.Size = new System.Drawing.Size(55, 28);
            this.tB2.TabIndex = 52;
            this.tB2.Text = "2,24";
            this.tB2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.tB2, "einwertiges");
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 148);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 17);
            this.listBox1.TabIndex = 55;
            // 
            // FormNeu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(531, 255);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lGes);
            this.Controls.Add(this.lKA);
            this.Controls.Add(this.lLK);
            this.Controls.Add(this.tB1);
            this.Controls.Add(this.tB3);
            this.Controls.Add(this.tB2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cBFächer);
            this.Controls.Add(this.textBoxLK);
            this.Controls.Add(this.textBoxKA);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormNeu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormNeu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormNeu_FormClosing);
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cBFächer;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem neuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ändernToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem löschenToolStripMenuItem;
        internal System.Windows.Forms.TextBox textBoxKA;
        internal System.Windows.Forms.TextBox textBoxLK;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem statistikToolStripMenuItem1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolTip toolTip1;
        internal System.Windows.Forms.TextBox lLK;
        internal System.Windows.Forms.TextBox lKA;
        private System.Windows.Forms.TextBox lGes;
        private System.Windows.Forms.ToolStripMenuItem halbjahrAuswählenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem alleToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.TextBox tB1;
        internal System.Windows.Forms.TextBox tB3;
        internal System.Windows.Forms.TextBox tB2;
        private System.Windows.Forms.ListBox listBox1;

    }
}