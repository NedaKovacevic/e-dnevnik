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
    public partial class Glavna2 : Form
    {
        public Glavna2()
        {
            InitializeComponent();
        }

        private void raspodelaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Raspodela formRaspodela = new Raspodela();
            formRaspodela.Show();
        }

        private void Glavna2_Load(object sender, EventArgs e)
        {
            string user = Program.userIme + " " + Program.userPrez;
            labelUser.Text = user;
        }

        private void upisniceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Upisnica formUpisnica = new Upisnica();
            formUpisnica.Show();
        }
        private void Glavna2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void slogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Osoba formOsoba = new Osoba();
            formOsoba.Show();
        }

        private void tabelaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sifarnik formSifarnik = new Sifarnik("osoba");
            formSifarnik.Show();
        }

        private void skolskeGodineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sifarnik formSifarnik = new Sifarnik("skolska_godina");
            formSifarnik.Show();
        }

        private void smeroviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sifarnik formSifarnik = new Sifarnik("smer");
            formSifarnik.Show();
        }

        private void predmetiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sifarnik formSifarnik = new Sifarnik("predmet");
            formSifarnik.Show();
        }

        

       

        private void oceneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ocena formOcena = new Ocena();
            formOcena.Show();
        }

        private void raspodelaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }
    }
}

