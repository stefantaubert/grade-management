namespace NeueNotenverwaltung
{
    partial class ControlFach
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

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.noteneingabe2 = new NeueNotenverwaltung.Noteneingabe();
            this.noteneingabe1 = new NeueNotenverwaltung.Noteneingabe();
            this.labelAllesMittel = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.noteneingabe2);
            this.groupBox1.Controls.Add(this.noteneingabe1);
            this.groupBox1.Controls.Add(this.labelAllesMittel);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(446, 200);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fach";
            // 
            // noteneingabe2
            // 
            this.noteneingabe2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noteneingabe2.Header = "Klausuren (doppelwertig)";
            this.noteneingabe2.Location = new System.Drawing.Point(6, 72);
            this.noteneingabe2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.noteneingabe2.Name = "noteneingabe2";
            this.noteneingabe2.Size = new System.Drawing.Size(403, 46);
            this.noteneingabe2.TabIndex = 16;
            // 
            // noteneingabe1
            // 
            this.noteneingabe1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noteneingabe1.Header = "Leistungskontrollen (einwertig)";
            this.noteneingabe1.Location = new System.Drawing.Point(6, 20);
            this.noteneingabe1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.noteneingabe1.Name = "noteneingabe1";
            this.noteneingabe1.Size = new System.Drawing.Size(403, 46);
            this.noteneingabe1.TabIndex = 15;
            // 
            // labelAllesMittel
            // 
            this.labelAllesMittel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelAllesMittel.AutoSize = true;
            this.labelAllesMittel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAllesMittel.Location = new System.Drawing.Point(154, 123);
            this.labelAllesMittel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAllesMittel.Name = "labelAllesMittel";
            this.labelAllesMittel.Size = new System.Drawing.Size(150, 55);
            this.labelAllesMittel.TabIndex = 14;
            this.labelAllesMittel.Text = "12,01";
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBox1.AutoSize = true;
            this.checkBox1.Enabled = false;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox1.Location = new System.Drawing.Point(4, 174);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(94, 21);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "Testmodus";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // ControlFach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ControlFach";
            this.Size = new System.Drawing.Size(446, 200);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private Noteneingabe noteneingabe2;
        private Noteneingabe noteneingabe1;
        private System.Windows.Forms.Label labelAllesMittel;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}
