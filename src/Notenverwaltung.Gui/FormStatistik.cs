﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GradeManagement
{
    public partial class FormStatistik : Form
    {
        public FormStatistik(string text)
        {
            InitializeComponent();
            richTextBox1.Text = text;
        }
    }
}
