using DrinkAge.會員.mods;
using DrinkAge_1._0.Properties;
using DrinkAge_1._0.會員;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Web.Security;
using System.Windows.Forms;

namespace DrinkAge.會員
{
    public partial class member01 : Form
    {
        private int pictureIndex;

        public member01()
        {
            InitializeComponent();

            timer1.Enabled = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string conString = Settings.Default.DrinkAgeConnectionString;
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    string Account = this.textBox1.Text;
                    string Password = FormsAuthentication.HashPasswordForStoringInConfigFile(this.textBox2.Text, "sha1");

                    SqlCommand command = new SqlCommand();
                    command.CommandText = "Select * from Member where Account =@Account and Password = @Password ";
                    command.Connection = conn;
                    command.Parameters.Add("@Account", SqlDbType.NVarChar, 16).Value = Account;
                    command.Parameters.Add("@Password", SqlDbType.NVarChar, 40).Value = Password;
                    conn.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        CViewBag.currentUser = Account;                        
                        MessageBox.Show("Logon Success");
                        member03 f = new member03();
                        f.Show();
                    }
                    else
                    {
                        MessageBox.Show("Logon Faild");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            member02_1 f = new member02_1();
            f.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureIndex = pictureIndex + 1;
            if (pictureIndex >= 3)
                pictureIndex = -1;
            if (pictureIndex==0)
            {
                this.pictureBox1.Image = Image.FromFile("C:\\Users\\User\\Documents\\GitHub\\slnDrinkAge_1.0\\DrinkAge_1.0\\會員\\testimg\\adv01.png");
            }
            else if (pictureIndex==1)
            {
                this.pictureBox1.Image = Image.FromFile("C:\\Users\\User\\Documents\\GitHub\\slnDrinkAge_1.0\\DrinkAge_1.0\\會員\\testimg\\adv02.png");
            }
            else if (pictureIndex==2)
            {
                this.pictureBox1.Image = Image.FromFile("C:\\Users\\User\\Documents\\GitHub\\slnDrinkAge_1.0\\DrinkAge_1.0\\會員\\testimg\\adv03.png");
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            member02_2 f2 = new member02_2();
            f2.Show();
        }
    }
}
