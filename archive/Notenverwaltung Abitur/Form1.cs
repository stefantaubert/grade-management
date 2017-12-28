using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        Zentrale _zenti = new Zentrale();
        private int _indexFach, _indexHJ;
        private event Action<int> FachIndexChanged;
        private bool Selected { get { return _indexFach >= 0 && _indexFach < listBox1.Items.Count; } }

        public Form1()
        {
            InitializeComponent();
            FachIndexChanged += new Action<int>(Form1_FachIndexChanged);
            if (FachIndexChanged != null) FachIndexChanged(-1);
            toolStripComboBox1.Items.Clear();
            for (int i = 0; i < Do.Kurshalbjahre.Length; i++)
                toolStripComboBox1.Items.Add(Do.Kurshalbjahre[i]);
            toolStripComboBox1.Items.Add("Alle Noten");
            _zenti.Load();
            toolStripComboBox1.SelectedIndex = _zenti.XmlIndexHJ;
            _indexFach = _zenti.XmlIndexFach;
            FachListBoxLaden(true); //---> _indexFach = -1;
            //   if (IndexChanged != null) IndexChanged(_zenti.XmlIndexFach);
        }

        private void Form1_FachIndexChanged(int index)
        {
            if (_indexFach != index)
            {
                _indexFach = index;
                listBox1.SelectedIndex = _indexFach; // nur formel
                fachToolStripMenuItem.DropDownItems[1].Visible =
                fachToolStripMenuItem.DropDownItems[2].Visible =
                fachToolStripMenuItem.DropDownItems[3].Visible = Selected;

                if (!Selected) return;
                groupBox1.Visible = label2.Visible = true;
                label2.Text = _zenti.Fächer[_indexFach].Name + " (" + toolStripComboBox1.Text + ")";
                ZeigeKurshalbjahresinformationen();
            }
        }
        private void AnwendungVormSchließenSpeichern(object sender, FormClosingEventArgs e) { _zenti.XmlIndexHJ = _indexHJ; _zenti.XmlIndexFach = _indexFach; _zenti.Save(); }
        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e) { if (listView1.SelectedItems.Count == 0) e.Cancel = true; }
        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e) { if (listBox1.SelectedItems.Count == 1) FachÄndern(null, null); }
        private void KurshalbjahrGewechselt(object sender, EventArgs e)
        {
            //if (_zenti.IndexHJ == toolStripComboBox1.SelectedIndex)
            //    return;
            _indexHJ = toolStripComboBox1.SelectedIndex;
            if (toolStripComboBox1.SelectedIndex >= Do.Kurshalbjahre.Length)
            {
                contextMenuStrip1.Enabled = false;
                if (Selected)
                    ZeigeKurshalbjahresinformationen();
            }
            else
            {
                contextMenuStrip1.Enabled = true;
                ZeigeKurshalbjahresinformationen();
            }
            FachListBoxLaden(true);
        }

        private void NoteHinzufügen(object sender, EventArgs e)
        {
            NeueArbeitForm frm2 = new NeueArbeitForm(_zenti.Fächer[_indexFach].Name, _zenti.Fächer[_indexFach].Klausurschema, _indexHJ);
            if (frm2.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                _zenti.Fächer[_indexFach].Add(frm2.Arb, frm2.SelectedHJ);
                if (frm2.SelectedHJ != _indexHJ)
                    toolStripComboBox1.SelectedIndex = frm2.SelectedHJ;
                else ZeigeKurshalbjahresinformationen();
                FachListBoxLaden(true);
            }
        }
        private void NotenEntfernen(object sender, EventArgs e)
        {
            List<int> it = new List<int>();
            foreach (var item in listView1.SelectedIndices)
                it.Add((int)item);
            it.Sort();
            for (int i = 0; i < it.Count; i++)
                //_zenti.Fächer[_indexFach].Kurshalbjahre[_zenti.IndexHJ].Arbeiten.RemoveAt(it[it.Count - 1 - i]);
                _zenti.Fächer[_indexFach].Remove(it[it.Count - 1 - i], _indexHJ);
            //  LoadFach();
            ZeigeKurshalbjahresinformationen();
            FachListBoxLaden(true);
        }

        #region Fach
        private void ZeigeKurshalbjahresinformationen()
        {
            if (!Selected) return;
            if (_indexHJ >= Do.Kurshalbjahre.Length)
                ZeigeKurshalbjahresinformationen(_zenti.Fächer[_indexFach].AlleArbeiten);
            else ZeigeKurshalbjahresinformationen(_zenti.Fächer[_indexFach].Kurshalbjahre[_indexHJ]);
        }
        private void ZeigeKurshalbjahresinformationen(Kurshalbjahr kh)
        {
            listView1.Items.Clear();
            foreach (var item in kh.Arbeiten)
            {
                ListViewItem lI = new ListViewItem(new string[] { item.Zensur, 
                    item.Punkte.ToString(), item.Thema, item.Datum.ToString("MMM yy") });
                if (item.Wertigkeit == Wert.einwertig) lI.Group = listView1.Groups[0];
                else lI.Group = listView1.Groups[1];
                lI.ToolTipText =
                  "Thema: " + item.Thema +
                  "\nPunkte: " + item.Punkte +
                  "\nZensur: " + item.Zensur +
                  "\nMonat: " + item.Datum.ToString("MMM yy");
                listView1.Items.Add(lI);
            }
            userControlStatistik1.Actualisieren(kh.PunkteErreicht, kh.PunkteMax);
            label1.Text = Do.MakeRegular(kh.PunkteDurchschnitt.ToString()) + "P = " + kh.Zensur;
        }
        private void FachListBoxLaden(bool selectTheLast)
        {
            listBox1.Items.Clear();
            for (int i = 0; i < _zenti.Fächer.Count; i++)
            {
                if (_indexHJ >= Do.Kurshalbjahre.Length)
                    listBox1.Items.Add(_zenti.Fächer[i].AlleArbeiten.Zensur.TrimEnd('-').TrimEnd('+') + " :: " + _zenti.Fächer[i].Name);
                else
                    listBox1.Items.Add(_zenti.Fächer[i].Kurshalbjahre[_indexHJ].Zensur.TrimEnd('-').TrimEnd('+') + " :: " + _zenti.Fächer[i].Name);
            }

            label2.Text = "Bitte wählen Sie ein Fach!";
            groupBox1.Visible = false;
            int tmpInd = _indexFach;
            if (FachIndexChanged != null) FachIndexChanged(-1);
            if (selectTheLast && FachIndexChanged != null) FachIndexChanged(tmpInd);
        }
        private void FachLöschen(object sender, EventArgs e)
        {
            if (Selected && (MessageBox.Show("Wollen Sie " + _zenti.Fächer[_indexFach].Name + " wirklich löschen?", "Hinweis", MessageBoxButtons.YesNo) == DialogResult.Yes))
            {
                _zenti.RemoveFach(_indexFach);
                FachListBoxLaden(false);
                if (listBox1.Items.Count > 0 && FachIndexChanged != null) FachIndexChanged(0);
            }
        }
        private void FachAuswählen(object sender, MouseEventArgs e)
        {
            if (FachIndexChanged != null) FachIndexChanged(listBox1.SelectedIndex);
        }
        private void FachZurücksetzen(object sender, EventArgs e)
        {
            if (MessageBox.Show("Es werden alle Einträge des Faches gelöscht!\nWollen Sie fortfahren?", "Hinweis", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No) return;
            _zenti.Fächer[_indexFach].Kurshalbjahre[_indexHJ].Arbeiten.Clear();
            ZeigeKurshalbjahresinformationen();
            //   LoadFach();
        }
        private void FachÄndern(object sender, EventArgs e)
        {
            FachForm frm3 = new FachForm(_zenti.Fächer[_indexFach].Name, _zenti.Fächer[_indexFach].Klausurschema);
            if (frm3.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                int tmpInd = _indexFach;
                _zenti.Fächer[_indexFach].Name = frm3.FachBezeichnung;
                _zenti.Fächer[_indexFach].Klausurschema = frm3.Klausurschema;
                FachListBoxLaden(true);
                //if (IndexChanged != null) IndexChanged(tmpInd);
            }
        }
        private void FachHinzufügen(object sender, EventArgs e)
        {
            FachForm frm3 = new FachForm("", Wert.doppelwertig);
            if (frm3.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Fach f = new Fach();
                f.Name = frm3.FachBezeichnung;
                f.Klausurschema = frm3.Klausurschema;
                _zenti.AddFach(f);
                FachListBoxLaden(false);
                if (FachIndexChanged != null) FachIndexChanged(_zenti.Fächer.Count - 1);
            }
        }
        #endregion

        private void überblickToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new ÜbersichtForm(_zenti.Fächer).ShowDialog();
        }
    }
}