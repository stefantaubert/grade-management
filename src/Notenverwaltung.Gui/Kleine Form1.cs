using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GradeManagement.Gui
{
    public partial class Kleine_Form1 : Form
    {
        public string Tex { get { return textBox2.Text.Trim(); } set { textBox2.Text = value; } }
        public bool Doppelwertig { get { return radioButton1.Checked; } set { if (value) radioButton1.Checked = true; else radioButton2.Checked = true; } }

        public Kleine_Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Tex.Trim() != string.Empty)
            {
                DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Bitte geben Sie einen Namen an!");
                DialogResult = System.Windows.Forms.DialogResult.None;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Abort;
        }
    }
}
