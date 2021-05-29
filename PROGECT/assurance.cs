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
    public partial class assurance : Form
    {
        DataSet ds = new DataSet();
        SqlDataAdapter da;
        public assurance()
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
        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu m = new menu();
            m.Show();
        }

        private void assurance_Load(object sender, EventArgs e)
        {
            remplirecombo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string req = string.Format("insert into assurance values('{0}','{1}','{2}','{3}')",
             textBox2.Text, textBox_datedebut.Text, textBox_datefin.Text,comboBox1.Text);
            SqlCommand cmd = new SqlCommand(req, Class1.cnx);
            Class1.ouvrire();
            cmd.ExecuteNonQuery();
            MessageBox.Show("ajouter avec succes");
            Class1.fermer();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string req = string.Format("update assurance set type_contrat='{0}',date_debut='{1}',date_fin='{2}' where cin={3} ",
              textBox2.Text, textBox_datedebut.Text, textBox_datefin.Text, comboBox1.Text);
            SqlCommand cmd = new SqlCommand(req, Class1.cnx);
            Class1.ouvrire();
            cmd.ExecuteNonQuery();
            MessageBox.Show("modifier avec succes");
            Class1.fermer();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string req = string.Format("delete from assurance  where  cin={0} ",comboBox1.Text);
            SqlCommand cmd = new SqlCommand(req, Class1.cnx);
            Class1.ouvrire();
            cmd.ExecuteNonQuery();
            MessageBox.Show("suprimer avec succes");
            Class1.fermer();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            rechercher_assurance m = new rechercher_assurance();
            m.Show();
        }
    }
}
