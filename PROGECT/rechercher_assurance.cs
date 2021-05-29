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
namespace PROGECT
{
    public partial class rechercher_assurance : Form
    {
        public rechercher_assurance()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void rechercher_Click(object sender, EventArgs e)
        {
            string id = "1=1";
            string date_debut = "1=1";
            string date_fin = "1=1";

            if (checkBox1.Checked)
            {
                id = string.Format("id={0}", textBox1.Text);
            }


            if (checkBox_date.Checked)
            {
              date_debut = string.Format("date_debut <='{0}' and date_fin >='{1}'",textBox_date1.Text,textBox_date2.Text);
            }

            dataGridView1.Rows.Clear();
            string req = string.Format(" select  id, type_contrat, date_debut, date_fin, client.cin, client.nom , client.prenom from assurance inner join client on assurance.cin = client.cin where {0} and {1} and {2}  ",
               id,  date_debut,date_fin);
            SqlCommand cmd = new SqlCommand(req, Class1.cnx);
            Class1.ouvrire();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                dataGridView1.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString()) ;
            }
            dr.Close();
            Class1.fermer();
        }

        private void rechercher_assurance_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            string req = string.Format(" select  id, type_contrat, date_debut, date_fin, client.cin, client.nom , client.prenom from assurance inner join client on assurance.cin = client.cin");
            SqlCommand cmd = new SqlCommand(req, Class1.cnx);
            Class1.ouvrire();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                dataGridView1.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString());
            }
            dr.Close();
            Class1.fermer();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Hide();
            assurance m = new assurance();
            m.Show();
        }
    }
}

