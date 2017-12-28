using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class UserControlStatistik : UserControl
    {
        double _prz = 0;
        public UserControlStatistik()
        {
            InitializeComponent();
            panelBackground.BackColor = Color.LightCoral;
            panelBar.BackColor = Color.LightGreen;
            Actualisieren();
        }
        public void Actualisieren(double erreichteP, double gesamtP)
        {
            double prozent = 0;
            if (gesamtP != 0) prozent = erreichteP / gesamtP * 100;
            else prozent = 0;
            string tex = "Erreichte Punkte: " + Math.Round(erreichteP, 2).ToString() + Do.GE + "\n";
            // tex += " = " + Math.Round(einnahmen + budget, 2).ToString() + " GE";
            tex += "Gesamtpunkte: " + Math.Round(gesamtP, 2).ToString() + Do.GE;
            tex += "\n\n" + Math.Round(prozent, 2).ToString() + "% erreicht";
            //  toolTip1.SetToolTip(panelBackground, tex);
            //  toolTip1.SetToolTip(panelBar, tex);
            _prz = prozent;
            label3.Text = ""; // weil sonst die alte zahl übermalt wird, kp warum
            label3.Text = erreichteP + Do.GE + " / " + gesamtP + Do.GE + " = " + Math.Round(_prz, 0).ToString() + "%";
            ActAnzeige();
        }
        public void Actualisieren()
        {
            panelBar.Width = 0;
            label3.Text = "";
            label3.Text = "0%";
        }
        void ActAnzeige()
        {
            double tmpPro = _prz;
            if (tmpPro > 100) tmpPro = 100;
            else if (tmpPro < 0) tmpPro = 0;
            panelBar.Width = Convert.ToInt32(Math.Round((double)panelBackground.Width / 100 * tmpPro, 0));
        }


        private void panel1_SizeChanged(object sender, EventArgs e)
        {
            ActAnzeige();
        }
    }
}
