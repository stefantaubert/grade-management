using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class NeueArbeitForm : Form
    {
        Wert _wertigkeit;
        public Arbeit Arb
        {
            get
            {
                Arbeit a = new Arbeit();
                if (radioButton2.Checked) a.Wertigkeit = Wert.einwertig;
                else a.Wertigkeit = _wertigkeit;
                a.Thema = textBox1.Text.Trim();
                a.Datum = DateTime.Now;
                a.Punkte = Do.MaxPunkte - comboBox1.SelectedIndex;
                return a;
            }
        }
        public int SelectedHJ { get { return comboBox2.SelectedIndex; } }

        public NeueArbeitForm(string fach, Wert wertschema, int indexHJ)
        {
            InitializeComponent();
            comboBox2.Items.Clear();
            for (int i = 0; i < Do.Kurshalbjahre.Length; i++)
                comboBox2.Items.Add(Do.Kurshalbjahre[i]);
            if (indexHJ < 0 || indexHJ >= Do.Kurshalbjahre.Length)
                indexHJ = 0;
            comboBox2.SelectedIndex = indexHJ;

            _wertigkeit = wertschema;
            if (_wertigkeit == Wert.doppelwertig) radioButton1.Text = "Klausur (" + _wertigkeit.ToString() + ")";
            else radioButton1.Text = "Klausur (50:50)";
            Text = "Neuer Eintrag in " + fach;
            comboBox1.Items.Clear();
            Arbeit a = new Arbeit();
            for (int i = 0; i < Do.MaxPunkte + 1; i++)
            {
                a.Punkte = Do.MaxPunkte - i;
                comboBox1.Items.Add(a.Punkte + "P = " + a.Zensur);
            }
            comboBox1.SelectedIndex = comboBox1.Items.Count - 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
    }
}
