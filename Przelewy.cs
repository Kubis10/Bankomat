﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bankomat
{
    public partial class Przelewy : Form
    {
        public Przelewy()
        {
            InitializeComponent();
        }

        private void telp_btn_Click(object sender, EventArgs e)
        {
            PrzelewT przelewT = new PrzelewT();
            przelewT.Show();
            this.Hide();
        }

        private void cardp_btn_Click(object sender, EventArgs e)
        {
            PrzelewK przelewK = new PrzelewK();
            przelewK.Show();
            this.Hide();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }
    }
}
