namespace NeueNotenverwaltung
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.comboBox1Halbjahr = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fachToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.neuToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ändernToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.löschenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statistikToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.controlFach1 = new NeueNotenverwaltung.ControlFach();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.IntegralHeight = false;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Items.AddRange(new object[] {
            "12 :: Mathe",
            "11 :: Deutsch",
            "12 :: Englisch",
            "11 :: Physik",
            "12 :: Biologie",
            "13 :: Musik"});
            this.listBox1.Location = new System.Drawing.Point(12, 124);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(197, 203);
            this.listBox1.TabIndex = 2;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // comboBox1Halbjahr
            // 
            this.comboBox1Halbjahr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1Halbjahr.FormattingEnabled = true;
            this.comboBox1Halbjahr.Items.AddRange(new object[] {
            "Klasse 12/I",
            "Klasse 12/II",
            "Klasse 13/I",
            "Klasse 13/II",
            "Alle Noten"});
            this.comboBox1Halbjahr.Location = new System.Drawing.Point(12, 31);
            this.comboBox1Halbjahr.Name = "comboBox1Halbjahr";
            this.comboBox1Halbjahr.Size = new System.Drawing.Size(197, 24);
            this.comboBox1Halbjahr.TabIndex = 10;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fachToolStripMenuItem,
            this.statistikToolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(778, 28);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fachToolStripMenuItem
            // 
            this.fachToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.neuToolStripMenuItem1,
            this.ändernToolStripMenuItem1,
            this.löschenToolStripMenuItem});
            this.fachToolStripMenuItem.Name = "fachToolStripMenuItem";
            this.fachToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.fachToolStripMenuItem.Text = "Fach";
            // 
            // neuToolStripMenuItem1
            // 
            this.neuToolStripMenuItem1.Name = "neuToolStripMenuItem1";
            this.neuToolStripMenuItem1.Size = new System.Drawing.Size(131, 24);
            this.neuToolStripMenuItem1.Text = "Neu";
            this.neuToolStripMenuItem1.Click += new System.EventHandler(this.neuToolStripMenuItem_Click);
            // 
            // ändernToolStripMenuItem1
            // 
            this.ändernToolStripMenuItem1.Name = "ändernToolStripMenuItem1";
            this.ändernToolStripMenuItem1.Size = new System.Drawing.Size(131, 24);
            this.ändernToolStripMenuItem1.Text = "Ändern";
            this.ändernToolStripMenuItem1.Click += new System.EventHandler(this.ändernToolStripMenuItem_Click);
            // 
            // löschenToolStripMenuItem
            // 
            this.löschenToolStripMenuItem.Name = "löschenToolStripMenuItem";
            this.löschenToolStripMenuItem.Size = new System.Drawing.Size(131, 24);
            this.löschenToolStripMenuItem.Text = "Löschen";
            this.löschenToolStripMenuItem.Click += new System.EventHandler(this.löschenToolStripMenuItem_Click);
            // 
            // statistikToolStripMenuItem2
            // 
            this.statistikToolStripMenuItem2.Name = "statistikToolStripMenuItem2";
            this.statistikToolStripMenuItem2.Size = new System.Drawing.Size(73, 24);
            this.statistikToolStripMenuItem2.Text = "Statistik";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Mathe",
            "Deutsch",
            "Englisch"});
            this.comboBox1.Location = new System.Drawing.Point(12, 79);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(197, 24);
            this.comboBox1.TabIndex = 13;
            // 
            // controlFach1
            // 
            this.controlFach1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.controlFach1.Location = new System.Drawing.Point(215, 31);
            this.controlFach1.Name = "controlFach1";
            this.controlFach1.Size = new System.Drawing.Size(551, 296);
            this.controlFach1.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 339);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.controlFach1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.comboBox1Halbjahr);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox comboBox1Halbjahr;
        private ControlFach controlFach1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fachToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem neuToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ändernToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem löschenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statistikToolStripMenuItem2;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

