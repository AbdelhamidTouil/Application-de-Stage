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
    public partial class recherecher_cheque : Form
    {
        public recherecher_cheque()
        {
            InitializeComponent();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nom = "1=1";
            string cin_client = "1=1";
            string Date1 = "1=1";
        


            if (checkBox_nom.Checked)
            {
                nom= string.Format("nom='{0}'", textBox1.Text);
            }

            if (checkBox_cin.Checked)
            {
                cin_client = string.Format("cin='{0}'", textBox2.Text);
            }

            if (checkBox_date.Checked)
            {
                Date1 = string.Format(" date_cheque='{0}'",textBox_date.Text);

            }

            dataGridView1.Rows.Clear();
            string req = string.Format("select id ,rest, montant,date_cheque ,client.cin,client.nom ,client.prenom from cheque inner join client on cheque.cin=client.cin where {0} and {1} and {2}",
               nom, cin_client,Date1);
            SqlCommand cmd = new SqlCommand(req, Class1.cnx);
            Class1.ouvrire();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                dataGridView1.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(),dr[4].ToString(), dr[5].ToString(), dr[5].ToString(),dr[6].ToString());
            }
            dr.Close();
            Class1.fermer();
              }
        

        private void recherecher_cheque_Load(object sender, EventArgs e)
        {
            string req = string.Format("select id ,rest, montant,date_cheque ,client.cin,client.nom ,client.prenom from cheque inner join client on cheque.cin=client.cin");
            SqlCommand cmd = new SqlCommand(req, Class1.cnx);
            Class1.ouvrire();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                
                dataGridView1.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(),dr[5].ToString(),dr[6].ToString());
            }
            dr.Close();
            Class1.fermer();
        }

        private void label7_Click(object sender, EventArgs e)
        {

            this.Hide();
            cheque m = new cheque();
            m.Show();
        }
    }
}
