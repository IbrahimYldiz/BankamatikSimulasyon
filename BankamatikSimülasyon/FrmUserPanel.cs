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
    public partial class FrmUserPanel : Form
    {
        public FrmUserPanel()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-OC5036T\MSSQLSERVER1;Initial Catalog=DbBank;Integrated Security=True");
        public string number;

        private void panel18_Paint(object sender, PaintEventArgs e)
        {

        }

        string account;
        decimal gonderilmekistenentutar;
        private void FrmUserPanel_Load(object sender, EventArgs e)
        {
            
            


            connection.Open();
            SqlCommand command8 = new SqlCommand("select Name,Surname,TCNo,AccountNo from TbPersons where TCNo=@p1 or AccountNo=@p2", connection);
            command8.Parameters.AddWithValue("@p1", number);
            command8.Parameters.AddWithValue("@p2", number);
            SqlDataReader dr = command8.ExecuteReader();
            while (dr.Read())
            {
                LblNameSurname.Text = dr[0].ToString() + " " + dr[1].ToString();
                LblTcNo.Text = dr[2].ToString();
                linkLabel1.Text = dr[3].ToString();

            }
            connection.Close();
            account = linkLabel1.Text;
            timer1.Start();

            
            
        }
        
        void balance()
        {
            
            connection.Open();
            SqlCommand command9 = new SqlCommand("select Balance from TblAccount where AccountNo=@p1", connection);
            command9.Parameters.AddWithValue("@p1",account);
            SqlDataReader dr7 = command9.ExecuteReader();
            while (dr7.Read())
            {
                decimal s = Convert.ToDecimal(dr7[0].ToString());
                chart1.Series["Bakiye"].Points.AddXY(s,s);
                
            }
            connection.Close();

            dr7.Close();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

      

        private void linkLabel1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(linkLabel1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command2 = new SqlCommand("select AccountNo from TbPersons where AccountNo=@p1 or TCNo=@p2", connection);
            command2.Parameters.AddWithValue("@p1", TxtBuyAccountNo.Text);
            command2.Parameters.AddWithValue("@p2", TxtBuyAccountNo.Text);
            SqlDataReader dr = command2.ExecuteReader();

            string deger = account;

            if (TxtBuyAccountNo.Text.Trim()!="")
            {
                if (TxtMoney.Text.Trim()!="")
                {
                    if (dr.Read())
                    {
                        label1.Text = dr[0].ToString();
                        dr.Close();
                        SqlCommand command4 = new SqlCommand("select Balance from TblAccount where AccountNo=@p1", connection);
                        command4.Parameters.AddWithValue("@p1", account);
                        SqlDataReader dr1 = command4.ExecuteReader();
                        if (dr1.Read()) 
                        {
                            decimal gonderenbakiye = Convert.ToDecimal(dr1[0].ToString());
                            
                            if (gonderenbakiye>=gonderilmekistenentutar)
                        {
                                dr1.Close();
                            SqlCommand command = new SqlCommand("update TblAccount set Balance=Balance+@p1 where AccountNo=@p2", connection);


                            command.Parameters.AddWithValue("@p1", TxtMoney.Text);
                            command.Parameters.AddWithValue("@p2", label1.Text);

                            SqlCommand command1 = new SqlCommand("update TblAccount set Balance=Balance-@p1 where AccountNo=@p2", connection);
                            command1.Parameters.AddWithValue("@p1", TxtMoney.Text);
                            command1.Parameters.AddWithValue("@p2", deger);

                            SqlCommand command3 = new SqlCommand("insert into TblMovement (Sender,Buyer,Amount) values(@p1,@p2,@p3)", connection);
                            command3.Parameters.AddWithValue("@p1", deger);
                            command3.Parameters.AddWithValue("@p2", label1.Text);
                            command3.Parameters.AddWithValue("@p3", TxtMoney.Text);
                            command.ExecuteNonQuery();
                            command1.ExecuteNonQuery();
                            command3.ExecuteNonQuery();
                            MessageBox.Show(label1.Text + " Numaralı Hesaba "+TxtMoney.Text+" TL Gönderildi");
                               
                        }
                        else
                        {
                            MessageBox.Show("Hesabınızdaki Para Tutarı Göndermek İstediğiniz Tutardan Az");
                        }
                        }
                        
                        dr1.Close();
                    }
                    else
                    {
                        MessageBox.Show("TC Kimlik/ Hesap Numarası Hatalı");
                    }
                    
                }
                else
                {
                    MessageBox.Show("Lütfen Gönderilecek Tutarı Giriniz");
                }
            }
            else
            {
                MessageBox.Show("Lütfen Alıcı Hesap Bilgilerini Giriniz");
            }
            connection.Close();
        }

        private void linkLabel1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            
                balance();
                
            
            
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnAccountStatement_Click(object sender, EventArgs e)
        {
            FrmAccountStatement fr = new FrmAccountStatement();
            fr.num = account;
            fr.Show();
        }

        private void TxtMoney_TextChanged(object sender, EventArgs e)
        {
            gonderilmekistenentutar = Convert.ToInt32(TxtMoney.Text);
        }
    }
}
