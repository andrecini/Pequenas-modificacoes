﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoTermoHeros
{
    public partial class TelaSobre : Form
    {
        public TelaSobre()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Form1 screen = new Form1();
            screen.Show();
            this.Close();
        }
    }
}
