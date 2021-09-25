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
    public partial class FrmSingup : Form
    {
        public FrmSingup()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-OC5036T\MSSQLSERVER1;Initial Catalog=DbBank;Integrated Security=True");
        private void TxtSingup_Click(object sender, EventArgs e)
        {
            




        }

        private void FrmSingup_Load(object sender, EventArgs e)
        {
            
        }
        int ran;
        private void button2_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command1 = new SqlCommand("select * from TbPersons where TCNo=" + MskTC.Text, connection);
            SqlDataReader dr = command1.ExecuteReader();
            
            
            
            
            if (dr.Read())
            {
                MessageBox.Show("TC Kimlik Numarası Daha Öncesinde Kayıt Edilmiş.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dr.Close();
            }
            else
            {
                dr.Close();
                SqlCommand command2 = new SqlCommand("select * from TbPersons where Phone=@p1" , connection);
                command2.Parameters.AddWithValue("@p1", MskPhone.Text);
                SqlDataReader dr1 = command2.ExecuteReader();
                if (dr1.Read())
                {
                    MessageBox.Show("Telefon Numarası Daha Öncesinde Kayıt Edilmiş.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning); dr1.Close();
                }
                else
                {
                    
                    dr1.Close();

                    Random random = new Random();
                    ran = random.Next(0, 999999);
                    TxtAccountNum.Text = ran.ToString();
                    SqlCommand command3 = new SqlCommand("select * from TbPersons where AccountNo=" + ran, connection);
                    
                    SqlDataReader dr2 = command3.ExecuteReader();

                    while (dr2.Read())
                    {
                        ran = random.Next(0, 999999);
                        TxtAccountNum.Text = ran.ToString();
                    }
                    dr2.Close();
                    SqlCommand command = new SqlCommand("insert into TbPersons (Name,Surname,TCNo,Phone,AccountNo,Password) values (@p1,@p2,@p3,@p4,@p5,@p6) ", connection);
                    command.Parameters.AddWithValue("@p1", TxtName.Text);
                    command.Parameters.AddWithValue("@p2", TxtSurname.Text);
                    command.Parameters.AddWithValue("@p3", MskTC.Text);
                    command.Parameters.AddWithValue("@p4", MskPhone.Text);
                    command.Parameters.AddWithValue("@p5", ran);
                    command.Parameters.AddWithValue("@p6", TxtPass.Text);
                    command.ExecuteNonQuery();
                    SqlCommand command4 = new SqlCommand("insert into TblAccount (AccountNo,Balance) values (@p1,@p2)", connection);
                    command4.Parameters.AddWithValue("@p1", ran);
                    command4.Parameters.AddWithValue("@p2", "0");
                    command4.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Kayıt Başarılı Şekilde Tamamlandı");


                }
            }
            
            
            connection.Close();
        }

        
    }
}
