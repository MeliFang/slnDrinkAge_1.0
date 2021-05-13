using DrinkAge.會員.mods;
using DrinkAge_1._0.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using System.Windows.Forms;

namespace DrinkAge_1._0.會員
{
    public partial class member02_2 : Form
    {
        public member02_2()
        {
            InitializeComponent();
            this.button2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CViewBag.currentUser = this.textBox2.Text;
            try
            {
                string constring = Settings.Default.DrinkAgeConnectionString;
                using (SqlConnection conn = new SqlConnection(constring))
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand($"select RealName,Account,Idnumber from Member where RealName='{this.textBox1.Text}' AND Account='{this.textBox2.Text}' AND Idnumber='{this.textBox3.Text}'", conn);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        this.label1.Text = "新密碼:";
                        this.label2.Text = "確認密碼:";
                        this.label4.Visible = false;
                        this.textBox1.Text = "";
                        this.textBox1.PasswordChar='●';
                        this.textBox2.Text = "";
                        this.textBox2.PasswordChar = '●';
                        this.textBox3.Visible = false;
                        this.button1.Visible = false;
                        this.button2.Visible = true;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string conString = Settings.Default.DrinkAgeConnectionString;
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    string Password = FormsAuthentication.HashPasswordForStoringInConfigFile(this.textBox1.Text, "sha1");
                    //if (button1WasClicked == true)
                    //    blankCheck();
                    if (this.textBox1.Text != this.textBox2.Text)
                        MessageBox.Show("密碼不相同");
                    else
                    {
                        conn.Open();
                        SqlCommand command = new SqlCommand();
                        command.CommandText = $"Update Member Set Password='{Password}' where Account='{CViewBag.currentUser}' ";
                        command.Connection = conn;

                        command.ExecuteNonQuery();
                        MessageBox.Show("Success");
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
   

