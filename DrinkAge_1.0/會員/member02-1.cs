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

namespace DrinkAge.會員
{
    public partial class member02_1 : Form
    {
        public member02_1()
        {
            InitializeComponent();
        }
        private bool button1WasClicked = false;
        private void button1_Click(object sender, EventArgs e)
        {
            button1WasClicked = true;
            try
            {
                string conString = Settings.Default.DrinkAgeConnectionString;
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    string RealName = this.textBox1.Text;
                    string Account = this.textBox2.Text;
                    string Password = FormsAuthentication.HashPasswordForStoringInConfigFile(this.textBox3.Text, "sha1");
                    string NickName = this.textBox6.Text;
                    string Idnumber = this.textBox4.Text;
                    string Gender = "";
                    if (radioButton1.Checked == true)
                        Gender = this.radioButton1.Text;
                    if (radioButton2.Checked == true)
                        Gender = this.radioButton2.Text;
                    string Email = this.textBox7.Text;
                    string Birth = this.dateTimePicker1.Value.ToString();
                    string Phone = this.textBox8.Text;
                    string Address = this.textBox9.Text;

                    //if (button1WasClicked == true)
                    //    blankCheck();
                    if (this.textBox5.Text != this.textBox3.Text)
                        MessageBox.Show("密碼不相同");
                    else
                    {
                        conn.Open();
                        SqlCommand command = new SqlCommand();
                        command.CommandText = "Insert into Member(RealName,Account,Password,NickName,Idnumber,Gender,Email,Birth,Phone,Address) " +
                                              "values(@RealName,@Account,@Password,@NickName,@Idnumber,@Gender,@Email,@Birth,@Phone,@Address)";
                        command.Connection = conn;
                        command.Parameters.Add("@RealName", SqlDbType.NChar, 10).Value = RealName;
                        command.Parameters.Add("@Account", SqlDbType.NVarChar, 50).Value = Account;
                        command.Parameters.Add("@Password", SqlDbType.NVarChar, 50).Value = Password;
                        command.Parameters.Add("@NickName", SqlDbType.NVarChar, 50).Value = NickName;
                        command.Parameters.Add("@Idnumber", SqlDbType.NChar, 10).Value = Idnumber;
                        command.Parameters.Add("@Gender", SqlDbType.NVarChar, 50).Value = Gender;
                        command.Parameters.Add("@Email", SqlDbType.NVarChar, 50).Value = Email;
                        command.Parameters.Add("@Birth", SqlDbType.Date).Value = Birth;
                        command.Parameters.Add("@Phone", SqlDbType.NVarChar, 50).Value = Phone;
                        command.Parameters.Add("@Address", SqlDbType.NVarChar, 50).Value = Address;

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

        private void blankCheck()
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text) || string.IsNullOrEmpty(textBox4.Text) || string.IsNullOrEmpty(textBox6.Text) || string.IsNullOrEmpty(textBox7.Text) || string.IsNullOrEmpty(textBox8.Text) || string.IsNullOrEmpty(textBox9.Text))
            {
                label5.Visible = true;
                label5.Text = "欄位不可空白";
                return;
            }
        }
    }
}
