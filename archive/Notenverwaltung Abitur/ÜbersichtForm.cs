using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class ÜbersichtForm : Form
    {
        public ÜbersichtForm(List<Fach> fächers)
        {
            InitializeComponent();
            label1.Text = Summary.MakeSummary(fächers);
        }
    }
}
