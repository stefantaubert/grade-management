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
    public partial class ControlFach : UserControl
    {
        public ControlFach()
        {
            InitializeComponent();
            noteneingabe1.textBox.TextChanged += new EventHandler(textBox_TextChanged);
            noteneingabe2.textBox.TextChanged += new EventHandler(textBox_TextChanged);
        }

        void textBox_TextChanged(object sender, EventArgs e)
        {
        //    if (Verwaltung.AktuellesFach == null) return;
          //  labelAllesMittel.Text = Verwaltung.AktuellesFach.alleNotenRetMittel().ToString();
        }

        public void Aktualisieren()
        {
         //   if (Verwaltung.AktuellesFach == null) return;
        //    groupBox1.Text = Verwaltung.AktuellesFach._name;
            noteneingabe2.Aktualisieren(false);
            noteneingabe1.Aktualisieren(true);
            textBox_TextChanged(null, null);
        }
    }
}
