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
    public partial class client : Form
    {
        

        public client()
        {
            InitializeComponent();
        }
        public void VIDER(Control f)
        {
            foreach (Control ct in f.Controls)
            {
                if (ct.GetType() == typeof(TextBox))
                {
                    ct.Text = "";
                }
                if (ct.Controls.Count != 0)
                {
                    VIDER(ct);
                }
            }
        }


       

       

      

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
        }

     

      

        private void MENU_Load(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string req = string.Format("insert into client values('{0}','{1}','{2}',{3},{4})",
                text_cin.Text, text_nom.Text,text_prenom.Text, text_tel.Text,text_credit.Text);
            SqlCommand cmd = new SqlCommand(req, Class1.cnx);
            Class1.ouvrire();
            cmd.ExecuteNonQuery();
            MessageBox.Show("ajouter avec succes");
            Class1.fermer();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string req = string.Format("update client set nom='{0}',prenom='{1}',tel={2},credit={3} where cin='{4}'",
                text_nom.Text,text_prenom.Text,text_tel.Text,text_credit.Text,text_cin.Text);
            SqlCommand cmd = new SqlCommand(req, Class1.cnx);
            Class1.ouvrire();
            cmd.ExecuteNonQuery();
            MessageBox.Show("modifier avec succes");
            Class1.fermer();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            string req = string.Format("delete from client where  cin='{0}' ", text_cin.Text);
            SqlCommand cmd = new SqlCommand(req, Class1.cnx);
            Class1.ouvrire();
            cmd.ExecuteNonQuery();
            MessageBox.Show("suprimer avec succes");
            Class1.fermer();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Rechercher_client r = new Rechercher_client();
            r.Show();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("voulez vous vider", " confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                VIDER(this);
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu m = new menu();
            m.Show();
        }
    }
}
