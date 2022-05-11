﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppExemploMenu
{
    public partial class FrmAzul : Form
    {
        public FrmAzul()
        {
            InitializeComponent();
        }

        private void exibirFormAmarelo_Click(object sender, EventArgs e)
        {
            FrmAmarelo frm = new FrmAmarelo(); 
            this.Hide();  
            frm.ShowDialog(); 
        }

        private void exibirFormAzul_Click(object sender, EventArgs e)
        {
            FrmAzul frm = new FrmAzul(); 
            this.Hide();  
            frm.ShowDialog();
        }

        private void exibirFormVermelho_Click(object sender, EventArgs e)
        {
            FrmVermelho frm = new FrmVermelho(); 
            this.Hide();  
            frm.ShowDialog();
        }
    }
}
