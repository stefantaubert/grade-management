using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GradeManagement.Core;

namespace GradeManagement.Gui
{
    public partial class Form2 : Form
    {
        const int DecimalsGes = 3, DecimalsTool = 0, DecimalsNoten = 2;

        public Form2()
        {
            InitializeComponent();
            Verwaltg = new Verw();
            Verwaltg.Load();
            ShowHalbjahr(Verwaltg.IndexJahr);
            //  Verwaltg.ClearEinträge();
        }

        private Verw Verwaltg
        {
            get;
            set;
        }

        private void ShowFach(int ind)
        {
            Verwaltg.IndexFach = ind;
            labelFächer.Text = Verwaltg.FachSelected ? Verwaltg.AktuellesFach.Name : "Fach wählen";
            textBoxKleineNoten.Text = Verwaltg.KleineNoten;
            textBoxGroßeNoten.Text = Verwaltg.GroßeNoten;
            label1.Text = Notensammlung.ConvertToString(Verwaltg.FachSchnitt, DecimalsGes);
            labelKleineNotenschnitt.Text = Notensammlung.ConvertToString(Verwaltg.KleineNotenSchnitt, DecimalsNoten);
            labelGroßeNotenschnitt.Text = Notensammlung.ConvertToString(Verwaltg.GroßeNotenSchnitt, DecimalsNoten);
            textBoxKleineNoten.Focus();
            textBoxKleineNoten.Select(textBoxKleineNoten.Text.Length, 0);
        }

        private void ShowHalbjahr(int ind)
        {
            Verwaltg.IndexJahr = ind;
            //"Notenverwaltung - " +
            this.Text = contextMenuHalbjahre.Items[Verwaltg.IndexJahr].Text;
            ShowFach(Verwaltg.IndexFach);
        }

        private void label3_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                contextMenuFächer.Show(labelFächer, e.Location);
            }
            else if (e.Button == System.Windows.Forms.MouseButtons.Middle)
            {
                contextMenuHalbjahre.Show(labelFächer, e.Location);
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            contextMenuEditFach.Items[1].Visible =
            contextMenuEditFach.Items[2].Visible =
            Verwaltg.FachSelected;
        }

        private void contextMenuStrip3_Opening(object sender, CancelEventArgs e)
        {
            contextMenuFächer.Items.Clear();
            if (!Verwaltg.HalbjahrSelected || Verwaltg.Fächer.Count == 0)
            {
                e.Cancel = true;
            }
            else
            {
                int iTmp = Verwaltg.IndexFach;
                for (int i = 0; i < Verwaltg.Fächer.Count; i++)
                {
                    ToolStripMenuItem ti = new ToolStripMenuItem();
                    ti.Tag = Verwaltg.IndexFach = i;
                    ti.Text = GradeManagement.Core.Notensammlung.ConvertToString(Verwaltg.FachSchnitt, DecimalsTool, false) + " :: " + Verwaltg.AktuellesFach.Name;
                    contextMenuFächer.Items.Add(ti);
                }

                Verwaltg.IndexFach = iTmp;
            }
        }

        private void label2_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                // contextMenuHalbjahr.Show(labelHalbjahre, e.Location);
            }
        }

        private void contextMenuStrip4_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            ShowHalbjahr(Convert.ToInt32(e.ClickedItem.Text.Substring(0, 1)) - 1);
        }

        private void contextMenuStrip5_Opening(object sender, CancelEventArgs e)
        {
            e.Cancel = !Verwaltg.HalbjahrSelected;
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kleine_Form1 k = new Kleine_Form1();
            if (k.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ShowFach(Verwaltg.Add(k.Tex, k.Doppelwertig));
            }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Verwaltg.Save();
        }

        private void ändernToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kleine_Form1 k = new Kleine_Form1();
            k.Tex = Verwaltg.AktuellesFach.Name;
            k.Doppelwertig = Verwaltg.AktuellesFach.Doppelwertig;
            if (k.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ShowFach(Verwaltg.Change(k.Tex, k.Doppelwertig));
            }
        }

        private void contextMenuStrip3_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            int ind = (int)e.ClickedItem.Tag;
            ShowFach(ind);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Verwaltg.KleineNoten = textBoxKleineNoten.Text;
            label1.Text = Notensammlung.ConvertToString(Verwaltg.FachSchnitt, DecimalsGes);
            labelKleineNotenschnitt.Text = Notensammlung.ConvertToString(Verwaltg.KleineNotenSchnitt, DecimalsNoten);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Verwaltg.GroßeNoten = textBoxGroßeNoten.Text;
            label1.Text = Notensammlung.ConvertToString(Verwaltg.FachSchnitt, DecimalsGes);
            labelGroßeNotenschnitt.Text = Notensammlung.ConvertToString(Verwaltg.GroßeNotenSchnitt, DecimalsNoten);
        }

        private void label1_MouseClick(object sender, MouseEventArgs e)
        {
            toolTip1.Show(Verwaltg.GetSicherheit(true), (Label)sender, e.X, e.Y);
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            toolTip1.Hide((Label)(sender));
        }

        private void label5_MouseClick(object sender, MouseEventArgs e)
        {
            toolTip1.Show(Verwaltg.GetSicherheit(false), (Label)sender, e.X, e.Y);
        }

        private void löschenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Wollen Sie " + Verwaltg.AktuellesFach.Name + " wirklich löschen?", "Hinweis", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                Verwaltg.Delete();
                ShowFach(Verwaltg.IndexFach);
            }
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = Text + " " + DateTime.Now.ToShortDateString() + ".txt";
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Verwaltg.Exportieren(saveFileDialog1.FileName);
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new FormStatistik(Verwaltg.GetStats()).ShowDialog();
        }
    }
}