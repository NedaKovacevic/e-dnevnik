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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if(txtName.Text == "" || txtPass.Text == "")
            {
                MessageBox.Show("Unesite mail i lozinku");
                return;
            }
            else
            {
                try
                {
                    SqlConnection veza = Konekcija.Connect();
                    SqlCommand komanda = new SqlCommand("SELECT * FROM osoba WHERE email=@username", veza);
                    komanda.Parameters.AddWithValue("@username", txtName.Text);
                    SqlDataAdapter adapter = new SqlDataAdapter(komanda);
                    DataTable tabela = new DataTable();
                    adapter.Fill(tabela);

                    int brojac = tabela.Rows.Count;
                    if(brojac ==1)
                    {
                        if(String.Compare(tabela.Rows[0]["pass"].ToString(),txtPass.Text) == 0)
                        {
                            MessageBox.Show("Login Successful!");
                            Program.userIme = tabela.Rows[0]["ime"].ToString();
                            Program.userPrez = tabela.Rows[0]["prezime"].ToString();
                            Program.userUloga = (int)tabela.Rows[0]["uloga"]; 
                            this.Hide();
                            Glavna frmGlavna = new Glavna();
                            frmGlavna.Show();
                        }
                        else
                        {
                            MessageBox.Show("Pogresna lozinka!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nepostojeci email!");
                    }
                }
                catch(Exception greska)
                {
                    MessageBox.Show(greska.Message);
                }
            }
        }
    }
}
