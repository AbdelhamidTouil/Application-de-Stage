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
    public partial class Rechercher_client : Form
    {
        DataSet ds = new DataSet();
        SqlDataAdapter da;
        SqlCommandBuilder cb = new SqlCommandBuilder();
        public Rechercher_client()
        {
            InitializeComponent();
        }
        public void RemplireGrid()

        {
            string req = string.Format("select * from client");
            da = new SqlDataAdapter(req, Class1.cnx);
            da.Fill(ds, "client");
            dataGridView1.DataSource = ds.Tables["client"];
        }
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cin = "1=1";
            string nom = "1=1";
            string prenom = "1=1";
            string tel = "1=1";
            string credit= "1=1";



            if (check_cin.Checked)
            {
                cin  = string.Format("cin='{0}'", text_cin.Text);
            }
            if (check_nom.Checked)
            {
                nom = string.Format("nom='{0}'", text_nom.Text);
            }
            if (check_prenom.Checked)
            {
                prenom = string.Format("prenom='{0}'", text_prenom.Text);
            }
            if (check_tel.Checked)
            {
                tel = string.Format("tel={0}", text_tel.Text);
            }
            if (check_credit.Checked)
            {
                credit = string.Format("credit={0}", text_credit.Text);
            }
            dataGridView1.Rows.Clear();
            string req = string.Format("select * from client where {0} and {1}  and {2} and {3} and {4}",
                cin, nom, prenom, tel, credit);
            SqlCommand cmd = new SqlCommand(req, Class1.cnx);
            Class1.ouvrire();
            SqlDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                dataGridView1.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString());
            }
            dr.Close();
            Class1.fermer();
           


        }

        private void Rechercher_Load(object sender, EventArgs e)
        {

            string req = string.Format("select * from client ");
            SqlCommand cmd = new SqlCommand(req, Class1.cnx);
            Class1.ouvrire();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                dataGridView1.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString());
            }
            dr.Close();
            Class1.fermer();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            client m = new client();
            m.Show();
        }
    }
}
