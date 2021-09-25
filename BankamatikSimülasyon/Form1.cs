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


namespace BankamatikSimülasyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-OC5036T\MSSQLSERVER1;Initial Catalog=DbBank;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("Select * From TbPersons where Password=@p1 and (AccountNo=@p2 or TCNo=@p3)", connection);
            command.Parameters.AddWithValue("@p1", textBox2.Text);
            command.Parameters.AddWithValue("@p2", textBox1.Text);
            command.Parameters.AddWithValue("@p3", textBox1.Text);
            SqlDataReader dr = command.ExecuteReader();
            if (dr.Read())
            {
                FrmUserPanel fr = new FrmUserPanel();
                fr.number = textBox1.Text;
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı ya da şifre hatalı");
            }
            connection.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmSingup fr = new FrmSingup();
            fr.Show();
            
        }
    }
}
