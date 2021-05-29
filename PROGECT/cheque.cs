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
    public partial class cheque : Form
    {
        DataSet ds = new DataSet();
        SqlDataAdapter da;
        public cheque()
        {
            InitializeComponent();
        }
        public void remplirecombo()
        {
            string req = string.Format("select cin from client ");
            da = new SqlDataAdapter(req, Class1.cnx);
            da.Fill(ds, "client");
            comboBox1.DisplayMember = "cin";
            comboBox1.ValueMember = "cin";
            comboBox1.DataSource = ds.Tables["client"];
        }
        private void cheque_Load(object sender, EventArgs e)
        {

            remplirecombo();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            recherecher_cheque f = new recherecher_cheque();
            f.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string req = string.Format("insert into cheque values({0},{1},'{2}','{3}')",
               text_rest.Text, text_montant.Text, text_date.Text,comboBox1.Text);
            SqlCommand cmd = new SqlCommand(req, Class1.cnx);
            Class1.ouvrire();
            cmd.ExecuteNonQuery();
            MessageBox.Show("ajouter avec succes");
            Class1.fermer();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string req = string.Format("update cheque set rest={0},montant={1},date_cheque='{2}' where  cin='{3}'",
              text_rest.Text, text_montant.Text,text_date.Text, comboBox1.Text);
            SqlCommand cmd = new SqlCommand(req, Class1.cnx);
            Class1.ouvrire();
            cmd.ExecuteNonQuery();
            MessageBox.Show("modifier avec succes");
            Class1.fermer();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string req = string.Format("delete from cheque  where  cin='{0}' ",comboBox1.Text);
            SqlCommand cmd = new SqlCommand(req, Class1.cnx);
            Class1.ouvrire();
            cmd.ExecuteNonQuery();
            MessageBox.Show("suprimer avec succes");
            Class1.fermer();
        }

        private void label7_Click(object sender, EventArgs e)
        {

            this.Hide();
            menu m = new menu();
            m.Show();
        }
    }
}
