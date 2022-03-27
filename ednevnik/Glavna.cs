using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ednevnik
{
    public partial class Glavna : Form
    {
        public Glavna()
        {
            InitializeComponent();
        }

        private void tabelaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void jedanBezToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Glavna_Load(object sender, EventArgs e)
        {

        }

        private void osobeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Osoba frmOsoba = new Osoba();
            frmOsoba.Show();
        }
    }
}
