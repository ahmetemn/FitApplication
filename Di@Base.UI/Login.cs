﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Di_Base.UI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button_AnketeGit_Click(object sender, EventArgs e)
        {
            UygulamaAcilis uygulamaAcilis = new UygulamaAcilis();   

            uygulamaAcilis.ShowDialog(this);
        }
    }
}
