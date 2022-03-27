using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ednevnik
{
    public partial class Osoba : Form
    {
        int brSloga = 0;
        DataTable tabela;

        public Osoba()
        {
            InitializeComponent();
        }
        private void loadData()
        {
            SqlConnection veza = Konekcija.Connect();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM osoba", veza);
            tabela = new DataTable();
            adapter.Fill(tabela);
        }
        private void txtLoad()
        {
            txtId.Text = tabela.Rows[brSloga]["id"].ToString();
            txtIme.Text = tabela.Rows[brSloga]["ime"].ToString();
            txtPrezime.Text = tabela.Rows[brSloga]["prezime"].ToString();
            txtAdresa.Text = tabela.Rows[brSloga]["adresa"].ToString();
            txtJmbg.Text = tabela.Rows[brSloga]["jmbg"].ToString();
            txtMail.Text = tabela.Rows[brSloga]["email"].ToString();
            txtPass.Text = tabela.Rows[brSloga]["pass"].ToString();
            txtUloga.Text = tabela.Rows[brSloga]["uloga"].ToString();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Osoba_Load(object sender, EventArgs e)
        {
            loadData();
            txtLoad();
        }
    }
}
