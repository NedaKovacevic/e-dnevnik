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
            if (tabela.Rows.Count == 0)
            {
                txtId.Text = "";
                txtIme.Text = "";
                txtPrezime.Text = "";
                txtAdresa.Text = "";
                txtJmbg.Text = "";
                txtMail.Text = "";
                txtPass.Text = "";
                txtUloga.Text = "";
            }
            else
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
            if (brSloga == 0)
            {
                btnFirst.Enabled = false;
                btnPrev.Enabled = false;
            }
            else
            {
                btnFirst.Enabled = true;
                btnPrev.Enabled = true;
            }
            if (brSloga == tabela.Rows.Count -1)
            {
                btnNext.Enabled = false;
                btnLast.Enabled = false;
            }
            else
            {
                btnNext.Enabled = true;
                btnLast.Enabled = true;
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Osoba_Load(object sender, EventArgs e)
        {
            loadData();
            txtLoad();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            brSloga = 0;
            txtLoad();

        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            brSloga--;
            txtLoad();

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            brSloga++;
            txtLoad();

        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            brSloga = tabela.Rows.Count -1;
            txtLoad();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //INSERT INTO osoba VALUES('Marko', 'Lazic', 'Savska 10', '1234567891234',
            //'markolaz@gmail.com', '1234', '1')
            //INSERT INTO osoba(ime, prezime, adresa, jmbg, email, pass, uloga)

            StringBuilder Naredba = new StringBuilder("INSERT INTO osoba (ime, prezime, adresa, jmbg, email, pass, uloga) VALUES('");
            Naredba.Append(txtIme.Text + "', '");
            Naredba.Append(txtPrezime.Text + "', '");
            Naredba.Append(txtAdresa.Text + "', '");
            Naredba.Append(txtJmbg.Text + "', '");
            Naredba.Append(txtMail.Text + "', '");
            Naredba.Append(txtPass.Text + "', '");
            Naredba.Append(txtUloga.Text + "')");
            SqlConnection veza = Konekcija.Connect();
            SqlCommand Komanda = new SqlCommand(Naredba.ToString(), veza);
            try
            {
                veza.Open();
                Komanda.ExecuteNonQuery();
                veza.Close();
            }
            catch(Exception Greska)
            {
                MessageBox.Show(Greska.Message);
            }
            loadData();
            brSloga = tabela.Rows.Count - 1;
            txtLoad();

        }
    }
}
