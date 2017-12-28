using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Notenverwaltung;

namespace NeueNotenverwaltung
{
    public partial class FormNeu : Form
    {
        private Verwaltung v = new Verwaltung();
        //private bool _onlyTextChanged;
        private int FachIndex { get { return cBFächer.SelectedIndex; } set { cBFächer.SelectedIndex = value; } }
        private bool ControlEnabled
        {
            set
            {
                if (!(contextMenuStrip.Items[1].Visible = contextMenuStrip.Items[2].Visible =
                    lLK.Enabled = lKA.Enabled = lGes.Enabled =
                    textBoxLK.Enabled = textBoxKA.Enabled = value))
                {
                    lLK.Text = lKA.Text = lGes.Text = "0,00";
                    textBoxLK.Text = textBoxKA.Text = "";
                }
            }
        }

        public FormNeu()
        {
            InitializeComponent();
            v = new Verwaltung();
            v.Inizialize(true);
            v.Load();
            LoadHalbjahr(v.HalbjahrIndex);
            LoadFächer(v.FachIndex);
        }
        string GetComboText(int fachInd)
        {
            return v.Fächer[fachInd];
            //    return Notensammlung.GetNote(v.FachSchnitt(fachInd)) + " :: " + v.Fächer[fachInd];
        }
        private void LoadFächer(int selectInd)
        {
            cBFächer.Items.Clear();
            for (int i = 0; i < v.Fächer.Count; i++)
                //   cBFächer.Items.Add(v.Fächer[i]);
                cBFächer.Items.Add(GetComboText(i));
            if (selectInd < cBFächer.Items.Count && selectInd >= 0) cBFächer.SelectedIndex = selectInd;
            else if (cBFächer.SelectedIndex == -1) cB1_SelectedIndexChanged(null, null);
        }

        private void FormNeu_FormClosing(object sender, FormClosingEventArgs e)
        {
            v.FachIndex = FachIndex;
            v.Save();
        }

        private void neuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kleine_Form1 kl = new Kleine_Form1();
            if (kl.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                v.FachAdd(kl.Tex, kl.Doppelwertig);
                LoadFächer(v.Fächer.Count - 1);
            }
        }
        private void löschenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Wollen Sie \"" + cBFächer.Items[FachIndex] + "\" wirklich löschen?", "Hinweis", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                v.FachDelete(FachIndex);
                LoadFächer(0);
            }
        }
        private void ändernToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kleine_Form1 kl = new Kleine_Form1();
            kl.Tex = v.Fächer[FachIndex];
            kl.Doppelwertig = v.Doppelwertig[FachIndex];
            if (kl.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                v.FachChange(FachIndex, kl.Tex, kl.Doppelwertig);
                LoadFächer(FachIndex);
            }
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            if (FachIndex == -1) return;
            if (v.KleineNoten[FachIndex].NotenString != textBoxLK.Text)
                v.KleineNoten[FachIndex].NotenString = textBoxLK.Text;
            lLK.Text = Notensammlung.ConvertToString(v.KleineNoten[FachIndex].ArithmetischesMittel(), 2).Trim();
            lGes.Text = Notensammlung.ConvertToString(v.FachSchnitt(FachIndex), 2).Trim();
            label5.Text = v.GetSich2(FachIndex);
            tB1.Text = Notensammlung.ConvertToString(Notensammlung.GetNote(Convert.ToDouble(lGes.Text)), 2);
            tB2.Text = Notensammlung.ConvertToString(Notensammlung.GetNote(Convert.ToDouble(lLK.Text)), 2);
            //  label5.Text = v.GetSicherheitsSpektrum(FachIndex);
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (FachIndex == -1) return;
            if (v.GroßeNoten[FachIndex].NotenString != textBoxKA.Text)
                v.GroßeNoten[FachIndex].NotenString = textBoxKA.Text;
            lKA.Text = Notensammlung.ConvertToString(v.GroßeNoten[FachIndex].ArithmetischesMittel(), 2).Trim();
            lGes.Text = Notensammlung.ConvertToString(v.FachSchnitt(FachIndex), 2).Trim();
            label5.Text = v.GetSich2(FachIndex);
            tB1.Text = Notensammlung.ConvertToString(Notensammlung.GetNote(Convert.ToDouble(lGes.Text)), 2);
            tB3.Text = Notensammlung.ConvertToString(Notensammlung.GetNote(Convert.ToDouble(lKA.Text)), 2);

            //  label5.Text =  v.GetSicherheitsSpektrum(FachIndex);
            //if (GetComboText(FachIndex) != cBFächer.Text)
            //{
            //    _onlyTextChanged = true;
            //    cBFächer.Items[FachIndex] = GetComboText(FachIndex);
            //}
            //   cBFächer.Text = "";
        }

        private void cB1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ControlEnabled = (FachIndex != -1))// && !_onlyTextChanged)
            {
                //if (v.Doppelwertig[FachIndex]) toolTip1.SetToolTip(lKA, "Klausuren (doppelwertig)");
                //else toolTip1.SetToolTip(lKA, "Klausuren (50:50)");
                toolTip1.SetToolTip(lKA, v.Doppelwertig[FachIndex] ? "Klausuren (doppelwertig)" : "Klausuren (50:50)");
                textBoxLK.Text = v.KleineNoten[FachIndex].NotenString;
                textBoxKA.Text = v.GroßeNoten[FachIndex].NotenString;
                textBox_TextChanged(null, null);
                textBox1_TextChanged(null, null);
                textBoxLK.Focus();
                textBoxLK.Select(textBoxLK.TextLength, 0);
            }
            //   _onlyTextChanged = false;
        }

        private void statistikToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormStatistik fS = new FormStatistik(v.GetStats());
            fS.ShowDialog();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            int ind = -1;
            try
            {
                ind = Convert.ToInt32(((ToolStripMenuItem)sender).Text);
                LoadHalbjahr(ind - 1);
            }
            catch { }
            // alles wennind =-1
        }

        private void LoadHalbjahr(int ind)
        {
            v.HalbjahrIndex = ind;
            Text = "Notenverwaltung - " + (v.HalbjahrIndex + 1).ToString() + ". Halbjahr";
            LoadFächer(cBFächer.SelectedIndex);
        }
    }
}