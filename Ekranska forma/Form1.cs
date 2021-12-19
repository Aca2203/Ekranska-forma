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

namespace Ekranska_forma
{
    public partial class Form1 : Form
    {
        int red = 0;
        string CS = "Data source=DESKTOP-3V77NB4\\SQLEXPRESS; Initial catalog=Ekranska forma; Integrated security=True";
        DataTable podaci = new DataTable();
        public Form1()
        {
            InitializeComponent();
        }

        private void Osvezi()
        {
            TXT_brojRacuna.Text = podaci.Rows[red]["broj_racuna"].ToString();
            TXT_kupac.Text = podaci.Rows[red]["kupac"].ToString();
            TXT_datum.Text = podaci.Rows[red]["datum"].ToString();
            TXT_vrednost.Text = podaci.Rows[red]["vrednost"].ToString();
            TXT_brojStavki.Text = podaci.Rows[red]["br_stavki"].ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection veza = new SqlConnection(CS);
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Racun", veza);
            adapter.Fill(podaci);
            Osvezi();
            nazad.Enabled = false;
            nazadMAX.Enabled = false;
        }

        private void napred_Click(object sender, EventArgs e)
        {
            if (red != podaci.Rows.Count - 1)
            {
                red++;
                Osvezi();
                if (red == podaci.Rows.Count - 1)
                {
                    napred.Enabled = false;
                    napredMAX.Enabled = false;
                }
                nazad.Enabled = true;
                nazadMAX.Enabled = true;
            }
            else
            {
                napred.Enabled = false;
            }
        }

        private void nazad_Click(object sender, EventArgs e)
        {
            if (red != 0)
            {
                red--;
                Osvezi();                
                if (red == 0)
                {                    
                    nazad.Enabled = false;
                    nazadMAX.Enabled = false;
                }
                napred.Enabled = true;
                napredMAX.Enabled = true;
            }
            else
            {
                nazad.Enabled = false;
            }
        }

        private void napredMAX_Click(object sender, EventArgs e)
        {
            red = podaci.Rows.Count - 1;
            Osvezi();
            napred.Enabled = false;
            napredMAX.Enabled = false;
            nazad.Enabled = true;
            nazadMAX.Enabled = true;
        }

        private void nazadMAX_Click(object sender, EventArgs e)
        {
            red = 0;
            Osvezi();
            nazad.Enabled = false;
            nazadMAX.Enabled = false;         
            napred.Enabled = true;
            napredMAX.Enabled = true;
        }

        private void obrisi_Click(object sender, EventArgs e)
        {
            SqlConnection veza = new SqlConnection(CS);
            veza.Open();
            SqlCommand naredba = new SqlCommand("DELETE FROM Racun WHERE broj_racuna = " + TXT_brojRacuna.Text, veza);
            naredba.ExecuteNonQuery();
            veza.Close();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Racun", veza);
            podaci.Clear();
            adapter.Fill(podaci);
            red = 0;
            Osvezi();
            nazad.Enabled = false;
            nazadMAX.Enabled = false;
        }

        private void promeni_Click(object sender, EventArgs e)
        {
            SqlConnection veza = new SqlConnection(CS);       
            veza.Open();
            //MessageBox.Show("UPDATE Racun SET broj_racuna = " + TXT_brojRacuna.Text + ", kupac = \'" + TXT_kupac.Text + "\', datum = " + TXT_datum.Text + ", vrednost = " + TXT_vrednost.Text + ", br_stavki = " + TXT_brojStavki.Text + " WHERE broj_racuna = " + podaci.Rows[red]["broj_racuna"].ToString());            
            SqlCommand naredba = new SqlCommand("UPDATE Racun SET broj_racuna = " + TXT_brojRacuna.Text + ", kupac = \'" + TXT_kupac.Text + "\', datum = \'" + TXT_datum.Text + "\', vrednost = " + TXT_vrednost.Text + ", br_stavki = " + TXT_brojStavki.Text + " WHERE broj_racuna = " + podaci.Rows[red]["broj_racuna"].ToString(), veza);
            naredba.ExecuteNonQuery();
            veza.Close();                     
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Racun", veza);
            podaci.Clear();
            adapter.Fill(podaci);
            red = 0;
            Osvezi();
            nazad.Enabled = false;
            nazadMAX.Enabled = false;                     
        }

        private void dodaj_Click(object sender, EventArgs e)
        {
            SqlConnection veza = new SqlConnection(CS);
            veza.Open();
            //MessageBox.Show("INSERT INTO Racun(broj_racuna, kupac, datum, vrednost, br_stavki) VALUES(" + TXT_brojRacuna.Text + ", \'" + TXT_kupac.Text + "\', \'" + TXT_datum.Text + "\', " + TXT_vrednost.Text + ", " + TXT_brojStavki.Text + ")");            
            
            SqlCommand naredba = new SqlCommand("INSERT INTO Racun(broj_racuna, kupac, datum, vrednost, br_stavki) VALUES(" + TXT_brojRacuna.Text + ", \'" + TXT_kupac.Text + "\', \'" + TXT_datum.Text + "\', " + TXT_vrednost.Text + ", " + TXT_brojStavki.Text + ")", veza);
            naredba.ExecuteNonQuery();
            veza.Close();
            
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Racun", veza);
            podaci.Clear();
            adapter.Fill(podaci);
            red = 0;
            Osvezi();
            nazad.Enabled = false;
            nazadMAX.Enabled = false;
        }
    }
}
