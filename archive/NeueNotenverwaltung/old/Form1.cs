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
    public partial class Form1 : Form
    {
        // event Action<int> FachIndexChanged;

        public Form1()
        {
            InitializeComponent();
          //  Verwaltung.Ini();
            //    FachIndexChanged += new Action<int>(Form1_FachIndexChanged);
            LoadFächer(false);
        }

        private void LoadFächer(bool neu)
        {
            int tmpInd = listBox1.SelectedIndex;
            listBox1.Items.Clear();
            //menuStrip1.Items[1].Visible =
            //  menuStrip1.Items[2].Visible = Verwaltung._fächers.Count != 0;
            //    for (int i = 0; i < Verwaltung._fächers.Count; i++)
            //         listBox1.Items.Add(Verwaltung._fächers[i]._name);
            if (listBox1.Items.Count > 0 && tmpInd == -1 && !neu)
                listBox1.SetSelected(0, true);
          //  if (neu) listBox1.SetSelected(Verwaltung._fächers.Count - 1, true);
        }

        //void Form1_FachIndexChanged(int obj)
        //    {
        //        if (obj < 0) return;

        //        Verwaltung.SetFach(obj);
        //        controlFach1.Aktualisieren();

        //if (_indexFach != index)
        //{
        //    _indexFach = index;
        //    listBox1.SelectedIndex = _indexFach; // nur formel
        //    fachToolStripMenuItem.DropDownItems[1].Visible =
        //    fachToolStripMenuItem.DropDownItems[2].Visible =
        //    fachToolStripMenuItem.DropDownItems[3].Visible = Selected;

        //    if (!Selected) return;
        //    groupBox1.Visible = label2.Visible = true;
        //    label2.Text = _zenti.Fächer[_indexFach].Name + " (" + toolStripComboBox1.Text + ")";
        //    ZeigeKurshalbjahresinformationen();
        //}
        //     }

        private void löschenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
                MessageBox.Show("Bitte wählen Sie ein Fach!");
            //else if (MessageBox.Show("Wollen Sie \"" + Verwaltung.AktuellesFach._name + "\" wirklich löschen?", "Hinweis", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            //{
            //    Verwaltung._fächers.RemoveAt(listBox1.SelectedIndex);
            //    listBox1.SelectedIndex = -1;
            //    LoadFächer(false);
            //}
        }

        private void neuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kleine_Form1 kl = new Kleine_Form1();
            if (kl.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //  Verwaltung.AddFach(kl.Tex, kl.Doppelwertig);
                LoadFächer(true);
            }
        }

        private void ändernToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Bitte wählen Sie ein Fach!");
                return;
            }
            //Kleine_Form1 kl = new Kleine_Form1();
            //kl.Tex = Verwaltung.AktuellesFach._name;
            //kl.Doppelwertig = Verwaltung.AktuellesFach._doppelwertig;
            //if (kl.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            //{
            //    Verwaltung.AktuellesFach._doppelwertig = kl.Doppelwertig;
            //    Verwaltung.AktuellesFach._name = kl.Tex;
            //    LoadFächer(false);
            //}
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (controlFach1.Visible = listBox1.SelectedIndex != -1)
            {
                //   Verwaltung.SetFach(listBox1.SelectedIndex);
                controlFach1.Aktualisieren();
            }
        }
    }
}