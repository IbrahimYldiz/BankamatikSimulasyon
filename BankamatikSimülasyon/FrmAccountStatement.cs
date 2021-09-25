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
    public partial class FrmAccountStatement : Form
    {
        public FrmAccountStatement()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-OC5036T\MSSQLSERVER1;Initial Catalog=DbBank;Integrated Security=True");

        public string num;
        private void FrmAccountStatement_Load(object sender, EventArgs e)
        {
            label1.Text = num;
            timer1.Start();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select TblMovement.ID as 'ID',Sender as 'Gönderen Hesap',Buyer as 'Alıcı Hesap',(Name+' '+Surname) as 'Alıcı Ad Soyad',Amount from TblMovement Inner JOIN TbPersons on TbPersons.AccountNo=TblMovement.Buyer where Sender=" + label1.Text + "or Buyer=" + label1.Text, connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            
        }
    }
}
