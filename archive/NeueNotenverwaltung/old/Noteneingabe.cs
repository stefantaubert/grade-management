using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Notenverwaltung;

namespace NeueNotenverwaltung
{
    public partial class Noteneingabe : UserControl
    {
        const string darfBeeinhalten = ",1234567890";
        Notensammlung _ns = new Notensammlung();

        public string Header { get { return header.Text; } set { header.Text = value; } }
        //public string Text { get { return textBox.Text; } set { textBox.Text = value; } }
        public Noteneingabe()
        {
            InitializeComponent();
        }

        public void Aktualisieren(bool kleineNoten)
        {
            if (kleineNoten)
            {
                //    _ns = Verwaltung.AktuellesFach._kleineNoten;
                header.Text = "Leistungskontrollen (einwertig)";
            }
            else
            {
                //   _ns = Verwaltung.AktuellesFach._großeNoten;
                header.Text = "Klausur ";
                //    if (Verwaltung.AktuellesFach._doppelwertig)
                //        header.Text += "(doppelwertig)";
                //     else header.Text += "(50:50)";
            }
            textBox.Text = _ns.NotenString;
            textBox4_TextChanged(null, null);
            textBox.Focus();
            textBox.Select(textBox.TextLength, 0);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            textBox.Text = RemoveRotz(textBox.Text);
            textBox.Select(textBox.TextLength, 0);
            _ns.NotenString = textBox.Text;
            //  labelMittel.Text = _ns.Mittel.ToString();
        }
        string RemoveRotz(string text)
        {
            string ausg = "";
            for (int i = 0; i < text.Length; i++)
                if (darfBeeinhalten.Contains(text[i].ToString()))
                    ausg += text[i].ToString();
            return ausg;

        }
    }
}
