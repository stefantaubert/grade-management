using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class FachForm : Form
    {
        public string FachBezeichnung { get { return textBox1.Text.Trim(); } }
        public Wert Klausurschema { get { if (radioButton1.Checked) return Wert.doppelwertig; else return Wert.hälfte; } }
        public FachForm(string name, Wert klausurschema)
        {
            InitializeComponent();
            if (klausurschema == Wert.doppelwertig) radioButton1.Checked = true; else radioButton2.Checked = true;
            if (name.Trim() != "") Text = "Fach ändern";
            textBox1.Text = name;
            textBox1.Select(0, textBox1.Text.Length);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (FachBezeichnung != "") DialogResult = System.Windows.Forms.DialogResult.OK;
            else
            {
                MessageBox.Show("Bitte geben Sie einen Namen an!");
                DialogResult = System.Windows.Forms.DialogResult.None;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
    }
}
